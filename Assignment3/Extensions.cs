using System;
using System.Collections.Generic;
using System.Linq;

namespace BDSA2020.Assignment02
{
    public static class Extensions
    {
        public static IEnumerable<int> Flatten(this IEnumerable<int>[] xs) => xs.SelectMany(i => i);

        public static IEnumerable<int> FilterBy7and42(this int[] ys) => ys.Where(i => i > 42).Where(i => i % 7 == 0);

        public static bool IsSecure(this Uri u) => u.ToString().Contains("https");
    }
}
