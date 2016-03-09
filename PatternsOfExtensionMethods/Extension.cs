using System;
using System.IO;
using System.Text;

namespace PatternsOfExtensionMethods
{

    public static class ExtensionMethodsPattern
    {
        // Additional metod
        public static StringBuilder AppendFormatLine(this StringBuilder s, string format, params object[] args)
        {
            return s.AppendFormat(format, args).AppendLine();
        }

        // Recursive call
        public static string PathCombine(this string[] paths)
        {
            string res = string.Empty;
            foreach (var path in paths)
            {
                res = Path.Combine(res, path);
            }
            return res;
        }

        // I just like it
        public static DateTime December(this int day, int year)
        {
            return new DateTime(year, 12, day);
        }
    }

    class Extension
    {



        static void Main(string[] args)
        {
            // Addition method
            var sb = new StringBuilder();
            sb.AppendFormatLine("{0} {1}", "Ihor", "Karpachev");


            // Recursive call
            // Instead of
            string a = null, b = null, c = null;
            string res = Path.Combine(a, Path.Combine(b, c));
            // Use
            string[] pats = { "1", "2", "3" };
            string res2 = pats.PathCombine();


            // Andrii's DOB = 13 Dec
            DateTime standartCSharp = new DateTime(1994, 12, 13);
            // Readable Extension 
            DateTime extensionMethod = 13.December(1994);
        }
    }
}
