using Hexagon.ALI.Analysis.Common.Classes;
using Hexagon.ALI.Analysis.Common.Classes.SIO;
using Hexagon.ALI.Analysis.Common.Helpers.Units;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Hexagon.ALI.Analysis.Common.Helpers.Objects
{

    public class ObjectProcessor : IObjectProcessor
    {
        private readonly Dictionary<PropertyHelper, RelDefAttribute> _RelDefAttrib = new Dictionary<PropertyHelper, RelDefAttribute>();
        public void InitializeSiValue(PipingSystem pipingSystem)
        {
            List<SIOEntity> entities = GetInnerEntitiesAndRelations(pipingSystem).Entities;
            InitializeSiValue(entities, pipingSystem.UserUnits);
        }
        public void InitializeSiValue(List<SIOEntity> entities, UnitStore unitStore)
        {
            Parallel.ForEach(entities, ent =>
            {
                ent.SetUomValues(unitStore);
            });
        }
        public void InitializeSiValue(SIOEntity entity, UnitStore unitStore)
        {
            entity.SetUomValues(unitStore);
        }

        /// <summary>
        /// This method is used to retrieve inner elements (child entities) and their corresponding RelDefAttributes for a given
        /// SIOEntity object. 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        internal List<(SIOEntity Entity, RelDefAttribute RelDef)> GetInnerElements(SIOEntity entity)
        {
            IEnumerable<PropertyHelper> relDefProps = PropertyHelper.GetRelDefProperties(entity.GetType());
            List<(SIOEntity, RelDefAttribute)> listOfChildEntities = new List<(SIOEntity, RelDefAttribute)>();
            foreach (PropertyHelper childProp in relDefProps)
            {
                if (!_RelDefAttrib.ContainsKey(childProp))
                {
                    _RelDefAttrib.Add(childProp, childProp.RelDef);
                }

                dynamic entities = childProp.PropertyInfo.GetValue(entity);

                //if dynamic child is signle SIOEntity
                if (entities is SIOEntity)
                {
                    listOfChildEntities.Add((entities, _RelDefAttrib[childProp]));
                    continue;
                }
                //if dynamic child is list of SIOEntity
                else
                {
                    if (entities == null || Enumerable.Count(entities) <= 0)
                    {
                        continue;
                    }
                    foreach (var ent in entities)
                    {
                        listOfChildEntities.Add((ent, _RelDefAttrib[childProp]));
                    }
                }
            }
            return listOfChildEntities;
        }


        /// <summary>
        /// This method is used to retrieve inner elements (child entities) and their corresponding RelDefAttributes for a given
        /// SIOEntity object. 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        internal (SIOEntity Entity, List<SIOEntity> childEntities) SetInnerElements(SIOEntity entity, int numberOfSubEntitiesPerElement = 1)
        {
            IEnumerable<PropertyHelper> props = PropertyHelper.GetProperties(entity.GetType()).Values;
            List<SIOEntity> listOfChildEntities = new List<SIOEntity>();

            foreach (PropertyHelper childProp in props)
            {
                if (!childProp.PropertyInfo.PropertyType.IsClass || childProp.PropertyInfo.PropertyType == typeof(string))
                    continue;

        
                dynamic entities = childProp.PropertyInfo.GetValue(entity);

                //if dynamic child is signle SIOEntity
                if (entities is SIOEntity)
                {

                    for (int i = 0; i < numberOfSubEntitiesPerElement; i++)
                    {
                        var elementType = childProp.PropertyInfo.PropertyType;
                        if (elementType.IsSubclassOf(typeof(SIOEntity)))
                        {
                            continue;
                        }
                        dynamic obj = Activator.CreateInstance(elementType);
                        TestHelper.SetDefaultProperties(obj);
                        listOfChildEntities.Add(obj);

                    }
                    continue;

                }
                //if dynamic child is list of SIOEntity
                else
                {

                    if (entities is UnitStore)
                    {
                        continue;
                    }
                    if (entities == null)
                    {
                        continue;
                    }
                    

                    for (int i = 0; i < numberOfSubEntitiesPerElement; i++)
                    {
                        var elementType = childProp.PropertyInfo.PropertyType.GetGenericArguments()[0];
                        if (elementType.IsAbstract)
                        {
                            var derivedTypes = Assembly.GetExecutingAssembly()
                                          .GetTypes()
                                          .Where(t => elementType.IsAssignableFrom(t) && !t.IsAbstract);
                            foreach (var type in derivedTypes)
                            {
                                dynamic obj = Activator.CreateInstance(type);
                                TestHelper.SetDefaultProperties(obj);
                                entities.Add(obj);
                            }
                        }
                        else
                        {
                            if (!elementType.IsSubclassOf(typeof(SIOEntity)))
                            {
                                continue;
                            }
                            dynamic obj = Activator.CreateInstance(elementType);
                            TestHelper.SetDefaultProperties(obj);
                            entities.Add(obj);

                        }
                    }
                    if(Enumerable.Count(entities) > 0)
                    {
                        listOfChildEntities.AddRange(entities);
   
                    }
                }
            }
            
            return (entity, listOfChildEntities);
        }

        /// <summary>
        /// Recursively sets the inner relations for the provided SIOEntity object and its child entities. 
        /// It identifies the relationships between entities and adds them to lists of entities and relations passed in the parameter. 
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="entities"></param>
        /// <param name="relations"></param>
        void RecursivelyGetInnerRelations(SIOEntity entity, HashSet<SIOEntity> entities, HashSet<SIORelation> relations)
        {
            if (!entities.Contains(entity))
            {

                entities.Add(entity);

                foreach (var childObj in GetInnerElements(entity))
                {
                    var childEntity = childObj.Entity;
                    if (childEntity != entity)
                    {
                        RecursivelyGetInnerRelations(childEntity, entities, relations);
                    }


                    entities.Add(childEntity);
                    childEntity.End1Relation = entity;
                    relations.Add(new SIORelation(entity, childObj.Entity, childObj.RelDef));
                }
            }
        }

        /// <summary>
        /// This method is used to retrieve inner entities and their corresponding relations for the provided SIOEntity object.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>
        /// Filters and returns distinct inner entities and unique relations associated
        /// with them.
        /// </returns>
        public (List<SIOEntity> Entities, List<SIORelation> Relations) GetInnerEntitiesAndRelations(SIOEntity entity)
        {
            HashSet<SIOEntity> entities = new HashSet<SIOEntity>();
            HashSet<SIORelation> relations = new HashSet<SIORelation>();
            RecursivelyGetInnerRelations(entity, entities, relations);

            var listOfEnt = entities.ToList();
            var listOfRelations = relations.ToList();

            return (listOfEnt, listOfRelations);
        }

        Dictionary<Type, TypeConverter> typeConverters = new Dictionary<Type, TypeConverter>();

        /// <summary>
        /// Construct SioEntities into Batches based on batch size
        /// </summary>
        /// <param name="entities"></param>
        /// <param name="relations"></param>
        /// <param name="batchSize"></param>
        /// <returns>IEnumerable<IEnumerable<SIOEntity>></returns>
        /// <exception cref="Exception"></exception>
        public IEnumerable<IEnumerable<SIOObject>> CreateBatchFromConnectedSubGraphsBatchSize(
            IEnumerable<SIOEntity> entities,
            IEnumerable<SIORelation> relations,
            int batchSize)
        {
            entities = entities.Distinct();
            relations = relations.Distinct();
            Dictionary<string, List<SIORelation>> vertexIdToEdge = new Dictionary<string, List<SIORelation>>();
            Dictionary<string, SIOEntity> vertexIdToVertex = new Dictionary<string, SIOEntity>();
            HashSet<SIOEntity> addedVertex = new HashSet<SIOEntity>();
            HashSet<SIORelation> addedEdge = new HashSet<SIORelation>();
            int totalObject = entities.Count() + relations.Count();



            foreach (SIORelation r in relations)
            {
                if (r.RelationDefinition.minEnd1)
                {
                    if (!vertexIdToEdge.ContainsKey(r.End2.InternalID))
                    {
                        vertexIdToEdge[r.End2.InternalID] = new List<SIORelation>();
                    }

                    vertexIdToEdge[r.End2.InternalID].Add(r);
                }
                else if (r.RelationDefinition.minEnd2)
                {
                    if (!vertexIdToEdge.ContainsKey(r.End1.InternalID))
                    {
                        vertexIdToEdge[r.End1.InternalID] = new List<SIORelation>();
                    }

                    vertexIdToEdge[r.End1.InternalID].Add(r);
                }
            }
            foreach (SIOEntity entity in entities)
            {
                vertexIdToVertex[entity.InternalID] = entity;
            }

            List<SIOObject> currList = new List<SIOObject>();
            List<List<SIOObject>> allList = new List<List<SIOObject>>();
            foreach (SIOEntity entity in entities)
            {
                if (currList.Count >= batchSize)
                {
                    allList.Add(currList);
                    currList = new List<SIOObject>();
                }
                if (addedVertex.Add(entity))
                {
                    Queue<SIOEntity> vertexToAdd = new Queue<SIOEntity>();
                    vertexToAdd.Enqueue(entity);
                    while (vertexToAdd.Count > 0)
                    {
                        SIOEntity currVertex = vertexToAdd.Dequeue();
                        currList.Add(currVertex);
                        addedVertex.Add(currVertex);
                        if (vertexIdToEdge.ContainsKey(currVertex.InternalID))
                        {

                            foreach (SIORelation r in vertexIdToEdge[currVertex.InternalID])
                            {
                                if (addedEdge.Add(r))
                                {
                                    currList.Add(r);
                                    SIOEntity newVertex = null;
                                    if (r.End1.InternalID == currVertex.InternalID && vertexIdToVertex.ContainsKey(r.End2.InternalID))
                                    {
                                        newVertex = vertexIdToVertex[r.End2.InternalID];
                                    }
                                    else if (r.End2.InternalID == currVertex.InternalID && vertexIdToVertex.ContainsKey(r.End1.InternalID))
                                    {
                                        newVertex = vertexIdToVertex[r.End1.InternalID];
                                    }
                                    if (newVertex != null)
                                    {
                                        if (!addedVertex.Contains(newVertex))
                                        {
                                            vertexToAdd.Enqueue(newVertex);
                                        }
                                    }
                                }
                            }

                        }

                    }
                }
            }
            if (currList.Count > 0)
            {
                allList.Add(currList);
            }
            int totalObjectInBatches = 0;
            foreach (List<SIOObject> b in allList)
            {
                totalObjectInBatches += b.Count();
            }

            if (addedEdge.Count() != relations.Count() || addedVertex.Count() != entities.Count() || totalObjectInBatches != totalObject)
            {
                throw new Exception($"The expected relationship count was expected to be [{relations.Count()}, but the actual count was [{addedEdge.Count()}], " +
                    $"or the epxected entity count was expected to be [{entities.Count()}], but the actual count was [{addedVertex.Count()}]");
            }

            return allList;
        }

        /// <summary>
        /// Construct SioEntities into batches based on the number of batches
        /// </summary>
        /// <param name="entities"></param>
        /// <param name="relations"></param>
        /// <param name="numberOfBatches"></param>
        /// <returns>IEnumerable<IEnumerable<SIOEntity>></returns>
        public IEnumerable<IEnumerable<SIOObject>> CreateBatchFromConnectedSubGraphsNumberOfBatches(
            IEnumerable<SIOEntity> entities,
            IEnumerable<SIORelation> relations,
            int numberOfBatches)
        {
            int totalObject = entities.Count() + relations.Count();
            int batchSize = totalObject / numberOfBatches;
            if (totalObject % numberOfBatches > 0)
            {
                batchSize += 1;
            }

            return CreateBatchFromConnectedSubGraphsBatchSize(entities, relations, batchSize);
        }

        /// <summary>
        /// Split list of entities into Required Connected Entities, SioRelations and SioEntities 
        /// </summary>
        /// <param name="entities"></param>
        /// <returns>Tuple of ConnectedEnd Entities,ConnectedEndRelations,and the rest of the Entities and Relations</returns>
        public (IEnumerable<SIOEntity> ConnectedEntities, IEnumerable<SIORelation> ConnectedRelation, IEnumerable<SIOObject> OtherEntitiesAndRelations) ConstructBatch(List<SIOObject> entities)
        {
            IEnumerable<SIORelation> allrels = entities.OfType<SIORelation>();
            int allrelsNumber = allrels.Count();
            List<SIORelation> relEnts = allrels.GroupBy(g => g.Id).Select(s => s.First()).ToList();
            List<SIOObject> ppmobjs = entities.Where(x => !(x is SIORelation)).Distinct().Cast<SIOObject>().ToList();

            List<SIORelation> requiredEndRelations = relEnts.Where(s => s.RelationDefinition.minEnd1 || s.RelationDefinition.minEnd2).Distinct().ToList();
            requiredEndRelations = requiredEndRelations.GroupBy(p => p.Id).Select(s => s.First()).ToList();
            HashSet<SIOEntity> connectedEndObjs = new HashSet<SIOEntity>();
            HashSet<SIORelation> connectedEndRels = new HashSet<SIORelation>();
            Dictionary<string, SIOEntity> dict = new Dictionary<string, SIOEntity>();
            List<List<SIOEntity>> listofAutoBatchFirst = new List<List<SIOEntity>>();
            List<List<SIOEntity>> listofAutoBatchSecond = new List<List<SIOEntity>>();

            foreach (SIOEntity obj in ppmobjs)
            {
                dict.Add(obj.InternalID, obj);
            }

            foreach (SIORelation i in requiredEndRelations)
            {
                connectedEndRels.Add(i);
                if (i.RelationDefinition.minEnd1)
                {
                    connectedEndObjs.Add(dict[i.End2.InternalID]);
                }
            }

            ppmobjs.AddRange(relEnts);
            IEnumerable<SIOObject> remainingObjects = ppmobjs.Except(connectedEndObjs).Except(connectedEndRels);
            return (connectedEndObjs, connectedEndRels, remainingObjects);
        }
    }

    public interface IObjectProcessor
    {
        IEnumerable<IEnumerable<SIOObject>> CreateBatchFromConnectedSubGraphsNumberOfBatches(
            IEnumerable<SIOEntity> entities,
            IEnumerable<SIORelation> relations,
            int numberOfBatches);
        IEnumerable<IEnumerable<SIOObject>> CreateBatchFromConnectedSubGraphsBatchSize(
            IEnumerable<SIOEntity> entities,
            IEnumerable<SIORelation> relations,
            int batchSize);
        (IEnumerable<SIOEntity> ConnectedEntities, IEnumerable<SIORelation> ConnectedRelation, IEnumerable<SIOObject> OtherEntitiesAndRelations) ConstructBatch(List<SIOObject> entities);
        (List<SIOEntity> Entities, List<SIORelation> Relations) GetInnerEntitiesAndRelations(SIOEntity entity);
    }
}
