using Hexagon.ALI.Analysis.Common.Classes;
using Hexagon.ALI.Analysis.Common.Helpers.Objects;
using System.Reflection;
using System.Runtime.Serialization;
using Xunit;

namespace Hexagon.ALI.Analysis.Common.Entities.L0.Tests.CSV
{
    public class CSVTests
    {
        const string skip = "CSV Tests are currently ignored.";
        readonly SourceReader sr = new();

        private enum TagTypeCol { VERSION = 0, BRANCH, LEVEL, CLASS_NAME, NUMBER, INTERFACES, CLASS_GUID, ENUM_GUID, DISPLAY_NAME, DESCRIPTION, EDGE_DEFINITION, CONTEXT_DEFINITION, CORRELATION_RULES, DESIGN_COMPONENTS, USER_FOR_SCOPING, REL_PATH_TO_GROUP, PRECEDENCE_CATEGORY, TOTAL_COLUMNS };
        private enum InterfaceCol { Version = 0, Branch, Interface, Include, Properties, DataFlows, GUID, DisplayName, Description, Category, PrecedenceCategory }
        private enum RelDefCol { Version = 0, End1 = 2, Cardinality2 = 7, RelDef = 5, End2 = 9 }


        // Items to be resolved
        readonly HashSet<string> interfaceSkipList = new() { };

        // Items to be resolved
        readonly HashSet<string> classSkipList = new() { };

        // Items to be resolved
        readonly HashSet<string> relDefSkipList = new()
        {
            "OperatingConditionProcessData",
        };

        public CSVTests()
        {
            //Generate("NozzleFlex", "NodalAuxiliaries");
        }

        [Fact(Skip = skip)]
        //[Fact, Trait("Priority", "0")]
        public void CompareSourceToTagTypes_ForCSVData_ShouldGiveNoErrors()
        {
            //arrange
            List<string> errors = new List<string>();
            //act
            var tags = GetClassInterfacesFromSpreadsheet();

            foreach (var kv in sr.ClassInterfaces)
            {
                string className = kv.Key;
                HashSet<string> interfaces = kv.Value;

                if (classSkipList.Contains(className))
                {
                    continue;
                }

                if (!tags.ContainsKey(className))
                {
                    errors.Add($"'{className}' not found in TagType spreadsheet");
                    continue;
                }
                foreach (var iName in interfaces)
                {
                    if (!tags[className].Contains(iName) && !interfaceSkipList.Contains(iName))
                    {
                        errors.Add($"'{className}' is not implementing '{iName}' in TagType spreadsheet");
                    }
                }
            }
            //assert
            Assert.True(errors.Count == 0, string.Join("\r\n", errors.Distinct().OrderBy(s => s)));
        }

        [Fact(Skip = skip)]
        //[Fact, Trait("Priority", "0")]
        public void CompareTagTypesToSource_ForCSVData_ShouldGiveNoErrors()
        {
            //arrange
            List<string> errors = new List<string>();
            //act
            foreach (var kv in GetClassInterfacesFromSpreadsheet())
            {
                string className = kv.Key;
                HashSet<string> interfaces = kv.Value;

                if (classSkipList.Contains(className))
                {
                    continue;
                }

                if (!sr.ClassInterfaces.ContainsKey(className))
                {
                    errors.Add($"'{className}' not found in source code");
                    continue;
                }
                foreach (var iName in interfaces)
                {
                    if (!iName.Contains("IAnalysis"))
                    {
                        continue;
                    }

                    if (!sr.ClassInterfaces[className].Contains(iName))
                    {
                        errors.Add($"'{className}' is not implementing '{iName}' in source code");
                    }
                }
            }
            //assert
            Assert.True(errors.Count == 0, string.Join("\r\n", errors.Distinct().OrderBy(s => s)));
        }

