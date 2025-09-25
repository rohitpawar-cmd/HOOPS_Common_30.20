using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Hexagon.ALI.Analysis.Common.Helpers.Objects
{
    public class PropertyHelper
    {
        private static readonly ConcurrentDictionary<Type, Dictionary<string, PropertyHelper>> Cache = new ConcurrentDictionary<Type, Dictionary<string, PropertyHelper>>();
        private static readonly ConcurrentDictionary<Type, Dictionary<string, PropertyHelper>> InterfaceCache = new ConcurrentDictionary<Type, Dictionary<string, PropertyHelper>>();
        private PropertyHelper() { }

        public static Dictionary<string, PropertyHelper> GetProperties(Type type) => Cache
             .GetOrAdd(type, _ => type
             .GetProperties()
             .Select(property =>
             {
                 bool isRelDef = property.CustomAttributes.Any(e => e.AttributeType.Name == nameof(RelDefAttribute));
                 bool isPPMAttr = property.CustomAttributes.Any(e => e.AttributeType.Name == nameof(PPMPropertyAttribute));
                 bool isUoM = property.CustomAttributes.Any(e => e.AttributeType.Name == nameof(UoMAttribute));
                 bool isSiValue = property.Name.Contains("SiValue");

                 return new PropertyHelper
                 {
                     Name = property.Name,
                     PropertyInfo = property,
                     IsRelDefAttribute = isRelDef,
                     IsPPMPropertyAttribute = isPPMAttr,
                     IsSiValue = isSiValue,
                     IsUoMAttribute = isUoM,
                     UoM = isUoM ? property.GetCustomAttributes(true).OfType<UoMAttribute>().First() : null,
                     RelDef = isRelDef ? property.GetCustomAttributes(true).OfType<RelDefAttribute>().First() : null
                 };
             }).GroupBy(g => g.Name).Select(s => s.First())
             .ToDictionary(s => s.Name, s => s));

        public static Dictionary<string, PropertyHelper> GetInterfaces(Type type) => InterfaceCache
             .GetOrAdd(type, _ => type
             .GetInterfaces()
             .SelectMany(s => s.GetProperties())
             .Select(property =>
             {
                 bool isRelDef = property.CustomAttributes.Any(e => e.AttributeType.Name == nameof(RelDefAttribute));
                 bool isPPMAttr = property.CustomAttributes.Any(e => e.AttributeType.Name == nameof(PPMPropertyAttribute));
                 bool isUoM = property.CustomAttributes.Any(e => e.AttributeType.Name == nameof(UoMAttribute));
                 bool isSiValue = property.Name.Contains("SiValue");

                 return new PropertyHelper
                 {
                     Name = property.Name,
                     PropertyInfo = property,
                     IsRelDefAttribute = isRelDef,
                     IsPPMPropertyAttribute = isPPMAttr,
                     IsSiValue = isSiValue,
                     IsUoMAttribute = isUoM,
                     UoM = isUoM ? property.GetCustomAttributes(true).OfType<UoMAttribute>().First() : null,
                     RelDef = isRelDef ? property.GetCustomAttributes(true).OfType<RelDefAttribute>().First() : null
                 };
             }).GroupBy(g => g.Name).Select(s => s.First())
             .ToDictionary(s => s.Name, s => s));

        public static IEnumerable<PropertyHelper> GetUoMPropertyInfos(Type type) => GetInterfaces(type).Values.Where(w => w.IsUoMAttribute);

        public static IEnumerable<PropertyHelper> GetPPMPropertyInfos(Type type) => GetInterfaces(type).Values.Where(w => w.IsPPMPropertyAttribute);

        public static IEnumerable<PropertyHelper> GetRelDefProperties(Type type) => GetInterfaces(type).Values.Where(w => w.IsRelDefAttribute);

        public static IEnumerable<PropertyInfo> GetSiValuePropertyInfos(Type type) => GetInterfaces(type).Where(w => w.Value.IsSiValue).Select(s => s.Value.PropertyInfo);

        internal static void ClearCache() => Cache.Clear();

        public string Name { get; protected set; }
        public PropertyInfo PropertyInfo { get; protected set; }
        public bool IsSiValue { get; protected set; }
        public bool IsPPMPropertyAttribute { get; protected set; }
        public bool IsRelDefAttribute { get; protected set; }
        public bool IsUoMAttribute { get; protected set; }
        public RelDefAttribute RelDef { get; protected set; }
        public UoMAttribute UoM { get; protected set; }
    }
}
