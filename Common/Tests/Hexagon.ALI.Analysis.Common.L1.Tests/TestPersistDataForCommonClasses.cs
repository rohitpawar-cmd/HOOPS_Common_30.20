using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.NodalAuxiliaries.Outputs;
using Hexagon.ALI.Analysis.Common.Enums;
using Hexagon.ALI.Analysis.DataAccess.Classes;
using Hexagon.ALI.Analysis.PublisherSQLiteSDK.Classes;
using System.Data;
using System.Data.SQLite;
using Hexagon.ALI.Analysis.Common.Classes;
using System.Reflection;
using System.Collections;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.LineElementAuxiliaries.Outputs;
using Hexagon.ALI.Analysis.PublisherSQLiteSDK;
using Hexagon.ALI.Analysis.Common.Classes.Analysis;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.Allowables;

namespace Hexagon.ALI.Analysis.Common.L1.Tests
{
    public class TestPersistDataForCommonClasses
    {

        internal static string testTableName = "TestData";
        internal static string databaseName = "TestDB.a2db";
        internal static string testDBFilePath = string.Empty;
        internal static SQLiteConnection connection = new();
        public TestPersistDataForCommonClasses()
        {

        }

        #region A20-179-35
        [Fact, Trait("Insert_Into_AnalysisLineElement", "1")]
        public async void Insert_Into_AnalysisLineElement()
        {
            //arrange
            await CopyDatabase($"AnalysisLineElement{databaseName}", "AnalysisLineElement.a2db");
            Assert.True(connection.State == ConnectionState.Open);
            string id = Guid.NewGuid().ToString();
            string parentID = Guid.NewGuid().ToString();
            int elementTypeID = (int)CAESARIIElementType.AnalysisExpansionJoint;
            string elementType = CAESARIIElementType.AnalysisExpansionJoint.ToString();
            string name = "Test Line Element";
            string description = "";
            string basedx = "90";
            string basedy = "180";
            string basedz = "270";
            string fromnode = Guid.NewGuid().ToString();
            string tonode = Guid.NewGuid().ToString();
            int flags = 1;
            int inputElementOrderNumber = 2;
            int dynamicsElementOrderNumner = 3;
            int parentElementOrderNumber = 4;
            int staticsElementOrderNumber = 5;

            DataSet ds = new DataSet();
            DataTable dt = new DataTable("AnalysisLineElement");
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("ParentID", typeof(string));
            dt.Columns.Add("FromNodeID", typeof(string));
            dt.Columns.Add("ToNodeID", typeof(string));
            dt.Columns.Add("ElementTypeID", typeof(int));
            dt.Columns.Add("ElementType", typeof(string));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Description", typeof(string));
            dt.Columns.Add("BaseDX", typeof(string));
            dt.Columns.Add("BaseDY", typeof(string));
            dt.Columns.Add("BaseDZ", typeof(string));
            dt.Columns.Add("Flags", typeof(int));
            dt.Columns.Add("InputElementOrderNumber", typeof(int));
            dt.Columns.Add("DynamicsElementOrderNumner", typeof(int));
            dt.Columns.Add("ParentElementOrderNumber", typeof(int));
            dt.Columns.Add("StaticsElementOrderNumber", typeof(int));
            dt.Rows.Add(id, parentID, fromnode, tonode, elementTypeID, elementType, name, description, basedx, basedy, basedz, flags, inputElementOrderNumber, dynamicsElementOrderNumner, parentElementOrderNumber, staticsElementOrderNumber);
            ds.Tables.Add(dt);

            //act
            bool retVal = await new SQLiteOperations(new DatabaseOptions()).PersistData(ds, connection.FileName);
            DataTable? dataTable = (await new SQLiteOperations(new DatabaseOptions()).RetrieveData(new List<string> { "AnalysisLineElement" }, connection.FileName)).Tables["AnalysisLineElement"];

            //assert
            Assert.True(retVal);
            Assert.NotNull(dataTable);
            foreach (DataRow row in dataTable.Rows)
            {
                Assert.Equal(elementTypeID, Convert.ToInt32(row["ElementTypeID"]));
                Assert.Equal(elementType, row["ElementType"]);
                Assert.Equal(basedx, row["BaseDX"]);
                Assert.Equal(basedy, row["BaseDY"]);
                Assert.Equal(basedz, row["BaseDZ"]);
                Assert.Equal(fromnode, row["FromNodeID"]);
                Assert.Equal(tonode, row["ToNodeID"]);
                Assert.Equal(parentID, row["ParentID"]);
                Assert.Equal(flags, Convert.ToInt32(row["Flags"]));
                Assert.Equal(inputElementOrderNumber, Convert.ToInt32(row["InputElementOrderNumber"]));
                Assert.Equal(dynamicsElementOrderNumner, Convert.ToInt32(row["DynamicsElementOrderNumner"]));
                Assert.Equal(parentElementOrderNumber, Convert.ToInt32(row["ParentElementOrderNumber"]));
                Assert.Equal(staticsElementOrderNumber, Convert.ToInt32(row["StaticsElementOrderNumber"]));                
                Assert.Equal(name, row["Name"]);
            }
        }
        #endregion


        [Fact, Trait("Insert_Into_AnalysisFlangeNC_3658_3", "1")]
        public async void Insert_Into_AnalysisFlangeNC_3658_3()
        {
            //arrange
            await CopyDatabase($"{nameof(AnalysisFlangeNC_3658_3)}{databaseName}", $"{nameof(AnalysisFlangeNC_3658_3)}.a2db");
            Assert.True(connection.State == ConnectionState.Open);


            DataSet ds = new DataSet();
            DataTable dt = new DataTable(nameof(AnalysisFlangeNC_3658_3));
            var ignore = new List<string> { "OBID", "UID", "InternalID" };
            var properties = typeof(AnalysisFlangeNC_3658_3).GetProperties();
            List<PropertyInfo> propertiesToPersist = new();

            var testObject = new AnalysisFlangeNC_3658_3();

            SetDefaultProperties(testObject, properties);


            foreach (var property in properties)
            {
                if (property.PropertyType.Name.Equals("Nullable`1"))
                {
                    dt.Columns.Add(property.Name, property.PropertyType.GenericTypeArguments[0]);
                    propertiesToPersist.Add(property);
                    continue;
                }
                if (typeof(IEnumerable).IsAssignableFrom(property.PropertyType) && property.PropertyType != typeof(string))
                    continue;
                if (property.PropertyType.IsInterface)
                    continue;
                if (ignore.Contains(property.Name))
                    continue;
                dt.Columns.Add(property.Name, property.PropertyType);
                propertiesToPersist.Add(property);
            }
            DataRow row = dt.NewRow();
            foreach (var property in propertiesToPersist)
            {
                row[property.Name] = property.GetValue(testObject);
            }
            dt.Rows.Add(row);
            ds.Tables.Add(dt);

            //act
            bool retVal = await new SQLiteOperations(new DatabaseOptions()).PersistData(ds, connection.FileName);
            DataTable? dataTable = (await new SQLiteOperations(new DatabaseOptions()).RetrieveData(new List<string> { nameof(AnalysisFlangeNC_3658_3) }, connection.FileName)).Tables[nameof(AnalysisFlangeNC_3658_3)];

            //assert
            Assert.True(retVal);
            Assert.NotNull(dataTable);
            foreach (DataRow dataRow in dataTable.Rows)
            {
                foreach (var property in propertiesToPersist)
                {
                    Assert.Equal(dataRow[property.Name], property.GetValue(testObject));
                }
            }
        }

        [Fact, Trait("Insert_Into_AnalysisFlangePeq", "1")]
        public async void Insert_Into_AnalysisFlangePeq()
        {
            //arrange
            await CopyDatabase($"{nameof(AnalysisFlangePeq)}{databaseName}", $"{nameof(AnalysisFlangePeq)}.a2db");
            Assert.True(connection.State == ConnectionState.Open);


            DataSet ds = new DataSet();
            DataTable dt = new DataTable(nameof(AnalysisFlangePeq));
            var ignore = new List<string> { "OBID", "UID", "InternalID" };
            var properties = typeof(AnalysisFlangePeq).GetProperties();
            List<PropertyInfo> propertiesToPersist = new();

            var testObject = new AnalysisFlangePeq();

            SetDefaultProperties(testObject, properties);


            foreach (var property in properties)
            {
                if (property.PropertyType.Name.Equals("Nullable`1"))
                {
                    dt.Columns.Add(property.Name, property.PropertyType.GenericTypeArguments[0]);
                    propertiesToPersist.Add(property);
                    continue;
                }
                if (typeof(IEnumerable).IsAssignableFrom(property.PropertyType) && property.PropertyType != typeof(string))
                    continue;
                if (property.PropertyType.IsInterface)
                    continue;
                if (ignore.Contains(property.Name))
                    continue;
                dt.Columns.Add(property.Name, property.PropertyType);
                propertiesToPersist.Add(property);
            }
            DataRow row = dt.NewRow();
            foreach (var property in propertiesToPersist)
            {
                row[property.Name] = property.GetValue(testObject);
            }
            dt.Rows.Add(row);
            ds.Tables.Add(dt);

            //act
            bool retVal = await new SQLiteOperations(new DatabaseOptions()).PersistData(ds, connection.FileName);
            DataTable? dataTable = (await new SQLiteOperations(new DatabaseOptions()).RetrieveData(new List<string> { nameof(AnalysisFlangePeq) }, connection.FileName)).Tables[nameof(AnalysisFlangePeq)];

            //assert
            Assert.True(retVal);
            Assert.NotNull(dataTable);
            foreach (DataRow dataRow in dataTable.Rows)
            {
                foreach (var property in propertiesToPersist)
                {
                    Assert.Equal(dataRow[property.Name], property.GetValue(testObject));
                }
            }
        }

        [Fact, Trait("Insert_Into_AnalysisNozzleLimitCheckOutput", "1")]
        public async void Insert_Into_AnalysisNozzleLimitCheckOutput()
        {
            //arrange
            await CopyDatabase($"{nameof(AnalysisNozzleLimitCheckOutput)}{databaseName}", $"{nameof(AnalysisNozzleLimitCheckOutput)}.a2db");
            Assert.True(connection.State == ConnectionState.Open);


            DataSet ds = new DataSet();
            DataTable dt = new DataTable(nameof(AnalysisNozzleLimitCheckOutput));
            var ignore = new List<string> { "OBID", "UID", "InternalID" };
            var properties = typeof(AnalysisNozzleLimitCheckOutput).GetProperties();
            List<PropertyInfo> propertiesToPersist = new();

            var testObject = new AnalysisNozzleLimitCheckOutput();

            SetDefaultProperties(testObject, properties);


            foreach (var property in properties)
            {
                if (property.PropertyType.Name.Equals("Nullable`1"))
                {
                    dt.Columns.Add(property.Name, property.PropertyType.GenericTypeArguments[0]);
                    propertiesToPersist.Add(property);
                    continue;
                }
                if (typeof(IEnumerable).IsAssignableFrom(property.PropertyType) && property.PropertyType != typeof(string))
                    continue;
                if (property.PropertyType.IsInterface)
                    continue;
                if (ignore.Contains(property.Name))
                    continue;
                dt.Columns.Add(property.Name, property.PropertyType);
                propertiesToPersist.Add(property);
            }
            DataRow row = dt.NewRow();
            foreach (var property in propertiesToPersist)
            {
                row[property.Name] = property.GetValue(testObject);
            }
            dt.Rows.Add(row);
            ds.Tables.Add(dt);

            //act
            bool retVal = await new SQLiteOperations(new DatabaseOptions()).PersistData(ds, connection.FileName);
            DataTable? dataTable = (await new SQLiteOperations(new DatabaseOptions()).RetrieveData(new List<string> { "AnalysisNozzleLimitCheckOutput" }, connection.FileName)).Tables["AnalysisNozzleLimitCheckOutput"];

            //assert
            Assert.True(retVal);
            Assert.NotNull(dataTable);
            foreach (DataRow dataRow in dataTable.Rows)
            {
                foreach (var property in propertiesToPersist)
                {
                    Assert.Equal(dataRow[property.Name], property.GetValue(testObject));
                }
            }
        }