        [Fact(Skip = skip)]
        //[Fact, Trait("Priority", "0")]
        public void CompareInterfacesToSource_ForCSVData_ShouldGiveNoErrors()
        {
            //arrange
            List<string> errors = new();
            //act
            Dictionary<string, Dictionary<string, string>> spreadsheetData = GetInterfaceInfo();

            foreach ((string interfaceNameSheet, Dictionary<string, string> propertiesSheet) in spreadsheetData.Select(s => (s.Key, s.Value)))
            {
                if (interfaceSkipList.Contains(interfaceNameSheet))
                {
                    continue;
                }

                if (!sr.InterfaceProperties.ContainsKey(interfaceNameSheet))
                {
                    errors.Add($"'{interfaceNameSheet}' interface not found in source code");
                    continue;
                }

                var sourceProps = sr.InterfaceProperties[interfaceNameSheet];

                foreach ((string sheetPropertyName, string sheetPropertyType) in propertiesSheet.Select(s => (s.Key, s.Value)))
                {
                    string key = $"{interfaceNameSheet}.{sheetPropertyName}";
                    //Possible Duplicate if exception thrown
                    try
                    {
                        var sourcePropInfo2 = sr.ClassProperties.Values.First(f => f.ContainsKey(key))[key];

                    }
                    catch (Exception)
                    {

                    }
                    var sourcePropInfo = sr.ClassProperties.Values.First(f => f.ContainsKey(key))[key];


                    if (!sourcePropInfo.IsRelDefAttribute && !sourcePropInfo.IsSiValue)
                    {
                        if (!sourceProps.ContainsKey(sheetPropertyName))
                        {
                            errors.Add($"{interfaceNameSheet}.{sheetPropertyName} property not found in source code");
                            continue;
                        }

                        string sourcePropertyType = sourcePropInfo.IsUoMAttribute ? sourcePropInfo.UoM.uomtype : sourcePropInfo.PropertyInfo.PropertyType.UpdateTypeName();

                        // TODO: sourcePropertyType != "string" can be removed after AnalysisBendFlangeType and AnalysisLoadCaseStressType in spreadsheet are investigated
                        if (sheetPropertyType.ToLower().Trim() != sourcePropertyType.ToLower() && sourcePropertyType != "string")
                        {
                            errors.Add($"Mismatching types for {interfaceNameSheet}.{sheetPropertyName}: Source={sourcePropertyType}, Spreadsheet={sheetPropertyType}");
                            continue;
                        }
                        continue;
                    }
                    throw new NotSupportedException($"Unexpected match for {sheetPropertyName}: Reldefs or SiValues shouldn't be in Interface spreadsheet");

                }
            }
            //assert
            Assert.True(errors.Count == 0, string.Join("\r\n", errors.Distinct().OrderBy(s => s)));
        }

