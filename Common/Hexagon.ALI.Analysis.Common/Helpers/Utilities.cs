using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace Hexagon.ALI.Analysis.Common.Helpers
{

    public static class Utilities
    {
        [ExcludeFromCodeCoverage]
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> enumerable)
        {
            if (enumerable != null)
            {
                return !enumerable.Any();
            }

            return true;
        }
        [ExcludeFromCodeCoverage]
        public static IEnumerable<IEnumerable<T>> ChunkBatchSize<T>(this IEnumerable<T> source, int chunksize)
        {
            while (source.Any())
            {
                yield return source.Take(chunksize);
                source = source.Skip(chunksize);
            }
        }
        [ExcludeFromCodeCoverage]
        public static IEnumerable<IEnumerable<T>> ChunkNumberOfBatches<T>(this IEnumerable<T> source, int chunkNumber)
        {

            return SplitIntoSublists(source, chunkNumber);
        }
        [ExcludeFromCodeCoverage]
        public static IEnumerable<IEnumerable<T>> SplitIntoSublists<T>(IEnumerable<T> source, int numSublists)
        {
            var sublists = new List<List<T>>(numSublists);

            for (int i = 0; i < numSublists; i++)
            {
                sublists.Add(new List<T>());
            }

            int index = 0;

            foreach (var item in source)
            {
                sublists[index % numSublists].Add(item);
                index++;
            }

            foreach (var sublist in sublists)
            {
                yield return sublist;
            }
        }

        [ExcludeFromCodeCoverage]
        /// <summary>
        /// Helper method to create SecureString from string
        /// </summary>
        /// <param name="s">SecureString variable</param>
        /// <param name="str">String to add to SecureString</param>
        public static void Append(this SecureString s, string str)
        {
            foreach (char ch in str)
            {
                s.AppendChar(ch);
            }
        }
        [ExcludeFromCodeCoverage]
        /// <summary>
        /// Create SecureString from provided string
        /// </summary>
        /// <param name="str">String to secure</param>
        /// <returns>SecureString</returns>
        public static SecureString StringToSecureString(string str)
        {
            SecureString secure = new SecureString();
            Append(secure, str);
            return secure;
        }
        [ExcludeFromCodeCoverage]
        /// <summary>
        /// Produce string from SecureString value
        /// </summary>
        /// <param name="value">SecureString to unsecure</param>
        /// <returns>SecureString as plain text</returns>
        public static string SecureStringToString(SecureString value)
        {
            if (value != null)
            {
                IntPtr valuePtr = IntPtr.Zero;
                try
                {
                    valuePtr = Marshal.SecureStringToGlobalAllocUnicode(value);
                    return Marshal.PtrToStringUni(valuePtr);
                }
                finally
                {
                    Marshal.ZeroFreeGlobalAllocUnicode(valuePtr);
                }
            }
            return null;
        }
        [ExcludeFromCodeCoverage]
        /// <summary>
		/// Encode string to base64
		/// </summary>
		/// <param name="str">String value to encode to base64</param>
		/// <returns>Base64 encoded string</returns>
		public static string Base64Encode(string str)
        {
            byte[] data = Encoding.ASCII.GetBytes(str);
            return Convert.ToBase64String(data);
        }
        [ExcludeFromCodeCoverage]
        public static string SplitString(string stringToSplit)
        {
            if (string.IsNullOrWhiteSpace(stringToSplit))
            {
                return "0";
            }
            string[] array = stringToSplit.Split(' ');
            return array[0];
        }
    }
    [ExcludeFromCodeCoverage]
    public class IncorrectSiValueException : Exception
    {
        public IncorrectSiValueException(string msg) : base(msg)
        {

        }
    }
    [ExcludeFromCodeCoverage]
    [AttributeUsage(AttributeTargets.Property)]
    public class PPMPropertyAttribute : Attribute
    {
        public string prop;
        public string inf;

        public PPMPropertyAttribute(string ppmproperty, string ppminterface)
        {
            this.prop = ppmproperty;
            this.inf = ppminterface;
        }
    }
    [ExcludeFromCodeCoverage]
    [AttributeUsage(AttributeTargets.Property)]
    public class RelDefAttribute : Attribute
    {
        public string relDef;
        public bool minEnd1 = false;
        public bool minEnd2 = false;
        public bool isBackward = false;
        public string relDefWebApi = null;

        public RelDefAttribute(string relDefName, bool minEnd1 = false, bool minEnd2 = false, string relDefNameWebApi = null, bool isBackwardsRel = false)
        {
            this.relDef = relDefName;
            this.relDefWebApi = relDefNameWebApi;
            this.minEnd1 = minEnd1;
            this.minEnd2 = minEnd2;
            isBackward = isBackwardsRel;
        }
        public RelDefAttribute() //For Backward Relation
        {
            isBackward = true;
        }
    }

    [AttributeUsage(AttributeTargets.Class)]
    [ExcludeFromCodeCoverage]
    public class DefUIDAttribute : Attribute
    {
        public string defUID;

        public DefUIDAttribute(string DefUID)
        {
            this.defUID = DefUID;
            //this.entityType = (EntityType)Enum.Parse(typeof(EntityType), DefUID);
        }
    }
    [ExcludeFromCodeCoverage]
    [AttributeUsage(AttributeTargets.Property)]
    public class UoMAttribute : Attribute
    {
        public string uomtype;
        public string uomtype2;
        public UoMAttribute(string uom, string uom2 = null)
        {
            this.uomtype = uom;
            this.uomtype2 = uom2;
        }
    }

}