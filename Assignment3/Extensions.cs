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
        public static int WordCount(this string s) => Regex.Split(s, @"\P{L}+").Length;

        //Used for testing Queries
        public static void Print<T>(this IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