        [Fact(Skip = skip)]
        //[Fact, Trait("Priority", "0")]
        public void CompareSourceToInterfaces_ForCSVData_ShouldGiveNoErrors()
        {
            //arrange
            List<string> errors = new();
            //act
            Dictionary<string, Dictionary<string, string>> spreadsheetData = GetInterfaceInfo().OrderBy(o => o.Key).ToDictionary();

            foreach ((string interfaceNameSource, Dictionary<string, PropertyInfo> propertiesSource) in sr.InterfaceProperties.OrderBy(o => o.Key).Select(s => (s.Key, s.Value)))
            {
                if (interfaceSkipList.Contains(interfaceNameSource))
                {
                    continue;
                }

                if (!spreadsheetData.ContainsKey(interfaceNameSource))
                {
                    errors.Add($"'{interfaceNameSource}' interface not found in Interfaces spreadsheet");
                    continue;
                }

                var sheetProps = spreadsheetData[interfaceNameSource];

                foreach ((string sourcePropertyName, PropertyInfo pInfo) in propertiesSource.Select(s => (s.Key, s.Value)))
                {
                    string key = $"{interfaceNameSource}.{sourcePropertyName}";
                    //Possible Duplicate if exception thrown
                    try
                    {
                        var sourcePropInfo2 = sr.ClassProperties.Values.First(f => f.ContainsKey(key))[key];

                    }
                    catch (Exception)
                    {

                    }
                    var sourcePropInfo = sr.ClassProperties.Values.First(f => f.ContainsKey(key))[key];

                    if (sourcePropInfo.PropertyInfo.CustomAttributes.Any(a => a.AttributeType == typeof(IgnoreDataMemberAttribute)))
                        continue;

                    if (!sourcePropInfo.IsRelDefAttribute && !sourcePropInfo.IsSiValue)
                    {
                        if (!sheetProps.ContainsKey(sourcePropertyName))
                        {
                            errors.Add($"{interfaceNameSource}.{sourcePropertyName} property not found in Interfaces spredsheet");
                            continue;
                        }

                        string sourcePropertyType = sourcePropInfo.IsUoMAttribute ? sourcePropInfo.UoM.uomtype : pInfo.PropertyType.UpdateTypeName();
                        string sheetPropertyType = sheetProps[sourcePropertyName];

                        // TODO: This can be removed after AnalysisBendFlangeType and AnalysisLoadCaseStressType in spreadsheet are investigated
                        if (sourcePropertyType.ToLower().Trim() != sheetPropertyType.ToLower() && sourcePropertyType != "string")
                        {
                            errors.Add($"Mismatching types for {interfaceNameSource}.{sourcePropertyName}: Source={sourcePropertyType}, Spreadsheet={sheetProps[sourcePropertyName]}");
                            continue;
                        }
                        if (sourcePropInfo.IsUoMAttribute)
                        {
                            string backingProp = $"{sourcePropInfo.Name}SiValue";
                            if (!propertiesSource.ContainsKey(backingProp))
                            {
                                errors.Add($"{sourcePropInfo.Name} is missing corresponding {backingProp} property");
                                continue;
                            }
                        }
                        continue;
                    }

                    if (sourcePropInfo.IsSiValue)
                    {
                        string mainProp = sourcePropInfo.Name.Replace("SiValue", "");
                        if (!propertiesSource.ContainsKey(mainProp))
                        {
                            errors.Add($"{sourcePropInfo.Name} is missing corresponding {mainProp} property");
                            continue;
                        }
                        string key2 = $"{interfaceNameSource}.{mainProp}";
                        var sourcePropInfo2 = sr.ClassProperties.Values.First(f => f.ContainsKey(key2))[key2];
                        if (!sourcePropInfo2.IsUoMAttribute || sourcePropInfo2.UoM == null)
                        {
                            errors.Add($"{key2} is missing UoMAttribute");
                            continue;
                        }
                    }
                }

            }
            //assert
            Assert.True(errors.Count == 0, string.Join("\r\n", errors.Distinct().OrderBy(s => s)));
        }

