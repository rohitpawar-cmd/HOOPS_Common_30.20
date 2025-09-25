using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;

namespace Hexagon.ALI.Analysis.Common.Enums
{
    [ExcludeFromCodeCoverage]
    public static class Extensions
    {
        public static bool TryAdd<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, TValue value)
        {
            if (dictionary == null)
            {
                throw new ArgumentNullException(nameof(dictionary));
            }

            if (!dictionary.ContainsKey(key))
            {
                dictionary.Add(key, value);
                return true;
            }

            return false;
        }
    }
    public class SIOEnum
    {
        private static ConcurrentDictionary<string, SIOEnum> sioEnumUoM;

        public static ConcurrentDictionary<string, string> dict = new ConcurrentDictionary<string, string>();

        public string UID
        {
            get; private set;
        }

        public string Text
        {
            get; private set;
        }

        public string Description
        {
            get; private set;
        }

        public double Number
        {
            get; private set;
        }

        public double Constant
        {
            get; internal set;
        } = 0;

        public string SIO_Type
        {
            // S3D supports this format when exporting their data, 
            // so it makes sense to adopt a similar approach.
            get => $"#{Number}";
        }

        public SIOEnum(string uid, string text, string description, double number, double constant = 0)
        {
            UID = uid;
            Text = text;
            Description = description;
            Number = number;
            Constant = constant;
        }

        protected static ConcurrentDictionary<string, SIOEnum> SIOEnumUoM
        {
            get
            {
                if (sioEnumUoM == null)
                {
                    sioEnumUoM = new ConcurrentDictionary<string, SIOEnum>();
                }
                return sioEnumUoM;
            }
        }
        private static SIOEnum Find(string type, string textOrUIDOrNumber, bool byText, bool byNumber)
        {
            lock (SIOEnumUoM)
            {
                string key = $"{type}.{textOrUIDOrNumber}".ToLowerInvariant();

                if (!SIOEnumUoM.ContainsKey(key))
                {
                    Type t = Type.GetType($"Hexagon.ALI.Analysis.Common.Enums.{type}");
                    if (t == null)
                    {
                        return null;
                    }
                    if (!t.GetFields().Any())
                    {
                        t = t.BaseType;
                    }

                    foreach (FieldInfo constant in t.GetFields())
                    {
                        if (!constant.IsLiteral && constant.IsInitOnly)
                        {
                            SIOEnum sioEnum = constant.GetValue(null) as SIOEnum;
                            if (string.Equals(byText ? sioEnum.Text : byNumber ? sioEnum.Number.ToString() : sioEnum.UID,
                                textOrUIDOrNumber, System.StringComparison.InvariantCultureIgnoreCase))
                            {
                                SIOEnumUoM.TryAdd(key, sioEnum);
                                return sioEnum;
                            }
                        }
                    }
                }
                else if (SIOEnumUoM.TryGetValue(key, out SIOEnum sioEnum))
                {
                    return sioEnum;
                }

                return null;
            }
        }
        public static SIOEnum FindByTypeAndID(string type, string id)
        {
            return Find(type, id, false, false);
        }
        public static SIOEnum FindByTypeAndText(string type, string text)
        {
            return Find(type, text, true, false);
        }

        public static SIOEnum FindByTypeAndNumber(string type, string number)
        {
            return Find(type, number, false, true);
        }
        public static List<SIOEnum> FindByType(string type)
        {
            Type t = Type.GetType($"Hexagon.ALI.Analysis.Common.Enums.{type}");
            if (t == null)
            {
                return null;
            }
            List<SIOEnum> list = new List<SIOEnum>();
            foreach (var constant in t.GetFields())
            {
                if (!constant.IsLiteral && constant.IsInitOnly)
                {
                    var item = constant.GetValue(null) as SIOEnum;
                    list.Add(item);
                }
            }
            if (!list.Any())
            {
                foreach (var constant in t.BaseType.GetFields())
                {
                    if (!constant.IsLiteral && constant.IsInitOnly)
                    {
                        var item = constant.GetValue(null) as SIOEnum;
                        list.Add(item);
                    }
                }
            }
            return list;
        }

    }
}