        [Theory, Trait("Insert_Into_DNVOutputs", "1")]
        [InlineData(typeof(AnalysisDNVComponentsOutput))]
        [InlineData(typeof(AnalysisDNVDetailsOutput))]
        [InlineData(typeof(AnalysisDNVThicknessOutput))]
        [InlineData(typeof(AnalysisLineElementDNVOutput))]
        public async void Create_ValidEnumValAsInput_ReturnsSIPEntityExpected(Type type)
        {
            if (Constants.SIOTablesToIgnore.Contains(type.Name))
                return;
            //arrange
            await CopyDatabase($"{type.Name}{databaseName}", $"{type.Name}.a2db");
            Assert.True(connection.State == System.Data.ConnectionState.Open);


            DataSet ds = new DataSet();
            DataTable dt = new DataTable(type.Name);
            var ignore = new List<string> { "OBID", "UID", "InternalID" };
            var properties = type.GetProperties();
            List<PropertyInfo> propertiesToPersist = new();

            var testObject = SIOFactory.Create(type);
            Assert.NotNull(testObject);
            SetDefaultProperties(testObject, properties);

            foreach (var property in properties)
            {
                if (property.PropertyType.Name.Equals("Nullable`1"))
                {
                    dt.Columns.Add(property.Name, property.PropertyType.GenericTypeArguments[0]);
                    propertiesToPersist.Add(property);
                    continue;
                }
                if (typeof(IEnumerable).IsAssignableFrom(property.PropertyType) && property.PropertyType != typeof(string))
                    continue;
                if (property.PropertyType.IsInterface)
                    continue;
                if (ignore.Contains(property.Name))
                    continue;
                dt.Columns.Add(property.Name, property.PropertyType);
                propertiesToPersist.Add(property);
            }

            DataRow row = dt.NewRow();
            foreach (var property in propertiesToPersist)
            {
                if (property.GetValue(testObject) == null)
                {
                    row[property.Name] = DBNull.Value;
                }
                else
                    row[property.Name] = property.GetValue(testObject);
            }
            dt.Rows.Add(row);
            ds.Tables.Add(dt);

            //act
            bool retVal = await new SQLiteOperations(new DatabaseOptions()).PersistData(ds, connection.FileName);
            DataTable? dataTable = (await new SQLiteOperations(new DatabaseOptions()).RetrieveData(new List<string> { type.Name }, connection.FileName)).Tables[type.Name];

            //assert
            Assert.True(retVal);
            Assert.NotNull(dataTable);
            foreach (DataRow dataRow in dataTable.Rows)
            {
                foreach (var property in propertiesToPersist)
                {
                    Assert.Equal(dataRow[property.Name], property.GetValue(testObject));
                }
            }
        }
                
        [Fact, Trait("Insert_Into_AnalysisHangerReport", "1")]
        public async void Insert_Into_AnalysisHangerReport()
        {
            //arrange
            await CopyDatabase($"{nameof(AnalysisHangerReport)}{databaseName}", "AnalysisHangerReport.a2db");
            Assert.True(connection.State == ConnectionState.Open);

            string id = Guid.NewGuid().ToString();
            string manufacturer = "ANVIL";
            string figure = "98";
            int? size = 13;
            string name = "Test Analysis Hanger Report";
            string description = "";
            string verticalMovement = "-1.533199";
            string horizontalMovement = "1.270669";
            string springRate = "300";
            string hotLoad = "2934.275879";
            string theoreticalInstalledLoad = "2474.316162";
            string actualInstalledLoad = "0";
            double? loadVariation = 16.175407;


            DataSet ds = new DataSet();
            DataTable dt = new DataTable("AnalysisHangerReport");
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add(nameof(AnalysisHangerReport.Manufacturer), typeof(string));
            dt.Columns.Add(nameof(AnalysisHangerReport.Figure), typeof(string));
            dt.Columns.Add(nameof(AnalysisHangerReport.Size), typeof(int));
            dt.Columns.Add(nameof(AnalysisHangerReport.Name), typeof(string));
            dt.Columns.Add(nameof(AnalysisHangerReport.Description), typeof(string));
            dt.Columns.Add(nameof(AnalysisHangerReport.VerticalMovement), typeof(string));
            dt.Columns.Add(nameof(AnalysisHangerReport.HorizontalMovement), typeof(string));
            dt.Columns.Add(nameof(AnalysisHangerReport.SpringRate), typeof(string));
            dt.Columns.Add(nameof(AnalysisHangerReport.HotLoad), typeof(string));
            dt.Columns.Add(nameof(AnalysisHangerReport.TheoreticalInstalledLoad), typeof(string));
            dt.Columns.Add(nameof(AnalysisHangerReport.ActualInstalledLoad), typeof(string));
            dt.Columns.Add(nameof(AnalysisHangerReport.LoadVariation), typeof(double));
            dt.Columns.Add(nameof(AnalysisHangerReport.VerticalMovementSiValue), typeof(double));
            dt.Columns.Add(nameof(AnalysisHangerReport.HorizontalMovementSiValue), typeof(double));
            dt.Columns.Add(nameof(AnalysisHangerReport.SpringRateSiValue), typeof(double));
            dt.Columns.Add(nameof(AnalysisHangerReport.HotLoadSiValue), typeof(double));
            dt.Columns.Add(nameof(AnalysisHangerReport.TheoreticalInstalledLoadSiValue), typeof(double));
            dt.Columns.Add(nameof(AnalysisHangerReport.ActualInstalledLoadSiValue), typeof(double));
            dt.Rows.Add(id, manufacturer, figure, size, name, description, verticalMovement, horizontalMovement, springRate, hotLoad, theoreticalInstalledLoad, actualInstalledLoad, loadVariation);
            ds.Tables.Add(dt);

            //act
            bool retVal = await new SQLiteOperations(new DatabaseOptions()).PersistData(ds, connection.FileName);
            DataTable? dataTable = (await new SQLiteOperations(new DatabaseOptions()).RetrieveData(new List<string> { "AnalysisHangerReport" }, connection.FileName)).Tables["AnalysisHangerReport"];

            //assert
            Assert.True(retVal);
            Assert.NotNull(dataTable);
            foreach (DataRow row in dataTable.Rows)
            {
                Assert.Equal(manufacturer, row[nameof(AnalysisHangerReport.Manufacturer)]);
                Assert.Equal(figure, row[nameof(AnalysisHangerReport.Figure)]);
                Assert.Equal(size, Convert.ToInt32(row[nameof(AnalysisHangerReport.Size)]));
                Assert.Equal(verticalMovement, row[nameof(AnalysisHangerReport.VerticalMovement)]);
                Assert.Equal(horizontalMovement, row[nameof(AnalysisHangerReport.HorizontalMovement)]);
                Assert.Equal(springRate, row[nameof(AnalysisHangerReport.SpringRate)]);
                Assert.Equal(hotLoad, row[nameof(AnalysisHangerReport.HotLoad)]);
                Assert.Equal(theoreticalInstalledLoad, row[nameof(AnalysisHangerReport.TheoreticalInstalledLoad)]);
                Assert.Equal(actualInstalledLoad, row[nameof(AnalysisHangerReport.ActualInstalledLoad)]);
                Assert.Equal(loadVariation, Convert.ToDouble(row[nameof(AnalysisHangerReport.LoadVariation)]));
                Assert.Equal(name, row[nameof(AnalysisHangerReport.Name)]);
            }
        }

        [Theory, Trait("Insert_Into_AnalysisDensities", "1")]
        [InlineData(typeof(AnalysisDensities))]
        public async void Create_Insert_Into_AnalysisDensities_ReturnsExpected(Type type)
        {
            if (Constants.SIOTablesToIgnore.Contains(type.Name))
                return;
            //arrange
            await CopyDatabase($"{type.Name}{databaseName}", $"{type.Name}.a2db");
            Assert.True(connection.State == System.Data.ConnectionState.Open);


            DataSet ds = new DataSet();
            DataTable dt = new DataTable(type.Name);
            var ignore = new List<string> { "OBID", "UID", "InternalID" };
            var properties = type.GetProperties();
            List<PropertyInfo> propertiesToPersist = new();

            var testObject = SIOFactory.Create(type);
            Assert.NotNull(testObject);
            SetDefaultProperties(testObject, properties);

            foreach (var property in properties)
            {
                if (property.PropertyType.Name.Equals("Nullable`1"))
                {
                    dt.Columns.Add(property.Name, property.PropertyType.GenericTypeArguments[0]);
                    propertiesToPersist.Add(property);
                    continue;
                }
                if (typeof(IEnumerable).IsAssignableFrom(property.PropertyType) && property.PropertyType != typeof(string))
                    continue;
                if (property.PropertyType.IsInterface)
                    continue;
                if (ignore.Contains(property.Name))
                    continue;
                dt.Columns.Add(property.Name, property.PropertyType);
                propertiesToPersist.Add(property);
            }

            DataRow row = dt.NewRow();
            foreach (var property in propertiesToPersist)
            {
                if (property.GetValue(testObject) == null)
                {
                    row[property.Name] = DBNull.Value;
                }
                else
                    row[property.Name] = property.GetValue(testObject);
            }
            dt.Rows.Add(row);
            ds.Tables.Add(dt);

            //act
            bool retVal = await new SQLiteOperations(new DatabaseOptions()).PersistData(ds, connection.FileName);
            DataTable? dataTable = (await new SQLiteOperations(new DatabaseOptions()).RetrieveData(new List<string> { type.Name }, connection.FileName)).Tables[type.Name];

            //assert
            Assert.True(retVal);
            Assert.NotNull(dataTable);
            foreach (DataRow dataRow in dataTable.Rows)
            {
                foreach (var property in propertiesToPersist)
                {
                    if (property.Name.Contains("SiValue"))
                    {
                        continue;
                    }
                    Assert.Equal(dataRow[property.Name], property.GetValue(testObject));
                }
            }
        }


        #region A20-179-19 TESTS
        [Fact, Trait("Insert_Into_AnalysisMaterialAllowableB31", "1")]
        public async void Insert_Into_AnalysisMaterialAllowableB31()
        {
            //arrange
            await CopyDatabase($"{nameof(AnalysisMaterialAllowableB31)}{databaseName}", "A2template.a2db");
            Assert.True(connection.State == ConnectionState.Open);
            string id = Guid.NewGuid().ToString();            
            string code = "B31.3";
            string edition = "2022";
            string material = "(104) A106 Grade A";
            double? poissonsRatio = 0.2920;
            string elementID = Guid.NewGuid().ToString();
            double? longitudinalWeldJointEfficiency = 0.5789;
            double? multiplicationFactor = 0.9201;
            string pressureVariance = "5.34";
            double? pressureVarianceSiValue = 5.34;
            double? coefficeintY = 1.2;            
            string name = "Test Analysis Material Allowable B31";
            string description = "";

            DataSet ds = new DataSet();
            DataTable dt = new DataTable($"{nameof(AnalysisMaterialAllowableB31)}");
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("Code", typeof(string));
            dt.Columns.Add("Edition", typeof(string));
            dt.Columns.Add("Material", typeof(string));
            dt.Columns.Add("PoissonsRatio", typeof(double));
            dt.Columns.Add("ElementID", typeof(string));
            dt.Columns.Add("LongitudinalWeldJointEfficiency", typeof(double));
            dt.Columns.Add("MultiplicationFactor", typeof(double));
            dt.Columns.Add("PressureVariance", typeof(string));
            dt.Columns.Add("PressureVarianceSiValue", typeof(double));
            dt.Columns.Add("CoefficientY", typeof(double));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Description", typeof(string));            
            dt.Rows.Add(id, code, edition, material, poissonsRatio, elementID, longitudinalWeldJointEfficiency, multiplicationFactor, pressureVariance, pressureVarianceSiValue, coefficeintY, name, description);
            ds.Tables.Add(dt);

            //act
            bool retVal = await new SQLiteOperations(new DatabaseOptions()).PersistData(ds, connection.FileName);
            DataTable? dataTable = (await new SQLiteOperations(new DatabaseOptions()).RetrieveData(new List<string> { $"{nameof(AnalysisMaterialAllowableB31)}" }, 
                connection.FileName)).Tables[$"{nameof(AnalysisMaterialAllowableB31)}"];

            //assert
            Assert.True(retVal);
            Assert.NotNull(dataTable);
            foreach (DataRow row in dataTable.Rows)
            {
                Assert.Equal(code, row["Code"]);
                Assert.Equal(edition, row["Edition"]);
                Assert.Equal(material, row["Material"]);
                Assert.Equal(poissonsRatio, Convert.ToDouble(row["PoissonsRatio"]));
                Assert.Equal(elementID, row["ElementID"]);
                Assert.Equal(longitudinalWeldJointEfficiency, Convert.ToDouble(row["LongitudinalWeldJointEfficiency"]));
                Assert.Equal(multiplicationFactor, Convert.ToDouble(row["MultiplicationFactor"]));
                Assert.Equal(pressureVariance, row["PressureVariance"]);
                Assert.Equal(pressureVarianceSiValue, Convert.ToDouble(row["PressureVarianceSiValue"]));
                Assert.Equal(coefficeintY, Convert.ToDouble(row["CoefficientY"]));
                Assert.Equal(name, row["Name"]);
            }
        }