        [Fact(Skip = skip)]
        //[Fact, Trait("Priority", "0")]
        public void CompareRelDefsToSource_ForCSVData_ShouldGiveNoErrors()
        {
            //arrange
            List<string> errors = new();
            //act
            var spreadsheetData = GetRelDefData();

            foreach (var rel in spreadsheetData)
            {
                if (relDefSkipList.Contains(rel.RelDefName))
                {
                    continue;
                }

                if (!rel.End1.Contains("IAnalysis"))
                {
                    continue;
                }

                if (interfaceSkipList.Contains(rel.End1))
                {
                    continue;
                }

                if (!sr.ClassProperties.Values.Any(f => f.Keys.Any(a => a.Contains($"{rel.End1}."))) ||
                    !sr.ClassProperties.Values.Where(f => f.Keys.Any(a => a.Contains($"{rel.End1}."))).Any(w => w.Values.Any(c => c.IsRelDefAttribute)))
                {
                    errors.Add($"{rel.RelDefName} does not exist in source");
                    continue;
                }

                var interfaceProperties = sr.ClassProperties.Values.First(f => f.Keys.Any(a => a.Contains($"{rel.End1}."))).Where(w => w.Value.IsRelDefAttribute).ToDictionary(s => s.Key, s => s.Value);

                if (!interfaceProperties.Values.Any(a => a.IsRelDefAttribute && a.RelDef.relDef == rel.RelDefName))
                {
                    errors.Add($"{rel.RelDefName} does not exist in source");
                    continue;
                }

                var source = interfaceProperties.Values.First(a => a.IsRelDefAttribute && a.RelDef.relDef == rel.RelDefName);

                if (rel.End1 != source.PropertyInfo.ReflectedType?.Name)
                {
                    errors.Add($"{rel.RelDefName} has mismatching End1's");
                    continue;
                }

                Type type1 = source.PropertyInfo.PropertyType;
                string key = $"{source.PropertyInfo.ReflectedType.Name}.{source.PropertyInfo.Name}";

                if (rel.IsList)
                {
                    if (type1.IsGenericType && type1.GetGenericTypeDefinition() != typeof(List<>) || type1.GenericTypeArguments.Count() == 0 || type1.GenericTypeArguments[0].Name != rel.End2)
                    {
                        errors.Add($"{key} property was expected to be of type List<{rel.End2}> for {rel.RelDefName} to match RelDefs spreadsheet");
                        continue;
                    }
                }
                else
                {
                    if (type1.IsGenericType && type1.GetGenericTypeDefinition() == typeof(List<>) || type1.Name != rel.End2)
                    {
                        errors.Add($"{key} property expected to be of type {rel.End2} for {rel.RelDefName} in RelDefs spreadsheet");
                        continue;
                    }
                }
            }
            //assert
            Assert.True(errors.Count == 0, string.Join("\r\n", errors.Distinct().OrderBy(s => s)));
        }


        [Fact(Skip = skip)]
        //[Fact, Trait("Priority", "0")]
        public void CompareSourceToRelDefs_ForCSVData_ShouldGiveNoErrors()
        {
            //arrange
            List<string> errors = new();
            //act
            var spreadsheetData = GetRelDefData();

            foreach ((string interfaceNameSource, Dictionary<string, PropertyInfo> propertiesSource) in sr.InterfaceProperties.Where(w => sr.ClassProperties.Any(a => a.Value.Any(b => b.Value.IsRelDefAttribute && b.Key.Contains(w.Key)))).Select(s => (s.Key, s.Value)))
            {
                if (interfaceSkipList.Contains(interfaceNameSource) || propertiesSource.Count == 0)
                {
                    continue;
                }

                var interfaceProperties = sr.ClassProperties.Values.First(f => f.Keys.Any(a => a.Contains($"{interfaceNameSource}."))).Where(w => w.Value.IsRelDefAttribute);

                foreach ((string key, PropertyHelper sourcePropInfo) in interfaceProperties)
                {
                    if (relDefSkipList.Contains(sourcePropInfo.RelDef.relDef))
                    {
                        continue;
                    }

                    if (!spreadsheetData.Any(f => f.RelDefName == sourcePropInfo.RelDef.relDef))
                    {
                        errors.Add($"{sourcePropInfo.RelDef.relDef} does not exist in RelDefs spreadsheet");
                        continue;
                    }

                    var (End1, IsList, RelDefName, End2) = spreadsheetData.First(f => f.RelDefName == sourcePropInfo.RelDef.relDef);

                    if (sourcePropInfo.PropertyInfo.ReflectedType?.Name != End1)
                    {
                        errors.Add($"Expected interface name '{sourcePropInfo.PropertyInfo.ReflectedType?.Name}' for {RelDefName} to match End1 '{End1}' in RelDefs spreadsheet");
                        continue;
                    }

                    Type type1 = sourcePropInfo.PropertyInfo.PropertyType;

                    if (IsList)
                    {
                        if (type1.IsGenericType && type1.GetGenericTypeDefinition() != typeof(List<>) || type1.GenericTypeArguments.Count() == 0 || type1.GenericTypeArguments[0].Name != End2)
                        {
                            errors.Add($"{key} property was expected to be of type List<{End2}> for {RelDefName} to match RelDefs spreadsheet");
                            continue;
                        }
                    }
                    else
                    {
                        if (type1.IsGenericType && type1.GetGenericTypeDefinition() == typeof(List<>) || type1.Name != End2)
                        {
                            errors.Add($"{key} property expected to be of type {End2} for {RelDefName} in RelDefs spreadsheet");
                            continue;
                        }
                    }
                }
            }
            //assert
            Assert.True(errors.Count == 0, string.Join("\r\n", errors.Distinct().OrderBy(s => s)));
        }

