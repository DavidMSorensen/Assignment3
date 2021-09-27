using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace BDSA2020.Assignment02
{
    public static class Extensions
    {
        public static IEnumerable<int> Flatten(this IEnumerable<int>[] xs) => xs.SelectMany(i => i);

        public static IEnumerable<int> FilterBy7and42(this int[] ys) => ys.Where(i => i > 42).Where(i => i % 7 == 0);

        public static IEnumerable<int> FilterLeapYears(this int[] ys) => ys.Where(i => DateTime.IsLeapYear(i));

        public static bool IsSecure(this Uri u) => u.ToString().Contains("https");

        public static int WordCount(this string s)
        {  
            int numberOfWords = 0;
            string pattern = "[^a-zA-Z_]+";
            var words = Regex.Split(s," ");
            Regex reg = new Regex(pattern);
            bool containsIllegalSymbol = false;

            foreach(var word in words)
            {
                containsIllegalSymbol = reg.IsMatch(word);
                
                if (!containsIllegalSymbol)
                {
                    numberOfWords= numberOfWords + 1;
                }
            }

            return numberOfWords;

        }
        

    }
}
