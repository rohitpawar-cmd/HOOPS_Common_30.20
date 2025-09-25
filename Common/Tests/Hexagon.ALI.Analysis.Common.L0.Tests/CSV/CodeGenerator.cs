using Xunit;

namespace Hexagon.ALI.Analysis.Common.Entities.L0.Tests.CSV
{
    public static class CodeGenerator
    {
        /// <summary>
        /// Generates source code for classes and interfaces based off the data in Interfaces.csv and TagTypes.csv.
        /// By default, all classes and interfaces are created. You can limit this by setting filterByName with a 
        /// string that is contained in your desired interface/class name.
        /// The default namespace for classes/interfaces is "Hexagon.ALI.Analysis.Common.Classes|Interfaces.Analysis"
        /// You can set appendToNamespace to append text to the default namespace
        /// Source code will be outputted out to Test Explorer
        /// </summary>
        /// <param name="interfaceData"></param>
        /// <param name="classData"></param>
        /// <param name="filterByName"></param>
        /// <param name="appendToNamespace"></param>
        public static void Generate(Dictionary<string, Dictionary<string, string>> interfaceData, List<KeyValuePair<string, List<string>>> classData, string filterByName = "", string appendToNamespace = "")
        {
            string output = Generate(interfaceData, classData, true, filterByName, appendToNamespace);
            output += Generate(interfaceData, classData, false, filterByName, appendToNamespace);

            Assert.Fail(output);
        }
        static string Generate(Dictionary<string, Dictionary<string, string>> interfaceData, List<KeyValuePair<string, List<string>>> classData, bool bInterface, string filterByName, string appendToNamespace)
        {
            const string t = "    ";
            string separator = "==============================================================\n";
            string output = string.Empty;

            foreach (var kv in interfaceData)
            {
                if (!kv.Key.Contains("IAnalysis"))
                {
                    continue;
                }

                if (filterByName == "" || kv.Key.Contains(filterByName))
                {
                    List<string> interfacesUsed = new List<string>();

                    string topFile = $"\nusing Hexagon.ALI.Analysis.Common.Helpers;\n\nnamespace Hexagon.ALI.Analysis.Common.{(bInterface ? "Interfaces" : "Classes")}.Analysis{(appendToNamespace != "" ? $".{appendToNamespace}" : "")}\n{{";

                    if (bInterface)
                    {
                        if (string.IsNullOrEmpty(output))
                        {
                            output = $"{separator}{topFile}\n{t}public interface {kv.Key}\n{t}{{\n";
                        }
                        else
                        {
                            output += $"\n{separator}{topFile}\n{t}public interface {kv.Key}\n{t}{{\n";
                        }
                    }
                    else
                    {
                        string className = kv.Key.Substring(1);

                        var data = classData.Select(x => x.Value).FirstOrDefault(l => l.Skip(3).Take(1).FirstOrDefault() == className);
                        if (data == null || data.Count == 0)
                        {
                            continue;
                        }

                        string baseClass = GetBaseClass(className, classData);
                        if (baseClass != "")
                        {
                            baseClass = $"{baseClass}, ";
                        }

                        string interfaces = data.Skip(5).Take(1).FirstOrDefault() ?? string.Empty;
                        interfacesUsed.AddRange(interfaces.Split(',', StringSplitOptions.RemoveEmptyEntries));

                        string children = baseClass != "" || interfaces != "" ? $" : {baseClass}{interfaces}" : string.Empty;

                        if (string.IsNullOrEmpty(output))
                        {
                            output = $"{separator}{topFile}\n{t}[DefUID(\"{className}\")]\n{t}public class {className}{children}\n{t}{{\n";
                        }
                        else
                        {
                            output += $"\n{separator}{topFile}\n{t}[DefUID(\"{className}\")]\n{t}public class {className}{children}\n{t}{{\n";
                        }

                        output += $"{t}{t}public {className}() {{ }}\n\n";
                    }

                    List<Dictionary<string, string>> properties = new();
                    properties.Add(kv.Value);

                    foreach (var i in interfacesUsed)
                    {
                        string iName = i.Trim();
                        if (kv.Key == iName || !interfaceData.ContainsKey(iName))
                        {
                            continue;
                        }

                        properties.Add(interfaceData[iName]);
                    }

                    List<string> privateMembers = new();

                    foreach (var dict in properties)
                    {
                        foreach (var (varNam, varTyp) in dict)
                        {
                            string varName = varNam.Trim();
                            string varType = varTyp.Trim();
                            bool bUoM = varType.Contains("UoM");

                            if (varType != "string" && varType != "char" && varType != "byte" && varType != "sbyte" &&
                                varType != "ushort" && varType != "short" && varType != "uint" && varType != "int" &&
                                varType != "ulong" && varType != "long" && varType != "float" && varType != "double" &&
                                varType != "decimal" && varType != "DateTime" && varType != "bool" && !bUoM)
                            {
                                varType = "string";
                            }

                            string prop = $" {{ get; set; }}\n\n";
                            string extraProp = bUoM ? $"{t}{t}double? {varName}SiValue {{ get; }}\n\n" : string.Empty;

                            if (bInterface)
                            {
                                string type = bUoM ? $"{t}{t}string " : $"{t}{t}{varType} ";
                                string attr1 = bUoM ? $"{t}{t}[UoM(\"{varType}\")]\n" : "";
                                string attr2 = $"{t}{t}[PPMProperty(\"{varName}\", \"{kv.Key}\")]\n";
                                string attr = $"{attr1}{attr2}";

                                output += $"{attr}{type}{varName}{prop}{extraProp}";
                            }
                            else
                            {
                                string type = $"{t}{t}public {varType} ";

                                if (bUoM)
                                {
                                    string privName = $"_{varName[0].ToString().ToLowerInvariant()}{varName.Substring(1)}";
                                    type = $"{t}{t}public string ";
                                    prop = $" {{ get => {privName}; set => SetUomValue(value, ref {privName}); }}\n\n";
                                    extraProp = $"{t}{t}public double? {varName}SiValue {{ get; protected set; }}\n\n";

                                    privateMembers.Add($"{t}{t}private string {privName};\n");
                                }
                                output += $"{type}{varName}{prop}{extraProp}";
                            }
                        }
                    }

                    foreach (var priv in privateMembers)
                    {
                        output += priv;
                    }

                    if (string.IsNullOrWhiteSpace(output) == false)
                    {
                        output = $"{output.TrimEnd('\n')}\n{t}}}\n}}\n";
                    }
                }
            }

            return output;
        }

        static string GetBaseClass(string className, List<KeyValuePair<string, List<string>>> classData)
        {
            for (int i = 0; i < classData.Count; ++i)
            {
                if (classData[i].Key == className)
                {
                    int precedence = Convert.ToInt32(classData[i].Value[2]);
                    int j = i - 1;
                    while (j >= 0)
                    {
                        int p = Convert.ToInt32(classData[j].Value[2]);
                        if (p == precedence - 1)
                        {
                            return classData[j].Value[3];
                        }
                        --j;
                    }
                }
            }
            return string.Empty;
        }
    }
}