        Dictionary<string, Dictionary<string, string>> GetInterfaceInfo()
        {
            Dictionary<string, Dictionary<string, string>> csv_data = new();

            List<string> lines = GetTextFromCSV("Interfaces.csv");

            foreach (string? d in lines)
            {
                if (string.IsNullOrWhiteSpace(d))
                {
                    continue;
                }

                int iNameStart = d.IndexOfNth(",", (int)InterfaceCol.Interface - 1) + 1;
                int iNameEnd = d.IndexOf(',', iNameStart) + 1;
                int propStart = d.IndexOf(",", iNameEnd);
                int propEnd = d.IndexOf(",PipeStressAnalysis", propStart + 1);

                if (iNameStart <= 0 || iNameEnd <= 0 || propStart <= 0 || propEnd <= 0)
                {
                    throw new Exception("Parsing error.");
                }

                string iName = d.Substring(iNameStart, iNameEnd - iNameStart - 1);

                string? props = d.Substring(propStart + 1, propEnd - propStart - 1);
                props = props.Replace("\"", "");
                string[]? data = props.Split(',', StringSplitOptions.RemoveEmptyEntries);

                if (!data.Any())
                {
                    csv_data.Add(iName, new Dictionary<string, string>());
                }

                foreach (string? dd in data)
                {
                    if (dd.Contains('[') && dd.Contains(']'))
                    {
                        string vName = dd.Substring(0, dd.IndexOf('[')).Trim();
                        string vType = dd.Split('[', ']')[1].Trim();
                        vType = vType == "boolean" ? "bool" : vType;

                        if (csv_data.ContainsKey(iName))
                        {
                            csv_data[iName].TryAdd(vName, vType);
                        }
                        else
                        {
                            csv_data.Add(iName, new Dictionary<string, string>());
                            csv_data[iName].Add(vName, vType);
                        }
                    }
                }

            }

            return csv_data;
        }

        List<KeyValuePair<string, List<string>>> GetTagTypeData()
        {
            List<string>? tableData = GetTextFromCSV("TagTypes.csv");
            Assert.NotEmpty(tableData);

            List<KeyValuePair<string, List<string>>> tags = new();
            foreach (string? row in tableData)
            {
                if (string.IsNullOrWhiteSpace(row))
                {
                    continue;
                }

                List<string>? columns = row.Split(',').ToList();
                tags.Add(new KeyValuePair<string, List<string>>(columns[(int)TagTypeCol.CLASS_NAME], columns));
            }

            for (int i = 0; i < tags.Count; ++i)
            {
                KeyValuePair<string, List<string>> keyValuePair = tags.ElementAt(i);
                if (keyValuePair.Value.Any(s => s.Contains("\"")))
                {
                    List<string>? rebuiltColumns = new();
                    List<string>? tmpList = new();
                    int iCollectStart = 0;

                    foreach (string column in keyValuePair.Value)
                    {
                        if (column.Length > 0)
                        {
                            bool bEnd = false;
                            if (column[0] == '"')
                            {
                                iCollectStart = i;
                            }
                            else if (column[column.Length - 1] == '"')
                            {
                                bEnd = true;
                            }

                            if (iCollectStart > 0)
                            {
                                tmpList.Add(column.Replace("\"", ""));
                                if (bEnd)
                                {
                                    string interfaces = string.Join(",", tmpList);
                                    rebuiltColumns.Add(interfaces);
                                    iCollectStart = 0;
                                    tmpList.Clear();
                                }
                                continue;
                            }
                        }
                        rebuiltColumns.Add(column);
                    }

                    tags[i] = new KeyValuePair<string, List<string>>(tags[i].Key, rebuiltColumns);
                }
            }
            Assert.NotEmpty(tags);
            Assert.True(tags.All(s => s.Value.Count == (int)TagTypeCol.TOTAL_COLUMNS));

            return tags;
        }