        #endregion

        #region A20-179-24 TESTS
        [Fact, Trait("Insert_Into_AnalysisMaterialAllowableISO146922005", "1")]
        public async void Insert_Into_AnalysisMaterialAllowableISO146922005()
        {
            //arrange
            await CopyDatabase($"{nameof(AnalysisMaterialAllowableISO146922005)}{databaseName}", "A2template.a2db");
            Assert.True(connection.State == ConnectionState.Open);
            string id = Guid.NewGuid().ToString();
            string code = "B31.3";
            string edition = "2022";
            string material = "(104) A106 Grade A";
            double? poissonsRatio = 0.2920;
            string elementID = Guid.NewGuid().ToString();
            string longTermAxialStressRatio01 = "0.5000";
            double? longTermAxialStressRatio01SiValue = 0.5000;
            string longTermAxialStressRatio11 = "0.3301";
            double? longTermAxialStressRatio11SiValue = 0.3301;
            string longTermHoopStressRatio11 = "0.2543";
            double longTermHoopStressRatio11SiValue = 0.2543;
            string longTermAxialStressRatio21 = "0.9087";
            double? longTermAxialStressRatio21SiValue = 0.9087;
            string longTermHoopStressRatio21 = "0.7500";
            double? longTermHoopStressRatio21SiValue = 0.7500;
            string qualifiedStressJoint = "0.001";
            double? qualifiedStressJointSiValue = 0.001;
            double biAxialStressRatioJoint = 1.5;
            string qualifiedStressTee = "0.002";
            double? qualifiedStressTeeSiValue = 0.002;
            string qualifiedStressBend = "0.003";
            double? qualifiedStressBendSiValue = 0.003;
            double biAxialStressRatioBend = 1.8;
            double hoopModulusToAxialModulusElasticity = 0.8;
            bool handLay = false;
            double chemicalResistancePartialFactor = 1.2;
            double cyclicServicePartialFactor = 2.4;
            double systemDesignFactor = 3.4;
            double thermalFactor = 4.4;
            string name = "Test Analysis Material Allowable ISO14692-2005";
            string description = "";

            DataSet ds = new DataSet();
            DataTable dt = new DataTable("AnalysisMaterialAllowableISO146922005");
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("Code", typeof(string));
            dt.Columns.Add("Edition", typeof(string));
            dt.Columns.Add("Material", typeof(string));
            dt.Columns.Add("PoissonsRatio", typeof(double));
            dt.Columns.Add("ElementID", typeof(string));
            dt.Columns.Add("LongTermAxialStressRatio01", typeof(string));
            dt.Columns.Add("LongTermAxialStressRatio01SiValue", typeof(double));
            dt.Columns.Add("LongTermAxialStressRatio11", typeof(string));
            dt.Columns.Add("LongTermAxialStressRatio11SiValue", typeof(double));
            dt.Columns.Add("LongTermHoopStressRatio11", typeof(string));
            dt.Columns.Add("LongTermHoopStressRatio11SiValue", typeof(double));
            dt.Columns.Add("LongTermAxialStressRatio21", typeof(string));
            dt.Columns.Add("LongTermAxialStressRatio21SiValue", typeof(double));
            dt.Columns.Add("LongTermHoopStressRatio21", typeof(string));
            dt.Columns.Add("LongTermHoopStressRatio21SiValue", typeof(double));
            dt.Columns.Add("QualifiedStressJoint", typeof(string));
            dt.Columns.Add("QualifiedStressJointSiValue", typeof(double));
            dt.Columns.Add("BiAxialStressRatioJoint", typeof(double));
            dt.Columns.Add("QualifiedStressTee", typeof(string));
            dt.Columns.Add("QualifiedStressTeeSiValue", typeof(double));
            dt.Columns.Add("QualifiedStressBend", typeof(string));
            dt.Columns.Add("QualifiedStressBendSiValue", typeof(double));
            dt.Columns.Add("BiAxialStressRatioBend", typeof(double));
            dt.Columns.Add("HoopModulusAxialModulusOfElasticity", typeof(double));
            dt.Columns.Add("HandLay", typeof(bool));
            dt.Columns.Add("ChemicalResistancePartialFactor", typeof(double));
            dt.Columns.Add("CyclicServicePartialFactor", typeof(double));
            dt.Columns.Add("SystemDesignFactor", typeof(double));
            dt.Columns.Add("ThermalFactor", typeof(double));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Description", typeof(string));
            dt.Rows.Add(id, code, edition, material, poissonsRatio, elementID, longTermAxialStressRatio01, longTermAxialStressRatio01SiValue, longTermAxialStressRatio11, longTermAxialStressRatio11SiValue, 
                longTermHoopStressRatio11, longTermHoopStressRatio11SiValue, longTermAxialStressRatio21, longTermAxialStressRatio21SiValue, longTermHoopStressRatio21, longTermHoopStressRatio21SiValue,
                qualifiedStressJoint, qualifiedStressJointSiValue, biAxialStressRatioJoint, qualifiedStressTee, qualifiedStressTeeSiValue, qualifiedStressBend, qualifiedStressBendSiValue, 
                biAxialStressRatioBend, hoopModulusToAxialModulusElasticity, handLay, chemicalResistancePartialFactor, cyclicServicePartialFactor, systemDesignFactor, thermalFactor, name, description);
            ds.Tables.Add(dt);

            //act
            bool retVal = await new SQLiteOperations(new DatabaseOptions()).PersistData(ds, connection.FileName);
            List<string> tableNames = new List<string>();
            tableNames.Add("AnalysisMaterialAllowableISO146922005");
            DataTable? dataTable = (await new SQLiteOperations(new DatabaseOptions()).RetrieveData(tableNames, pathToDB: connection.FileName)).Tables["AnalysisMaterialAllowableISO146922005"];

            //assert
            Assert.True(retVal);
            if (dataTable != null)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    Assert.Equal(code, row["Code"]);
                    Assert.Equal(edition, row["Edition"]);
                    Assert.Equal(material, row["Material"]);
                    Assert.Equal(poissonsRatio, Convert.ToDouble(row["PoissonsRatio"]));
                    Assert.Equal(elementID, row["ElementID"]);
                    Assert.Equal(longTermAxialStressRatio01, row["LongTermAxialStressRatio01"]);
                    Assert.Equal(longTermAxialStressRatio01SiValue, Convert.ToDouble(row["LongTermAxialStressRatio01SiValue"]));
                    Assert.Equal(longTermAxialStressRatio11, row["LongTermAxialStressRatio11"]);
                    Assert.Equal(longTermAxialStressRatio11SiValue, Convert.ToDouble(row["LongTermAxialStressRatio11SiValue"]));
                    Assert.Equal(longTermHoopStressRatio11, row["LongTermHoopStressRatio11"]);
                    Assert.Equal(longTermHoopStressRatio11SiValue, Convert.ToDouble(row["LongTermHoopStressRatio11SiValue"]));
                    Assert.Equal(longTermAxialStressRatio21, row["LongTermAxialStressRatio21"]);
                    Assert.Equal(longTermAxialStressRatio21SiValue, Convert.ToDouble(row["LongTermAxialStressRatio21SiValue"]));
                    Assert.Equal(longTermHoopStressRatio21, row["LongTermHoopStressRatio21"]);
                    Assert.Equal(longTermHoopStressRatio21SiValue, Convert.ToDouble(row["LongTermHoopStressRatio21SiValue"]));
                    Assert.Equal(qualifiedStressJoint, row["QualifiedStressJoint"]);
                    Assert.Equal(qualifiedStressJointSiValue, Convert.ToDouble(row["QualifiedStressJointSiValue"]));
                    Assert.Equal(biAxialStressRatioJoint, Convert.ToDouble(row["BiAxialStressRatioJoint"]));
                    Assert.Equal(qualifiedStressTee, row["QualifiedStressTee"]);
                    Assert.Equal(qualifiedStressTeeSiValue, Convert.ToDouble(row["QualifiedStressTeeSiValue"]));
                    Assert.Equal(qualifiedStressBend, row["QualifiedStressBend"]);
                    Assert.Equal(qualifiedStressBendSiValue, Convert.ToDouble(row["QualifiedStressBendSiValue"]));
                    Assert.Equal(biAxialStressRatioBend, Convert.ToDouble(row["BiAxialStressRatioBend"]));
                    Assert.Equal(hoopModulusToAxialModulusElasticity, Convert.ToDouble(row["HoopModulusAxialModulusOfElasticity"]));
                    Assert.Equal(handLay, Convert.ToBoolean(row["HandLay"]));
                    Assert.Equal(chemicalResistancePartialFactor, Convert.ToDouble(row["ChemicalResistancePartialFactor"]));
                    Assert.Equal(cyclicServicePartialFactor, Convert.ToDouble(row["CyclicServicePartialFactor"]));
                    Assert.Equal(systemDesignFactor, Convert.ToDouble(row["SystemDesignFactor"]));
                    Assert.Equal(thermalFactor, Convert.ToDouble(row["ThermalFactor"]));
                    Assert.Equal(name, row["Name"]);
                }
            }
            else
                Assert.Fail("Data retuned null DataTable.");
        }

        [Fact, Trait("Insert_Into_AnalysisMaterialAllowableISO146922017", "1")]
        public async void Insert_Into_AnalysisMaterialAllowableISO146922017()
        {
            //arrange
            await CopyDatabase($"{nameof(AnalysisMaterialAllowableISO146922017)}{databaseName}", "A2template.a2db");
            Assert.True(connection.State == ConnectionState.Open);
            string id = Guid.NewGuid().ToString();
            string code = "B31.3";
            string edition = "2022";
            string material = "(104) A106 Grade A";
            double? poissonsRatio = 0.2920;
            string elementID = Guid.NewGuid().ToString();
            string longTermAxialStressRatio01 = "0.5000";
            double? longTermAxialStressRatio01SiValue = 0.5000;
            string longTermAxialStressPartiallyRestrainedHydraulic = "0.6453";
            double? longTermAxialStressPartiallyRestrainedHydraulicSiValue = 0.6453;
            string longTermHoopStressPartiallyRestrainedHydraulic = "0.4500";
            double? longTermHoopStressPartiallyRestrainedHydraulicSiValue = 0.4500;
            string longTermAxialStressRatio21 = "0.9087";
            double? longTermAxialStressRatio21SiValue = 0.9087;
            string longTermHoopStressRatio21 = "0.7500";
            double? longTermHoopStressRatio21SiValue = 0.7500;
            double designLifetimeFactor = 4.4;
            double chemicalResistancePartialFactor = 1.2;
            double cyclicServicePartialFactor = 2.4;
            double systemDesignFactor = 3.4;
            double hoopModulusToAxialModulusElasticity = 0.8;
            string curveRadius = "1.2";
            double? curveRadiusSiValue = 1.2;
            bool buried = true;
            string hoopBendingModulus = "0.1111";
            double? hoopBendingModulusSiValue = 0.1111;
            string shapeFactorPipeZoneEmbedment = "0.2222";
            string verticalPipeDeflection = "0.3333";
            double? verticalPipeDeflectionSiValue = 0.3333;
            string pipeRestrainedStatus = "CAESAR II Determines";
            string name = "Test Analysis Material Allowable ISO14692-2017";
            string description = "";

            DataSet ds = new DataSet();
            DataTable dt = new DataTable("AnalysisMaterialAllowableISO146922017");
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("Code", typeof(string));
            dt.Columns.Add("Edition", typeof(string));
            dt.Columns.Add("Material", typeof(string));
            dt.Columns.Add("PoissonsRatio", typeof(double));
            dt.Columns.Add("ElementID", typeof(string)); 
            dt.Columns.Add("LongTermAxialStressRatio01", typeof(string));
            dt.Columns.Add("LongTermAxialStressRatio01SiValue", typeof(double));
            dt.Columns.Add("LongTermAxialStressPartiallyRestrainedHydraulic", typeof(string));
            dt.Columns.Add("LongTermAxialStressPartiallyRestrainedHydraulicSiValue", typeof(double));
            dt.Columns.Add("LongTermHoopStressPartiallyRestrainedHydraulic", typeof(string));
            dt.Columns.Add("LongTermHoopStressPartiallyRestrainedHydraulicSiValue", typeof(double));
            dt.Columns.Add("LongTermAxialStressRatio21", typeof(string));
            dt.Columns.Add("LongTermAxialStressRatio21SiValue", typeof(double));
            dt.Columns.Add("LongTermHoopStressRatio21", typeof(string));
            dt.Columns.Add("LongTermHoopStressRatio21SiValue", typeof(double));
            dt.Columns.Add("DesignLifetimeFactor", typeof(double));
            dt.Columns.Add("ChemicalResistancePartialFactor", typeof(double));
            dt.Columns.Add("CyclicServicePartialFactor", typeof(double));
            dt.Columns.Add("SystemDesignFactor", typeof(double));
            dt.Columns.Add("HoopModulusAxialModulusOfElasticity", typeof(double));
            dt.Columns.Add("CurveRadius", typeof(string));
            dt.Columns.Add("CurveRadiusSiValue", typeof(double));
            dt.Columns.Add("Buried", typeof(bool));
            dt.Columns.Add("HoopBendingModulus", typeof(string));
            dt.Columns.Add("HoopBendingModulusSiValue", typeof(double));
            dt.Columns.Add("ShapeFactorPipeZoneEmbedment", typeof(string));
            dt.Columns.Add("VerticalPipeDeflection", typeof(string));
            dt.Columns.Add("VerticalPipeDeflectionSiValue", typeof(double));
            dt.Columns.Add("PipeRestrainedStatus", typeof(string));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Description", typeof(string));
            dt.Rows.Add(id, code, edition, material, poissonsRatio, elementID, longTermAxialStressRatio01, longTermAxialStressRatio01SiValue, 
                longTermAxialStressPartiallyRestrainedHydraulic, longTermAxialStressPartiallyRestrainedHydraulicSiValue, longTermHoopStressPartiallyRestrainedHydraulic, longTermHoopStressPartiallyRestrainedHydraulicSiValue,
                longTermAxialStressRatio21, longTermAxialStressRatio21SiValue, longTermHoopStressRatio21, longTermHoopStressRatio21SiValue, designLifetimeFactor, chemicalResistancePartialFactor, cyclicServicePartialFactor,
                systemDesignFactor, hoopModulusToAxialModulusElasticity, curveRadius, curveRadiusSiValue, buried, hoopBendingModulus, hoopBendingModulusSiValue, shapeFactorPipeZoneEmbedment, verticalPipeDeflection,
                verticalPipeDeflectionSiValue, pipeRestrainedStatus, name, description);
            ds.Tables.Add(dt);

            //act
            bool retVal = await new SQLiteOperations(new DatabaseOptions()).PersistData(ds, connection.FileName);
            DataTable? dataTable = (await new SQLiteOperations(new DatabaseOptions()).RetrieveData(new List<string> { "AnalysisMaterialAllowableISO146922017" }, connection.FileName)).Tables["AnalysisMaterialAllowableISO146922017"];

            //assert
            Assert.True(retVal);
            if (dataTable != null)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    Assert.Equal(code, row["Code"]);
                    Assert.Equal(edition, row["Edition"]);
                    Assert.Equal(material, row["Material"]);
                    Assert.Equal(poissonsRatio, Convert.ToDouble(row["PoissonsRatio"]));
                    Assert.Equal(elementID, row["ElementID"]);
                    Assert.Equal(longTermAxialStressRatio01, row["LongTermAxialStressRatio01"]);
                    Assert.Equal(longTermAxialStressRatio01SiValue, Convert.ToDouble(row["LongTermAxialStressRatio01SiValue"]));
                    Assert.Equal(longTermAxialStressPartiallyRestrainedHydraulic, row["LongTermAxialStressPartiallyRestrainedHydraulic"]);
                    Assert.Equal(longTermAxialStressPartiallyRestrainedHydraulicSiValue, Convert.ToDouble(row["LongTermAxialStressPartiallyRestrainedHydraulicSiValue"]));
                    Assert.Equal(longTermHoopStressPartiallyRestrainedHydraulic, row["LongTermHoopStressPartiallyRestrainedHydraulic"]);
                    Assert.Equal(longTermHoopStressPartiallyRestrainedHydraulicSiValue, Convert.ToDouble(row["LongTermHoopStressPartiallyRestrainedHydraulicSiValue"]));
                    Assert.Equal(longTermAxialStressRatio21, row["LongTermAxialStressRatio21"]);
                    Assert.Equal(longTermAxialStressRatio21SiValue, Convert.ToDouble(row["LongTermAxialStressRatio21SiValue"]));
                    Assert.Equal(longTermHoopStressRatio21, row["LongTermHoopStressRatio21"]);
                    Assert.Equal(longTermHoopStressRatio21SiValue, Convert.ToDouble(row["LongTermHoopStressRatio21SiValue"]));
                    Assert.Equal(designLifetimeFactor, Convert.ToDouble(row["DesignLifetimeFactor"]));
                    Assert.Equal(chemicalResistancePartialFactor, Convert.ToDouble(row["ChemicalResistancePartialFactor"]));
                    Assert.Equal(cyclicServicePartialFactor, Convert.ToDouble(row["CyclicServicePartialFactor"]));
                    Assert.Equal(systemDesignFactor, Convert.ToDouble(row["SystemDesignFactor"]));
                    Assert.Equal(hoopModulusToAxialModulusElasticity, Convert.ToDouble(row["HoopModulusAxialModulusOfElasticity"]));
                    Assert.Equal(curveRadius, row["CurveRadius"]);
                    Assert.Equal(curveRadiusSiValue, Convert.ToDouble(row["CurveRadiusSiValue"]));
                    Assert.Equal(buried, Convert.ToBoolean(row["Buried"]));
                    Assert.Equal(hoopBendingModulus, row["HoopBendingModulus"]);
                    Assert.Equal(hoopBendingModulusSiValue, Convert.ToDouble(row["HoopBendingModulusSiValue"]));
                    Assert.Equal(shapeFactorPipeZoneEmbedment, row["ShapeFactorPipeZoneEmbedment"]);
                    Assert.Equal(verticalPipeDeflection, row["VerticalPipeDeflection"]);
                    Assert.Equal(verticalPipeDeflectionSiValue, Convert.ToDouble(row["VerticalPipeDeflectionSiValue"]));
                    Assert.Equal(pipeRestrainedStatus, row["PipeRestrainedStatus"]);
                    Assert.Equal(name, row["Name"]);
                }
            }
        }

        #endregion

        #region A20-179-25 TESTS
        [Fact, Trait("Insert_Into_AnalysisMaterialAllowableDNV1996", "1")]
        public async void Insert_Into_AnalysisMaterialAllowableDNV1996()
        {
            //arrange
            await CopyDatabase($"{nameof(AnalysisMaterialAllowableDNV1996)}{databaseName}", "A2template.a2db");
            Assert.True(connection.State == ConnectionState.Open);
            string id = Guid.NewGuid().ToString();
            string code = "DNV";
            string edition = "1996";
            string material = "(104) A106 Grade A";
            double? poissonsRatio = 0.2920;
            string elementID = Guid.NewGuid().ToString();
            double pressureYieldingUsageFactor = 1.5;
            double pressureBurstingUsageFactor = 1.8;
            double wquivalentStressCheckUsageFactor = 0.8;            
            string name = "Test Analysis Material Allowable DNV 1996";
            string description = "";

            DataSet ds = new DataSet();
            DataTable dt = new DataTable($"{nameof(AnalysisMaterialAllowableDNV1996)}");
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("Code", typeof(string));
            dt.Columns.Add("Edition", typeof(string));
            dt.Columns.Add("Material", typeof(string));
            dt.Columns.Add("PoissonsRatio", typeof(double));
            dt.Columns.Add("ElementID", typeof(string));
            dt.Columns.Add("PressureYieldingUsageFactor", typeof(double));
            dt.Columns.Add("PressureBurstingUsageFactor", typeof(double));
            dt.Columns.Add("EquivalentStressCheckUsageFactor", typeof(double));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Description", typeof(string));
            dt.Rows.Add(id, code, edition, material, poissonsRatio, elementID, pressureYieldingUsageFactor, pressureBurstingUsageFactor, wquivalentStressCheckUsageFactor, name, description);
            ds.Tables.Add(dt);

            //act
            bool retVal = await new SQLiteOperations(new DatabaseOptions()).PersistData(ds, connection.FileName);
            DataTable? dataTable = (await new SQLiteOperations(new DatabaseOptions()).RetrieveData(new List<string>() { $"{nameof(AnalysisMaterialAllowableDNV1996)}" },
                pathToDB: connection.FileName)).Tables[$"{nameof(AnalysisMaterialAllowableDNV1996)}"];

            //assert
            Assert.True(retVal);
            if (dataTable != null)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    Assert.Equal(code, row["Code"]);
                    Assert.Equal(edition, row["Edition"]);
                    Assert.Equal(material, row["Material"]);
                    Assert.Equal(poissonsRatio, Convert.ToDouble(row["PoissonsRatio"]));
                    Assert.Equal(elementID, row["ElementID"]);
                    Assert.Equal(pressureYieldingUsageFactor, Convert.ToDouble(row["PressureYieldingUsageFactor"]));
                    Assert.Equal(pressureBurstingUsageFactor, Convert.ToDouble(row["PressureBurstingUsageFactor"]));
                    Assert.Equal(wquivalentStressCheckUsageFactor, Convert.ToDouble(row["EquivalentStressCheckUsageFactor"]));
                    Assert.Equal(name, row["Name"]);                    
                }
            }
            else
                Assert.Fail("Data retuned null DataTable.");           
        }

        [Fact, Trait("Insert_Into_AnalysisMaterialAllowableDNV2017", "1")]
        public async void Insert_Into_AnalysisMaterialAllowableDNV2017()
        {
            //arrange
            await CopyDatabase($"{nameof(AnalysisMaterialAllowableDNV2017)}{databaseName}", "A2template.a2db");
            Assert.True(connection.State == ConnectionState.Open);
            string id = Guid.NewGuid().ToString();
            string code = "DNV";
            string edition = "2017";
            string material = "(104) A106 Grade A";
            double? poissonsRatio = 0.2920;
            string elementID = Guid.NewGuid().ToString();
            bool supplementaryRequirement = false;
            bool materialLuderPlateau = true;
            double? strainHardeningFactor = 0.88;
            double? fabricationStringResisteanceFactor = 0.74;
            string burstFailureOperation = "Low";
            string burstFailureTesing = "Medium";
            string collapseFailure = "High";
            string propagationBuckling = "Low";
            double? loadEffectFactor = 0.63;
            double? girthWeldStrainResisteanceFactor = 0.34;
            string reactionForce = "100";
            double reationForceSiValue = 100;
            double pressureYieldingUsageFactor = 1.5;
            double pressureBurstingUsageFactor = 1.8;
            double wquivalentStressCheckUsageFactor = 0.8;
            string name = "Test Analysis Material Allowable DNV 2017";
            string description = "";

            DataSet ds = new DataSet();
            DataTable dt = new DataTable($"{nameof(AnalysisMaterialAllowableDNV2017)}");
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("Code", typeof(string));
            dt.Columns.Add("Edition", typeof(string));
            dt.Columns.Add("Material", typeof(string));
            dt.Columns.Add("PoissonsRatio", typeof(double));
            dt.Columns.Add("ElementID", typeof(string));
            dt.Columns.Add("SupplementaryRequirement", typeof(bool));
            dt.Columns.Add("MaterialLuderPlateau", typeof(bool));
            dt.Columns.Add("StrainHardeningFactor", typeof(double));
            dt.Columns.Add("FabricationStringResisteanceFactor", typeof(double));
            dt.Columns.Add("BurstFailureOperation", typeof(string));
            dt.Columns.Add("BurstFailureTesing", typeof(string));
            dt.Columns.Add("CollapseFailure", typeof(string));
            dt.Columns.Add("PropagationBuckling", typeof(string));
            dt.Columns.Add("LoadEffectFactor", typeof(double));
            dt.Columns.Add("GirthWeldStrainResisteanceFactor", typeof(double));
            dt.Columns.Add("ReactionForce", typeof(string));
            dt.Columns.Add("ReactionForceSiValue", typeof(double));
            dt.Columns.Add("PressureYieldingUsageFactor", typeof(double));
            dt.Columns.Add("PressureBurstingUsageFactor", typeof(double));
            dt.Columns.Add("EquivalentStressCheckUsageFactor", typeof(double));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Description", typeof(string));
            dt.Rows.Add(id, code, edition, material, poissonsRatio, elementID, supplementaryRequirement, materialLuderPlateau, strainHardeningFactor, fabricationStringResisteanceFactor, burstFailureOperation, burstFailureTesing,
                collapseFailure, propagationBuckling, loadEffectFactor, girthWeldStrainResisteanceFactor, reactionForce, reationForceSiValue, 
                pressureYieldingUsageFactor, pressureBurstingUsageFactor, wquivalentStressCheckUsageFactor, name, description);
            ds.Tables.Add(dt);

            //act
            bool retVal = await new SQLiteOperations(new DatabaseOptions()).PersistData(ds, connection.FileName);
            DataTable? dataTable = (await new SQLiteOperations(new DatabaseOptions()).RetrieveData(new List<string>() { $"{nameof(AnalysisMaterialAllowableDNV2017)}" }, 
                pathToDB: connection.FileName)).Tables[$"{nameof(AnalysisMaterialAllowableDNV2017)}"];

            //assert
            Assert.True(retVal);
            if (dataTable != null)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    Assert.Equal(code, row["Code"]);
                    Assert.Equal(edition, row["Edition"]);
                    Assert.Equal(material, row["Material"]);
                    Assert.Equal(poissonsRatio, Convert.ToDouble(row["PoissonsRatio"]));
                    Assert.Equal(elementID, row["ElementID"]);
                    Assert.Equal(supplementaryRequirement, Convert.ToBoolean(row["SupplementaryRequirement"]));
                    Assert.Equal(materialLuderPlateau, Convert.ToBoolean(row["MaterialLuderPlateau"]));
                    Assert.Equal(strainHardeningFactor, Convert.ToDouble(row["StrainHardeningFactor"]));
                    Assert.Equal(fabricationStringResisteanceFactor, Convert.ToDouble(row["FabricationStringResisteanceFactor"]));
                    Assert.Equal(burstFailureOperation, row["BurstFailureOperation"]);
                    Assert.Equal(burstFailureTesing, row["BurstFailureTesing"]);
                    Assert.Equal(collapseFailure, row["CollapseFailure"]);
                    Assert.Equal(propagationBuckling, row["PropagationBuckling"]);
                    Assert.Equal(loadEffectFactor, Convert.ToDouble(row["LoadEffectFactor"]));
                    Assert.Equal(girthWeldStrainResisteanceFactor, Convert.ToDouble(row["GirthWeldStrainResisteanceFactor"]));
                    Assert.Equal(reactionForce, row["ReactionForce"]);
                    Assert.Equal(reationForceSiValue, Convert.ToDouble(row["ReactionForceSiValue"]));
                    Assert.Equal(pressureYieldingUsageFactor, Convert.ToDouble(row["PressureYieldingUsageFactor"]));
                    Assert.Equal(pressureBurstingUsageFactor, Convert.ToDouble(row["PressureBurstingUsageFactor"]));
                    Assert.Equal(wquivalentStressCheckUsageFactor, Convert.ToDouble(row["EquivalentStressCheckUsageFactor"]));
                    Assert.Equal(name, row["Name"]);
                }
            }
            else
                Assert.Fail("Data retuned null DataTable.");
        }

        #endregion

        #region A20-179-26 TESTS
        [Fact, Trait("Insert_Into_AnalysisMaterialAllowableASMENC2009", "1")]
        public async void Insert_Into_AnalysisMaterialAllowableASMENC2009()
        {
            //arrange
            await CopyDatabase($"{nameof(AnalysisMaterialAllowableASME)}{databaseName}", "A2template.a2db");
            Assert.True(connection.State == ConnectionState.Open);
            string id = Guid.NewGuid().ToString();            
            string code = "ASME NC";
            string edition = "2009";
            string material = "(104) A106 Grade A";
            double? poissonsRatio = 0.2920;
            string elementID = Guid.NewGuid().ToString();
            string pressureVariance = "5.34";
            double pressureVarianceSiValue = 5.34;
            double? yieldStrength = 1.2;            
            string name = "Test Analysis Material Allowable ASME NC 2009";
            string description = "";

            DataSet ds = new DataSet();
            DataTable dt = new DataTable($"{nameof(AnalysisMaterialAllowableASME)}");
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("Code", typeof(string));
            dt.Columns.Add("Edition", typeof(string));
            dt.Columns.Add("Material", typeof(string));
            dt.Columns.Add("PoissonsRatio", typeof(double));
            dt.Columns.Add("ElementID", typeof(string));
            dt.Columns.Add("PressureVariance", typeof(string));
            dt.Columns.Add("PressureVarianceSiValue", typeof(double));
            dt.Columns.Add("YieldStrength", typeof(double));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Description", typeof(string));
            dt.Rows.Add(id, code, edition, material, poissonsRatio, elementID, pressureVariance, pressureVarianceSiValue, yieldStrength, name, description);
            ds.Tables.Add(dt);

            //act
            bool retVal = await new SQLiteOperations(new DatabaseOptions()).PersistData(ds, connection.FileName);
            DataTable? dataTable = (await new SQLiteOperations(new DatabaseOptions()).RetrieveData(new List<string>() { $"{nameof(AnalysisMaterialAllowableASME)}" },
                pathToDB: connection.FileName)).Tables[$"{nameof(AnalysisMaterialAllowableASME)}"];

            //assert
            Assert.True(retVal);
            if (dataTable != null)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    Assert.Equal(code, row["Code"]);
                    Assert.Equal(edition, row["Edition"]);
                    Assert.Equal(material, row["Material"]);
                    Assert.Equal(poissonsRatio, Convert.ToDouble(row["PoissonsRatio"]));
                    Assert.Equal(elementID, row["ElementID"]);
                    Assert.Equal(pressureVariance, row["PressureVariance"]);
                    Assert.Equal(pressureVarianceSiValue, Convert.ToDouble(row["PressureVarianceSiValue"]));
                    Assert.Equal(yieldStrength, Convert.ToDouble(row["YieldStrength"]));
                    Assert.Equal(name, row["Name"]);
                }
            }
            else
                Assert.Fail("Data retuned null DataTable.");
        }

        [Fact, Trait("Insert_Into_AnalysisMaterialAllowableASMEND2009", "1")]
        public async void Insert_Into_AnalysisMaterialAllowableASMEND2009()
        {
            //arrange
            await CopyDatabase($"{nameof(AnalysisMaterialAllowableASME)}{databaseName}", "A2template.a2db");
            Assert.True(connection.State == ConnectionState.Open);
            string id = Guid.NewGuid().ToString();
            string code = "ASME ND";
            string edition = "2009";
            string material = "(104) A106 Grade A";
            double? poissonsRatio = 0.2920;
            string elementID = Guid.NewGuid().ToString();
            string pressureVariance = "5.34";
            double pressureVarianceSiValue = 5.34;
            double? yieldStrength = 1.2;
            string name = "Test Analysis Material Allowable ASME ND 2009";
            string description = "";

            DataSet ds = new DataSet();
            DataTable dt = new DataTable($"{nameof(AnalysisMaterialAllowableASME)}");
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("Code", typeof(string));
            dt.Columns.Add("Edition", typeof(string));
            dt.Columns.Add("Material", typeof(string));
            dt.Columns.Add("PoissonsRatio", typeof(double));
            dt.Columns.Add("ElementID", typeof(string));
            dt.Columns.Add("PressureVariance", typeof(string));
            dt.Columns.Add("PressureVarianceSiValue", typeof(double));
            dt.Columns.Add("YieldStrength", typeof(double));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Description", typeof(string));
            dt.Rows.Add(id, code, edition, material, poissonsRatio, elementID, pressureVariance, pressureVarianceSiValue, yieldStrength, name, description);
            ds.Tables.Add(dt);

            //act
            bool retVal = await new SQLiteOperations(new DatabaseOptions()).PersistData(ds, connection.FileName);
            DataTable? dataTable = (await new SQLiteOperations(new DatabaseOptions()).RetrieveData(new List<string>() { $"{nameof(AnalysisMaterialAllowableASME)}" },
                pathToDB: connection.FileName)).Tables[$"{nameof(AnalysisMaterialAllowableASME)}"];

            //assert
            Assert.True(retVal);
            if (dataTable != null)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    Assert.Equal(code, row["Code"]);
                    Assert.Equal(edition, row["Edition"]);
                    Assert.Equal(material, row["Material"]);
                    Assert.Equal(poissonsRatio, Convert.ToDouble(row["PoissonsRatio"]));
                    Assert.Equal(elementID, row["ElementID"]);
                    Assert.Equal(pressureVariance, row["PressureVariance"]);
                    Assert.Equal(pressureVarianceSiValue, Convert.ToDouble(row["PressureVarianceSiValue"]));
                    Assert.Equal(yieldStrength, Convert.ToDouble(row["YieldStrength"]));
                    Assert.Equal(name, row["Name"]);
                }
            }
            else
                Assert.Fail("Data retuned null DataTable.");
        }

        [Fact, Trait("Insert_Into_AnalysisMaterialAllowableNavy505", "1")]
        public async void Insert_Into_AnalysisMaterialAllowableNavy505()
        {
            //arrange
            await CopyDatabase($"{nameof(AnalysisMaterialAllowableNavy505)}{databaseName}", "A2template.a2db");
            Assert.True(connection.State == ConnectionState.Open);
            string id = Guid.NewGuid().ToString();
            string code = "Navy 505";
            string edition = "1984";
            string material = "(104) A106 Grade A";
            double? poissonsRatio = 0.2920;
            string elementID = Guid.NewGuid().ToString();
            double? factorForMinimumWallThickness = 1.2;
            string name = "Test Analysis Material Allowable Navy 505-1984";
            string description = "";

            DataSet ds = new DataSet();
            DataTable dt = new DataTable($"{nameof(AnalysisMaterialAllowableNavy505)}");
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("Code", typeof(string));
            dt.Columns.Add("Edition", typeof(string));
            dt.Columns.Add("Material", typeof(string));
            dt.Columns.Add("PoissonsRatio", typeof(double));
            dt.Columns.Add("ElementID", typeof(string));
            dt.Columns.Add("FactorForMinimumWallThickness", typeof(double));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Description", typeof(string));
            dt.Rows.Add(id, code, edition, material, poissonsRatio, elementID, factorForMinimumWallThickness, name, description);
            ds.Tables.Add(dt);

            //act
            bool retVal = await new SQLiteOperations(new DatabaseOptions()).PersistData(ds, connection.FileName);
            DataTable? dataTable = (await new SQLiteOperations(new DatabaseOptions()).RetrieveData(new List<string>() { $"{nameof(AnalysisMaterialAllowableNavy505)}" },
                pathToDB: connection.FileName)).Tables[$"{nameof(AnalysisMaterialAllowableNavy505)}"];

            //assert
            Assert.True(retVal);
            if (dataTable != null)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    Assert.Equal(code, row["Code"]);
                    Assert.Equal(edition, row["Edition"]);
                    Assert.Equal(material, row["Material"]);
                    Assert.Equal(poissonsRatio, Convert.ToDouble(row["PoissonsRatio"]));
                    Assert.Equal(elementID, row["ElementID"]);
                    Assert.Equal(factorForMinimumWallThickness, Convert.ToDouble(row["FactorForMinimumWallThickness"]));
                    Assert.Equal(name, row["Name"]);
                }
            }
            else
                Assert.Fail("Data retuned null DataTable.");
        }

        [Fact, Trait("Insert_Into_AnalysisMaterialAllowableCANZ6622019", "1")]
        public async void Insert_Into_AnalysisMaterialAllowableCANZ6622019()
        {
            //arrange
            await CopyDatabase($"{nameof(AnalysisMaterialAllowableCANZ662)}{databaseName}", "A2template.a2db");
            Assert.True(connection.State == ConnectionState.Open);
            string id = Guid.NewGuid().ToString();
            string code = "CANZ662";
            string edition = "2019";
            string material = "(104) A106 Grade A";
            double? poissonsRatio = 0.2920;
            string elementID = Guid.NewGuid().ToString();
            double? locationFactor = 1.2;
            double? temperatureDeratingFactor = 3.4;
            double? conditionADesignFactor = (double?)null;
            double? conditionBDesignFactor = (double?)null;
            double? longitudinalWeldJointEfficiency = 5.6;
            double? restrainedFactor = 7.8;
            double? minimumYieldStrength = 0.1234;
            string name = "Test Analysis Material Allowable CANZ662 2019";
            string description = "";

            DataSet ds = new DataSet();
            DataTable dt = new DataTable($"{nameof(AnalysisMaterialAllowableCANZ662)}");
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("Code", typeof(string));
            dt.Columns.Add("Edition", typeof(string));
            dt.Columns.Add("Material", typeof(string));
            dt.Columns.Add("PoissonsRatio", typeof(double));
            dt.Columns.Add("ElementID", typeof(string));
            dt.Columns.Add("LocationFactor", typeof(double));
            dt.Columns.Add("TemperatureDeratingFactor", typeof(double));
            dt.Columns.Add("ConditionADesignFactor", typeof(double));
            dt.Columns.Add("ConditionBDesignFactor", typeof(double));
            dt.Columns.Add("LongitudinalWeldJointEfficiency", typeof(double));
            dt.Columns.Add("RestrainedFactor", typeof(double));
            dt.Columns.Add("MinimumYieldStrength", typeof(double));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Description", typeof(string));
            dt.Rows.Add(id, code, edition, material, poissonsRatio, elementID, locationFactor, temperatureDeratingFactor, conditionADesignFactor, conditionBDesignFactor, longitudinalWeldJointEfficiency, 
                restrainedFactor, minimumYieldStrength, name, description);
            ds.Tables.Add(dt);

            //act
            bool retVal = await new SQLiteOperations(new DatabaseOptions()).PersistData(ds, connection.FileName);
            DataTable? dataTable = (await new SQLiteOperations(new DatabaseOptions()).RetrieveData(new List<string>() { $"{nameof(AnalysisMaterialAllowableCANZ662)}" },
                pathToDB: connection.FileName)).Tables[$"{nameof(AnalysisMaterialAllowableCANZ662)}"];

            //assert
            Assert.True(retVal);
            if (dataTable != null)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    Assert.Equal(code, row["Code"]);
                    Assert.Equal(edition, row["Edition"]);
                    Assert.Equal(material, row["Material"]);
                    Assert.Equal(poissonsRatio, Convert.ToDouble(row["PoissonsRatio"]));
                    Assert.Equal(elementID, row["ElementID"]);
                    Assert.Equal(locationFactor, Convert.ToDouble(row["LocationFactor"]));
                    Assert.Equal(temperatureDeratingFactor, Convert.ToDouble(row["TemperatureDeratingFactor"]));
                    Assert.Equal(longitudinalWeldJointEfficiency, Convert.ToDouble(row["LongitudinalWeldJointEfficiency"]));
                    Assert.Equal(restrainedFactor, Convert.ToDouble(row["RestrainedFactor"]));
                    Assert.Equal(minimumYieldStrength, Convert.ToDouble(row["MinimumYieldStrength"]));
                    Assert.Equal(name, row["Name"]);
                }
            }
            else
                Assert.Fail("Data retuned null DataTable.");
        }

        [Fact, Trait("Insert_Into_AnalysisMaterialAllowableCANZ662Chapter112019", "1")]
        public async void Insert_Into_AnalysisMaterialAllowableCANZ662Chapter112019()
        {
            //arrange
            await CopyDatabase($"{nameof(AnalysisMaterialAllowableCANZ662)}Chapeter11{databaseName}", "A2template.a2db");
            Assert.True(connection.State == ConnectionState.Open);
            string id = Guid.NewGuid().ToString();
            string code = "CANZ662 Chapter 11";
            string edition = "2019";
            string material = "(104) A106 Grade A";
            double? poissonsRatio = 0.2920;
            string elementID = Guid.NewGuid().ToString();
            double? locationFactor = (double?)null;
            double? temperatureDeratingFactor = 1.2;
            double? conditionADesignFactor = 2.3;
            double? conditionBDesignFactor = 4.5;
            double? longitudinalWeldJointEfficiency = 5.6;
            double? restrainedFactor = 6.7;
            double? minimumYieldStrength = 7.8;
            string name = "Test Analysis Material Allowable CANZ662 Chapter 11 2019";
            string description = "";

            DataSet ds = new DataSet();
            DataTable dt = new DataTable($"{nameof(AnalysisMaterialAllowableCANZ662)}");
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("Code", typeof(string));
            dt.Columns.Add("Edition", typeof(string));
            dt.Columns.Add("Material", typeof(string));
            dt.Columns.Add("PoissonsRatio", typeof(double));
            dt.Columns.Add("ElementID", typeof(string));
            dt.Columns.Add("LocationFactor", typeof(double));
            dt.Columns.Add("TemperatureDeratingFactor", typeof(double));
            dt.Columns.Add("ConditionADesignFactor", typeof(double));
            dt.Columns.Add("ConditionBDesignFactor", typeof(double));
            dt.Columns.Add("LongitudinalWeldJointEfficiency", typeof(double));
            dt.Columns.Add("RestrainedFactor", typeof(double));
            dt.Columns.Add("MinimumYieldStrength", typeof(double));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Description", typeof(string));
            dt.Rows.Add(id, code, edition, material, poissonsRatio, elementID, locationFactor, temperatureDeratingFactor, conditionADesignFactor, conditionBDesignFactor, longitudinalWeldJointEfficiency, 
                restrainedFactor, minimumYieldStrength, name, description);
            ds.Tables.Add(dt);

            //act
            bool retVal = await new SQLiteOperations(new DatabaseOptions()).PersistData(ds, connection.FileName);
            DataTable? dataTable = (await new SQLiteOperations(new DatabaseOptions()).RetrieveData(new List<string>() { $"{nameof(AnalysisMaterialAllowableCANZ662)}" },
                pathToDB: connection.FileName)).Tables[$"{nameof(AnalysisMaterialAllowableCANZ662)}"];

            //assert
            Assert.True(retVal);
            if (dataTable != null)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    Assert.Equal(code, row["Code"]);
                    Assert.Equal(edition, row["Edition"]);
                    Assert.Equal(material, row["Material"]);
                    Assert.Equal(poissonsRatio, Convert.ToDouble(row["PoissonsRatio"]));
                    Assert.Equal(elementID, row["ElementID"]);                    
                    Assert.Equal(temperatureDeratingFactor, Convert.ToDouble(row["TemperatureDeratingFactor"]));
                    Assert.Equal(conditionADesignFactor, Convert.ToDouble(row["ConditionADesignFactor"]));
                    Assert.Equal(conditionBDesignFactor, Convert.ToDouble(row["ConditionBDesignFactor"]));
                    Assert.Equal(longitudinalWeldJointEfficiency, Convert.ToDouble(row["LongitudinalWeldJointEfficiency"]));
                    Assert.Equal(restrainedFactor, Convert.ToDouble(row["RestrainedFactor"]));
                    Assert.Equal(minimumYieldStrength, Convert.ToDouble(row["MinimumYieldStrength"]));
                    Assert.Equal(name, row["Name"]);
                }
            }
            else
                Assert.Fail("Data retuned null DataTable.");
        }

        [Fact, Trait("Insert_Into_AnalysisMaterialAllowableBS806", "1")]
        public async void Insert_Into_AnalysisMaterialAllowableBS806()
        {
            //arrange
            await CopyDatabase($"{nameof(AnalysisMaterialAllowableBS806)}{databaseName}", "A2template.a2db");
            Assert.True(connection.State == ConnectionState.Open);
            string id = Guid.NewGuid().ToString();
            string code = "BS 806";
            string edition = "1993";
            string material = "(104) A106 Grade A";
            double? poissonsRatio = 0.2920;
            string elementID = Guid.NewGuid().ToString();
            double? factorForMinimumWallThickness = 1.2;
            string sustainedStressLimit = "0.5647";
            double? sustainedStressLimitSiValue = 0.5647;
            string name = "Test Analysis Material Allowable BS 806-1993";
            string description = "";

            DataSet ds = new DataSet();
            DataTable dt = new DataTable($"{nameof(AnalysisMaterialAllowableBS806)}");
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("Code", typeof(string));
            dt.Columns.Add("Edition", typeof(string));
            dt.Columns.Add("Material", typeof(string));
            dt.Columns.Add("PoissonsRatio", typeof(double));
            dt.Columns.Add("ElementID", typeof(string));
            dt.Columns.Add("FactorForMinimumWallThickness", typeof(double));
            dt.Columns.Add("SustainedStressLimit", typeof(string));
            dt.Columns.Add("SustainedStressLimitSiValue", typeof(double));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Description", typeof(string));
            dt.Rows.Add(id, code, edition, material, poissonsRatio, elementID, factorForMinimumWallThickness, sustainedStressLimit, sustainedStressLimitSiValue, name, description);
            ds.Tables.Add(dt);

            //act
            bool retVal = await new SQLiteOperations(new DatabaseOptions()).PersistData(ds, connection.FileName);
            DataTable? dataTable = (await new SQLiteOperations(new DatabaseOptions()).RetrieveData(new List<string>() { $"{nameof(AnalysisMaterialAllowableBS806)}" },
                pathToDB: connection.FileName)).Tables[$"{nameof(AnalysisMaterialAllowableBS806)}"];

            //assert
            Assert.True(retVal);
            if (dataTable != null)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    Assert.Equal(code, row["Code"]);
                    Assert.Equal(edition, row["Edition"]);
                    Assert.Equal(material, row["Material"]);
                    Assert.Equal(poissonsRatio, Convert.ToDouble(row["PoissonsRatio"]));
                    Assert.Equal(elementID, row["ElementID"]);
                    Assert.Equal(factorForMinimumWallThickness, Convert.ToDouble(row["FactorForMinimumWallThickness"]));                    
                    Assert.Equal(sustainedStressLimit, row["SustainedStressLimit"]);
                    Assert.Equal(sustainedStressLimitSiValue, Convert.ToDouble(row["SustainedStressLimitSiValue"]));
                    Assert.Equal(name, row["Name"]);
                }
            }
            else
                Assert.Fail("Data retuned null DataTable.");
        }

        [Fact, Trait("Insert_Into_AnalysisMaterialAllowableBS71591989", "1")]
        public async void Insert_Into_AnalysisMaterialAllowableBS71591989()
        {
            //arrange
            await CopyDatabase($"{nameof(AnalysisMaterialAllowableBS7159)}{databaseName}", "A2template.a2db");
            Assert.True(connection.State == ConnectionState.Open);
            string id = Guid.NewGuid().ToString();
            string code = "BS 7159";
            string edition = "1989";
            string material = "(104) A106 Grade A";
            double? poissonsRatio = 0.2920;
            string elementID = Guid.NewGuid().ToString();
            double? ratioHoopModulusAxialElasticityModulus = 1.2;
            double? meanTemperatureChangeMultiplier = 0.5647;
            string name = "Test Analysis Material Allowable BS 7159-1989";
            string description = "";

            DataSet ds = new DataSet();
            DataTable dt = new DataTable($"{nameof(AnalysisMaterialAllowableBS7159)}");
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("Code", typeof(string));
            dt.Columns.Add("Edition", typeof(string));
            dt.Columns.Add("Material", typeof(string));
            dt.Columns.Add("PoissonsRatio", typeof(double));
            dt.Columns.Add("ElementID", typeof(string));
            dt.Columns.Add("RatioHoopModulusAxialElasticityModulus", typeof(double));
            dt.Columns.Add("MeanTemperatureChangeMultiplier", typeof(double));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Description", typeof(string));
            dt.Rows.Add(id, code, edition, material, poissonsRatio, elementID, ratioHoopModulusAxialElasticityModulus, meanTemperatureChangeMultiplier, name, description);
            ds.Tables.Add(dt);

            //act
            bool retVal = await new SQLiteOperations(new DatabaseOptions()).PersistData(ds, connection.FileName);
            DataTable? dataTable = (await new SQLiteOperations(new DatabaseOptions()).RetrieveData(new List<string>() { $"{nameof(AnalysisMaterialAllowableBS7159)}" },
                pathToDB: connection.FileName)).Tables[$"{nameof(AnalysisMaterialAllowableBS7159)}"];

            //assert
            Assert.True(retVal);
            if (dataTable != null)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    Assert.Equal(code, row["Code"]);
                    Assert.Equal(edition, row["Edition"]);
                    Assert.Equal(material, row["Material"]);
                    Assert.Equal(poissonsRatio, Convert.ToDouble(row["PoissonsRatio"]));
                    Assert.Equal(elementID, row["ElementID"]);
                    Assert.Equal(ratioHoopModulusAxialElasticityModulus, Convert.ToDouble(row["RatioHoopModulusAxialElasticityModulus"]));
                    Assert.Equal(meanTemperatureChangeMultiplier, Convert.ToDouble(row["MeanTemperatureChangeMultiplier"]));
                    Assert.Equal(name, row["Name"]);
                }
            }
            else
                Assert.Fail("Data retuned null DataTable.");
        }
        #endregion

        #region A20-179-27 TESTS
        [Fact, Trait("Insert_Into_AnalysisMaterialAllowableCODETI", "1")]
        public async void Insert_Into_AnalysisMaterialAllowableCODETI()
        {
            //arrange
            await CopyDatabase($"{nameof(AnalysisMaterialAllowableCODETI)}{databaseName}", "A2template.a2db");
            Assert.True(connection.State == ConnectionState.Open);
            string id = Guid.NewGuid().ToString();
            string code = "ASME NC";
            string edition = "2009";
            string material = "(104) A106 Grade A";
            double? poissonsRatio = 0.2920;
            string elementID = Guid.NewGuid().ToString();
            double? longitudinalWeldJointEfficiency = 5.34;
            string hydroTestAllowablePressure = "0.543";
            double? hydroTestAllowablePressureSiValue = 0.543;
            string name = "Test Analysis Material Allowable ASME NC 2009";
            string description = "";

            DataSet ds = new DataSet();
            DataTable dt = new DataTable($"{nameof(AnalysisMaterialAllowableCODETI)}");
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("Code", typeof(string));
            dt.Columns.Add("Edition", typeof(string));
            dt.Columns.Add("Material", typeof(string));
            dt.Columns.Add("PoissonsRatio", typeof(double));
            dt.Columns.Add("ElementID", typeof(string));
            dt.Columns.Add("LongitudinalWeldJointEfficiency", typeof(double));
            dt.Columns.Add("HydroTestAllowablePressure", typeof(string));
            dt.Columns.Add("HydroTestAllowablePressureSiValue", typeof(double));            
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Description", typeof(string));
            dt.Rows.Add(id, code, edition, material, poissonsRatio, elementID, longitudinalWeldJointEfficiency, hydroTestAllowablePressure, hydroTestAllowablePressureSiValue, name, description);
            ds.Tables.Add(dt);

            //act
            bool retVal = await new SQLiteOperations(new DatabaseOptions()).PersistData(ds, connection.FileName);
            DataTable? dataTable = (await new SQLiteOperations(new DatabaseOptions()).RetrieveData(new List<string>() { $"{nameof(AnalysisMaterialAllowableCODETI)}" },
                pathToDB: connection.FileName)).Tables[$"{nameof(AnalysisMaterialAllowableCODETI)}"];

            //assert
            Assert.True(retVal);
            if (dataTable != null)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    Assert.Equal(code, row["Code"]);
                    Assert.Equal(edition, row["Edition"]);
                    Assert.Equal(material, row["Material"]);
                    Assert.Equal(poissonsRatio, Convert.ToDouble(row["PoissonsRatio"]));
                    Assert.Equal(elementID, row["ElementID"]);
                    Assert.Equal(longitudinalWeldJointEfficiency, Convert.ToDouble(row["LongitudinalWeldJointEfficiency"]));
                    Assert.Equal(hydroTestAllowablePressure, row["HydroTestAllowablePressure"]);
                    Assert.Equal(hydroTestAllowablePressureSiValue, Convert.ToDouble(row["HydroTestAllowablePressureSiValue"]));                    
                    Assert.Equal(name, row["Name"]);
                }
            }
            else
                Assert.Fail("Data retuned null DataTable.");
        }

        [Fact, Trait("Insert_Into_AnalysisMaterialAllowableRCCMCD", "1")]
        public async void Insert_Into_AnalysisMaterialAllowableRCCMCD()
        {
            //arrange
            await CopyDatabase($"{nameof(AnalysisMaterialAllowableRCCMCD)}{databaseName}", "A2template.a2db");
            Assert.True(connection.State == ConnectionState.Open);
            string id = Guid.NewGuid().ToString();
            string code = "ASME NC";
            string edition = "2009";
            string material = "(104) A106 Grade A";
            double? poissonsRatio = 0.2920;
            string elementID = Guid.NewGuid().ToString();
            string differenceOperatingPeakPressure = "0.1435";
            double? differenceOperatingPeakPressureSiValue = 0.1435;
            string hydroTestAllowablePressure = "0.543";
            double? hydroTestAllowablePressureSiValue = 0.543;
            string name = "Test Analysis Material Allowable ASME NC 2009";
            string description = "";

            DataSet ds = new DataSet();
            DataTable dt = new DataTable($"{nameof(AnalysisMaterialAllowableRCCMCD)}");
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("Code", typeof(string));
            dt.Columns.Add("Edition", typeof(string));
            dt.Columns.Add("Material", typeof(string));
            dt.Columns.Add("PoissonsRatio", typeof(double));
            dt.Columns.Add("ElementID", typeof(string));
            dt.Columns.Add("DifferenceOperatingPeakPressure", typeof(string));
            dt.Columns.Add("DifferenceOperatingPeakPressureSiValue", typeof(double));
            dt.Columns.Add("HydroTestAllowablePressure", typeof(string));
            dt.Columns.Add("HydroTestAllowablePressureSiValue", typeof(double));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Description", typeof(string));
            dt.Rows.Add(id, code, edition, material, poissonsRatio, elementID, differenceOperatingPeakPressure, differenceOperatingPeakPressureSiValue, hydroTestAllowablePressure, hydroTestAllowablePressureSiValue, name, description);
            ds.Tables.Add(dt);

            //act
            bool retVal = await new SQLiteOperations(new DatabaseOptions()).PersistData(ds, connection.FileName);
            DataTable? dataTable = (await new SQLiteOperations(new DatabaseOptions()).RetrieveData(new List<string>() { $"{nameof(AnalysisMaterialAllowableRCCMCD)}" },
                pathToDB: connection.FileName)).Tables[$"{nameof(AnalysisMaterialAllowableRCCMCD)}"];

            //assert
            Assert.True(retVal);
            if (dataTable != null)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    Assert.Equal(code, row["Code"]);
                    Assert.Equal(edition, row["Edition"]);
                    Assert.Equal(material, row["Material"]);
                    Assert.Equal(poissonsRatio, Convert.ToDouble(row["PoissonsRatio"]));
                    Assert.Equal(elementID, row["ElementID"]);
                    Assert.Equal(differenceOperatingPeakPressure, row["DifferenceOperatingPeakPressure"]);
                    Assert.Equal(differenceOperatingPeakPressureSiValue, Convert.ToDouble(row["DifferenceOperatingPeakPressureSiValue"]));
                    Assert.Equal(hydroTestAllowablePressure, row["HydroTestAllowablePressure"]);
                    Assert.Equal(hydroTestAllowablePressureSiValue, Convert.ToDouble(row["HydroTestAllowablePressureSiValue"]));
                    Assert.Equal(name, row["Name"]);
                }
            }
            else
                Assert.Fail("Data retuned null DataTable.");
        }


        [Fact, Trait("Insert_Into_AnalysisMaterialAllowableStoomwezen", "1")]
        public async void Insert_Into_AnalysisMaterialAllowableStoomwezen()
        {
            //arrange
            await CopyDatabase($"{nameof(AnalysisMaterialAllowableStoomwezen)}{databaseName}", "A2template.a2db");
            Assert.True(connection.State == ConnectionState.Open);
            string id = Guid.NewGuid().ToString();
            string code = "ASME NC";
            string edition = "2009";
            string material = "(104) A106 Grade A";
            double? poissonsRatio = 0.2920;
            string elementID = Guid.NewGuid().ToString();
            string averageCreepStress = "0.123";
            double? averageCreepStressSiValue = 0.123;
            string averageCreepTensileStress = "0.456";
            double? averageCreepTensileStressSiValue = 0.456;
            string minimumCreepTensileStress = "0.789";
            double? minimumCreepTensileStressSiValue = 0.789;
            string yieldStressDesignTemperature = "0.1011";
            double? yieldStressDesignTemperatureSiValue = 0.1011;
            double? cyclicReductionFactor = 0.1435;
            double? stoomwezenConstant = 0.5000;
            double? coefficientCM = 0.3750;
            string tensileStrength = "0.543";
            double? tensileStrengthSiValue = 0.543;
            string name = "Test Analysis Material Allowable ASME NC 2009";
            string description = "";

            DataSet ds = new DataSet();
            DataTable dt = new DataTable($"{nameof(AnalysisMaterialAllowableStoomwezen)}");
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("Code", typeof(string));
            dt.Columns.Add("Edition", typeof(string));
            dt.Columns.Add("Material", typeof(string));
            dt.Columns.Add("PoissonsRatio", typeof(double));
            dt.Columns.Add("ElementID", typeof(string));
            dt.Columns.Add("AverageCreepStress", typeof(string));
            dt.Columns.Add("AverageCreepStressSiValue", typeof(double));
            dt.Columns.Add("AverageCreepTensileStress", typeof(string));
            dt.Columns.Add("AverageCreepTensileStressSiValue", typeof(double));
            dt.Columns.Add("MinimumCreepTensileStress", typeof(string));
            dt.Columns.Add("MinimumCreepTensileStressSiValue", typeof(double));
            dt.Columns.Add("YieldStressDesignTemperature", typeof(string));
            dt.Columns.Add("YieldStressDesignTemperatureSiValue", typeof(double));
            dt.Columns.Add("CyclicReductionFactor", typeof(double));
            dt.Columns.Add("StoomwezenConstant", typeof(double));
            dt.Columns.Add("CoefficientCM", typeof(double));
            dt.Columns.Add("TensileStrength", typeof(string));
            dt.Columns.Add("TensileStrengthSiValue", typeof(double));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Description", typeof(string));
            dt.Rows.Add(id, code, edition, material, poissonsRatio, elementID, averageCreepStress, averageCreepStressSiValue, averageCreepTensileStress, averageCreepTensileStressSiValue, minimumCreepTensileStress, 
                minimumCreepTensileStressSiValue, yieldStressDesignTemperature, yieldStressDesignTemperatureSiValue, cyclicReductionFactor, stoomwezenConstant, coefficientCM, tensileStrength, tensileStrengthSiValue, name, description);
            ds.Tables.Add(dt);

            //act
            bool retVal = await new SQLiteOperations(new DatabaseOptions()).PersistData(ds, connection.FileName);
            DataTable? dataTable = (await new SQLiteOperations(new DatabaseOptions()).RetrieveData(new List<string>() { $"{nameof(AnalysisMaterialAllowableStoomwezen)}" },
                pathToDB: connection.FileName)).Tables[$"{nameof(AnalysisMaterialAllowableStoomwezen)}"];

            //assert
            Assert.True(retVal);
            if (dataTable != null)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    Assert.Equal(code, row["Code"]);
                    Assert.Equal(edition, row["Edition"]);
                    Assert.Equal(material, row["Material"]);
                    Assert.Equal(poissonsRatio, Convert.ToDouble(row["PoissonsRatio"]));
                    Assert.Equal(elementID, row["ElementID"]);
                    Assert.Equal(averageCreepStress, row["AverageCreepStress"]);
                    Assert.Equal(averageCreepStressSiValue, Convert.ToDouble(row["AverageCreepStressSiValue"]));
                    Assert.Equal(averageCreepTensileStress, row["AverageCreepTensileStress"]);
                    Assert.Equal(averageCreepTensileStressSiValue, Convert.ToDouble(row["AverageCreepTensileStressSiValue"]));
                    Assert.Equal(minimumCreepTensileStress, row["MinimumCreepTensileStress"]);
                    Assert.Equal(minimumCreepTensileStressSiValue, Convert.ToDouble(row["MinimumCreepTensileStressSiValue"]));
                    Assert.Equal(yieldStressDesignTemperature, row["YieldStressDesignTemperature"]);
                    Assert.Equal(yieldStressDesignTemperatureSiValue, Convert.ToDouble(row["YieldStressDesignTemperatureSiValue"]));
                    Assert.Equal(cyclicReductionFactor, Convert.ToDouble(row["CyclicReductionFactor"]));
                    Assert.Equal(stoomwezenConstant, Convert.ToDouble(row["StoomwezenConstant"]));
                    Assert.Equal(coefficientCM, Convert.ToDouble(row["CoefficientCM"]));
                    Assert.Equal(tensileStrength, row["TensileStrength"]);
                    Assert.Equal(tensileStrengthSiValue, Convert.ToDouble(row["TensileStrengthSiValue"]));
                    Assert.Equal(name, row["Name"]);
                }
            }
            else
                Assert.Fail("Data retuned null DataTable.");
        }

        [Fact, Trait("Insert_Into_AnalysisMaterialAllowableSwedishPowerCodeMethod1", "1")]
        public async void Insert_Into_AnalysisMaterialAllowableSwedishPowerCodeMethod1()
        {
            //arrange
            await CopyDatabase($"{nameof(AnalysisMaterialAllowableSwedishPowerCodeMethod1)}{databaseName}", "A2template.a2db");
            Assert.True(connection.State == ConnectionState.Open);
            string id = Guid.NewGuid().ToString();
            string code = "ASME NC";
            string edition = "2009";
            string material = "(104) A106 Grade A";
            double? poissonsRatio = 0.2920;
            string elementID = Guid.NewGuid().ToString();
            double? circumferentialJointFactor = 0.1435;
            double? stigmaMultiplier = 0.5000;
            double? betaSeffCalculation = 0.3750;
            string name = "Test Analysis Material Allowable ASME NC 2009";
            string description = "";

            DataSet ds = new DataSet();
            DataTable dt = new DataTable($"{nameof(AnalysisMaterialAllowableSwedishPowerCodeMethod1)}");
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("Code", typeof(string));
            dt.Columns.Add("Edition", typeof(string));
            dt.Columns.Add("Material", typeof(string));
            dt.Columns.Add("PoissonsRatio", typeof(double));
            dt.Columns.Add("ElementID", typeof(string));
            dt.Columns.Add("CircumferentialJointFactor", typeof(double));
            dt.Columns.Add("StigmaMultiplier", typeof(double));
            dt.Columns.Add("BetaSeffCalculation", typeof(double));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Description", typeof(string));
            dt.Rows.Add(id, code, edition, material, poissonsRatio, elementID, circumferentialJointFactor, stigmaMultiplier, betaSeffCalculation, name, description);
            ds.Tables.Add(dt);

            //act
            bool retVal = await new SQLiteOperations(new DatabaseOptions()).PersistData(ds, connection.FileName);
            DataTable? dataTable = (await new SQLiteOperations(new DatabaseOptions()).RetrieveData(new List<string>() { $"{nameof(AnalysisMaterialAllowableSwedishPowerCodeMethod1)}" },
                pathToDB: connection.FileName)).Tables[$"{nameof(AnalysisMaterialAllowableSwedishPowerCodeMethod1)}"];

            //assert
            Assert.True(retVal);
            if (dataTable != null)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    Assert.Equal(code, row["Code"]);
                    Assert.Equal(edition, row["Edition"]);
                    Assert.Equal(material, row["Material"]);
                    Assert.Equal(poissonsRatio, Convert.ToDouble(row["PoissonsRatio"]));
                    Assert.Equal(elementID, row["ElementID"]);
                    Assert.Equal(circumferentialJointFactor, Convert.ToDouble(row["CircumferentialJointFactor"]));
                    Assert.Equal(stigmaMultiplier, Convert.ToDouble(row["StigmaMultiplier"]));
                    Assert.Equal(betaSeffCalculation, Convert.ToDouble(row["BetaSeffCalculation"]));                    
                    Assert.Equal(name, row["Name"]);
                }
            }
            else
                Assert.Fail("Data retuned null DataTable.");
        }


        [Fact, Trait("Insert_Into_AnalysisMaterialAllowableSwedishPowerCodeMethod2", "1")]
        public async void Insert_Into_AnalysisMaterialAllowableSwedishPowerCodeMethod2()
        {
            //arrange
            await CopyDatabase($"{nameof(AnalysisMaterialAllowableSwedishPowerCodeMethod2)}{databaseName}", "A2template.a2db");
            Assert.True(connection.State == ConnectionState.Open);
            string id = Guid.NewGuid().ToString();
            string code = "ASME NC";
            string edition = "2009";
            string material = "(104) A106 Grade A";
            double? poissonsRatio = 0.2920;
            string elementID = Guid.NewGuid().ToString();
            double? circumferentialJointFactor = 0.1435;
            string ultimateTensileStrength = "1.78";
            double? ultimateTensileStrengthSiValue = 1.78;
            double? betaSeffCalculation = 0.3750;
            string name = "Test Analysis Material Allowable ASME NC 2009";
            string description = "";

            DataSet ds = new DataSet();
            DataTable dt = new DataTable($"{nameof(AnalysisMaterialAllowableSwedishPowerCodeMethod2)}");
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("Code", typeof(string));
            dt.Columns.Add("Edition", typeof(string));
            dt.Columns.Add("Material", typeof(string));
            dt.Columns.Add("PoissonsRatio", typeof(double));
            dt.Columns.Add("ElementID", typeof(string));
            dt.Columns.Add("CircumferentialJointFactor", typeof(double));
            dt.Columns.Add("UltimateTensileStrength", typeof(string));
            dt.Columns.Add("UltimateTensileStrengthSiValue", typeof(double));
            dt.Columns.Add("BetaSeffCalculation", typeof(double));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Description", typeof(string));
            dt.Rows.Add(id, code, edition, material, poissonsRatio, elementID, circumferentialJointFactor, ultimateTensileStrength, ultimateTensileStrengthSiValue, betaSeffCalculation, name, description);
            ds.Tables.Add(dt);

            //act
            bool retVal = await new SQLiteOperations(new DatabaseOptions()).PersistData(ds, connection.FileName);
            DataTable? dataTable = (await new SQLiteOperations(new DatabaseOptions()).RetrieveData(new List<string>() { $"{nameof(AnalysisMaterialAllowableSwedishPowerCodeMethod2)}" },
                pathToDB: connection.FileName)).Tables[$"{nameof(AnalysisMaterialAllowableSwedishPowerCodeMethod2)}"];

            //assert
            Assert.True(retVal);
            if (dataTable != null)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    Assert.Equal(code, row["Code"]);
                    Assert.Equal(edition, row["Edition"]);
                    Assert.Equal(material, row["Material"]);
                    Assert.Equal(poissonsRatio, Convert.ToDouble(row["PoissonsRatio"]));
                    Assert.Equal(elementID, row["ElementID"]);
                    Assert.Equal(circumferentialJointFactor, Convert.ToDouble(row["CircumferentialJointFactor"]));
                    Assert.Equal(ultimateTensileStrength, row["UltimateTensileStrength"]);
                    Assert.Equal(ultimateTensileStrengthSiValue, Convert.ToDouble(row["UltimateTensileStrengthSiValue"]));
                    Assert.Equal(betaSeffCalculation, Convert.ToDouble(row["BetaSeffCalculation"]));
                    Assert.Equal(name, row["Name"]);
                }
            }
            else
                Assert.Fail("Data retuned null DataTable.");
        }
        #endregion

        #region PRIVATE AND INTERNAL SECTION
        private static Random random = new Random(42);
        internal class AllSIOEntity : IEnumerable<object[]>
        {
            internal List<object[]> data = new List<object[]>();
            public AllSIOEntity()
            {
                var list = typeof(SIOEntity)
                    .Assembly.GetTypes()
                    .Where(t => t.IsSubclassOf(typeof(SIOEntity)) && !t.IsAbstract).ToList();
                foreach (var item in list)
                {
                    data.Add(new object[] { item });
                }
            }

            public IEnumerator<object[]> GetEnumerator()
            {
                return data.GetEnumerator();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return data.GetEnumerator();
            }
        }
        internal async Task CopyDatabase(string dbName, string baseDBToCopy = "")
        {
            var baseDir = Directory.GetCurrentDirectory().ToString();
            var relativePath = Path.Combine(@"..", @"..", @"..", @"..");
            string testDirectory = Path.GetFullPath(baseDir + relativePath);
            testDBFilePath = $"{testDirectory}{Path.DirectorySeparatorChar}SQLiteTestDatabase{Path.DirectorySeparatorChar}{dbName}";
            FileInfo fi = new FileInfo(testDBFilePath);
            if (fi.Exists)
                fi.Delete();

            string sampleDB = $"{testDirectory}{Path.DirectorySeparatorChar}SQLiteTestDatabase{Path.DirectorySeparatorChar}{(baseDBToCopy == "" ? databaseName : baseDBToCopy)}";
            using (SQLiteConnection temp = new SQLiteConnection(string.Format(ConnectionConstants.SQLiteFileBasedConnectionString, sampleDB)))
            {
                await temp.OpenAsync();
                connection = new SQLiteConnection(string.Format(ConnectionConstants.SQLiteFileBasedConnectionString, testDBFilePath));
                await connection.OpenAsync();
                temp.BackupDatabase(connection, "main", "main", -1, null, 0);
                await temp.CloseAsync();
            }
        }

        static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        private static SIOEntity SetDefaultProperties(SIOEntity entity, PropertyInfo[] props)
        {
            var stringValues = RandomString(random.Next(30));
            foreach (var info in props)
            {
                if (info.Name == "OBID" || info.Name == "UID")
                {
                    continue;
                }
                if (info.Name == "Name")
                {
                    info.SetValue(entity, $"{entity.GetType().Name}-{Guid.NewGuid()}", null);
                    continue;
                }
                if (!info.CanWrite)
                {
                    Console.WriteLine($"Property {info.Name} could not write");
                    continue;
                }

                dynamic? val = "";

                UoMAttribute? uom = Attribute.GetCustomAttributes(info, typeof(UoMAttribute), true).FirstOrDefault() as UoMAttribute;
                if (uom != null)
                {
                    //string uomtype;
                    //string key = $"{entity.GetType().Name}.{info.Name}";
                    //lock (entity.UomTypes)
                    //{
                    //    if (!entity.UomTypes.ContainsKey(key))
                    //    {
                    //        entity.UomTypes.TryAdd(key, uom.uomtype);
                    //        uomtype = uom.uomtype;
                    //    }
                    //    else
                    //    {
                    //        entity.UomTypes.TryGetValue(key, out uomtype);
                    //    }
                    //}
                    //var sioEnum = SIOEnum.FindByType(uomtype).FirstOrDefault().Text;
                    val = $"{random.NextDouble() * random.Next()}";
                    info.SetValue(entity, val, null);

                    continue;
                }
                if (info.PropertyType == typeof(string))
                {
                    val = RandomString(random.Next(30));
                }
                else if (info.PropertyType == typeof(int))
                {
                    val = random.Next() + 1;
                }
                else if (info.PropertyType == typeof(double))
                {
                    val = random.NextDouble() * random.Next();
                }
                else if (info.PropertyType == typeof(double?))
                {
                    if (random.Next(1) == 1)
                    {
                        val = null;
                    }
                    else
                    {
                        val = random.NextDouble() * random.Next();
                    }

                }
                else if (info.PropertyType == typeof(bool))
                {
                    if (random.Next(1) == 1)
                    {
                        val = false;
                    }
                    else
                    {
                        val = true;
                    }
                }
                else if (info.PropertyType == typeof(bool?))
                {
                    if (random.Next(1) == 1)
                    {
                        val = false;
                    }
                    else
                    {
                        val = true;
                    }
                }
                else
                {
                    val = null;
                }
                info?.GetSetMethod(true)?.Invoke(entity, new object?[] { val });

            }
            return entity;
        }
        #endregion
    }
}

