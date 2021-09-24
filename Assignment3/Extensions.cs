using System;
using System.Collections.Generic;
using System.Linq;

namespace BDSA2020.Assignment02
{
    public static class Extensions
    {
        public static IEnumerable<int> Flatten(this IEnumerable<int>[] xs) => xs.SelectMany(i => i);
    }
}