        List<(string End1, bool IsList, string RelDefName, string End2)> GetRelDefData()
        {
            List<(string End1, bool IsList, string RelDefName, string End2)> relDefData = new();
            List<string>? tableData = GetTextFromCSV("RelDefs.csv");
            Assert.NotEmpty(tableData);


            foreach (var line in tableData)
            {
                if (string.IsNullOrEmpty(line))
                {
                    continue;
                }

                var lineData = line.Split(',');

                bool isList = lineData[(int)RelDefCol.Cardinality2].Contains("..*") || lineData[(int)RelDefCol.Cardinality2].Contains("..2") || lineData[(int)RelDefCol.Cardinality2].Contains("2..5");

                relDefData.Add((lineData[(int)RelDefCol.End1], isList, lineData[(int)RelDefCol.RelDef], lineData[(int)RelDefCol.End2]));
            }

            return relDefData;
        }

        Dictionary<string, HashSet<string>> GetClassInterfacesFromSpreadsheet()
        {
            Dictionary<string, HashSet<string>> keyValuePairs = new();

            var tags = GetTagTypeData();

            foreach (var keyValue in tags)
            {
                keyValuePairs.Add(keyValue.Key, keyValue.Value[(int)TagTypeCol.INTERFACES].Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(s => s.Trim()).ToHashSet());
            }

            for (int i = 0; i < tags.Count; ++i)
            {
                List<string> interfaces = new();
                List<string> columns = tags.ElementAt(i).Value;

                int hierarchy = Convert.ToInt32(columns[(int)TagTypeCol.LEVEL]);
                if (hierarchy > 1)
                {
                    int index = i;

                    while (index > 0)
                    {
                        List<string>? baseColumns = tags.ElementAt(--index).Value;
                        int baseHierarchy = Convert.ToInt32(baseColumns[(int)TagTypeCol.LEVEL]);
                        if (hierarchy <= baseHierarchy)
                        {
                            continue;
                        }

                        interfaces.AddRange(baseColumns[(int)TagTypeCol.INTERFACES].Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(s => s.Trim()));

                        hierarchy = baseHierarchy;
                    }
                }

                foreach (var iName in interfaces)
                {
                    keyValuePairs[tags[i].Key].Add(iName);
                }
            }

            return keyValuePairs;
        }

        List<string> GetTextFromCSV(string filename)
        {
            var baseDir = Directory.GetCurrentDirectory().ToString();
            var relativePath = Path.Combine(@"..", @"..", @"..", @"..", @"..", @"..");
            string parentPath = Path.GetFullPath(baseDir + relativePath);
            string path = Path.GetFullPath(Path.Combine(parentPath, "Schema", "Csv", filename));
            Assert.True(File.Exists(path), $"File does not exist: {path}");

            string text = File.ReadAllText(path);
            Assert.True(text?.Length > 0, $"File is empty: {path}");

            List<string>? lines = text?.Split(Environment.NewLine)?.ToList() ?? new List<string>();
            Assert.True(lines.Count > 1, path);

            lines = lines.Skip(1).ToList() ?? new List<string>();
            Assert.NotEmpty(lines);

            return lines;
        }

