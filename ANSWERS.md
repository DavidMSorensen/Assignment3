# Answers

## C&#35;

### Extension Methods

1. public static IEnumerable<int> Flatten(this IEnumerable<int>[] xs) => xs.SelectMany(i => i);

2. public static IEnumerable<int> FilterBy7and42(this int[] ys) => ys.Where(i => i > 42).Where(i => i % 7 == 0);

3. public static IEnumerable<int> FilterLeapYears(this int[] ys) => ys.Where(i => DateTime.IsLeapYear(i));

### Delegates Delegates / Anonymous methods

1. Func<string, string> Reverse = delegate (string s) { return new string(s.Reverse().ToArray()); };

2. Func<int, int, int> Multiply = delegate (int a, int b) {return a * b; };

3. Func<string, int, bool> NumericCheck = delegate (string s, int i) {return int.Parse(s) == i; };