        string FindFilePath(string startingDirectory, string filename)
        {
            string file = Path.GetFullPath(Path.Combine(startingDirectory, filename));
            if (!File.Exists(file))
            {
                string[] dirs = Directory.GetDirectories(startingDirectory);
                foreach (string? dir in dirs)
                {
                    file = Path.GetFullPath(Path.Combine(dir, filename));
                    if (File.Exists(file))
                    {
                        return file;
                    }

                    file = FindFilePath(dir, filename);
                    if (File.Exists(file))
                    {
                        return file;
                    }
                }
            }
            return file;
        }

    }

    public class SourceReader
    {
        // Dictionary<ClassName, HashSet<InterfaceName>>
        public Dictionary<string, HashSet<string>> ClassInterfaces { get; }

        // Dictionary<ClassName, Dictionary<InterfaceName.PropertyName, PropertyHelper>>
        public Dictionary<string, Dictionary<string, PropertyHelper>> ClassProperties { get; }


        // Dictionary<InterfaceName, List<PropertyInfo>>
        public Dictionary<string, Dictionary<string, PropertyInfo>> InterfaceProperties { get; }

        public SourceReader()
        {
            ClassInterfaces = typeof(SIOEntity).Assembly.GetTypes()
                .Where(t => t.IsSubclassOf(typeof(SIOEntity)) && t.Name.Contains("Analysis"))
                .ToDictionary(s => s.Name, s => s.GetInterfaces().Where(w => w.Name.Contains("IAnalysis")).Select(n => n.Name).ToHashSet());

            ClassProperties = typeof(SIOEntity).Assembly.GetTypes()
                .Where(t => t.IsSubclassOf(typeof(SIOEntity)) && t.Name.Contains("Analysis"))
                .ToDictionary(s => s.Name, s => s)
                .ToDictionary(s => s.Key, s => PropertyHelper.GetInterfaces(s.Value).Values.Where(w => w.PropertyInfo.ReflectedType?.Name.Contains("IAnalysis") == true).ToDictionary(d => $"{d.PropertyInfo.ReflectedType?.Name}.{d.Name}", d => d));


            var interfaces = AppDomain.CurrentDomain.GetAssemblies().Where(w => w.FullName?.Contains("Hexagon.ALI.Analysis.Common") ?? false).SelectMany(s => s.GetExportedTypes().Where(q => q.Name.Contains("IAnalysis")));

            InterfaceProperties = interfaces.Distinct().ToDictionary(d => d.Name, d => d.GetProperties().ToDictionary(p => p.Name, p => p));
        }
    }


    public static class TestExtensionsCSV
    {
        public static string UpdateTypeName(this Type type)
        {
            if (Nullable.GetUnderlyingType(type) != null)
            {
                var undertype = Nullable.GetUnderlyingType(type);
                if (undertype != null)
                {
                    type = undertype;
                }
            }

            Dictionary<Type, string> types = new()
            {
                { typeof(bool), "bool" },
                { typeof(byte), "byte" },
                { typeof(char), "char" },
                { typeof(decimal), "decimal" },
                { typeof(double), "double" },
                { typeof(float), "float" },
                { typeof(int), "int" },
                { typeof(long), "long" },
                { typeof(object), "object" },
                { typeof(sbyte), "sbyte" },
                { typeof(short), "short" },
                { typeof(string), "string" },
                { typeof(uint), "uint" },
                { typeof(ulong), "ulong" },
                { typeof(void), "void" }
            };

            if (types.ContainsKey(type))
            {
                return types[type];
            }

            return type.Name;
        }

        public static int IndexOfNth(this string str, string value, int nth = 0)
        {
            if (nth < 0)
            {
                throw new ArgumentException("Can not find a negative index of substring in string. Must start with 0");
            }

            int offset = str.IndexOf(value);
            for (int i = 0; i < nth; i++)
            {
                if (offset == -1)
                {
                    return -1;
                }

                offset = str.IndexOf(value, offset + 1);
            }

            return offset;
        }

    }
}