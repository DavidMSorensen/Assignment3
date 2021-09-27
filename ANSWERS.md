# Answers

## C&#35;

1. public static IEnumerable<int> Flatten(this IEnumerable<int>[] xs) => xs.SelectMany(i => i);

2. public static IEnumerable<int> FilterBy7and42(this int[] ys) => ys.Where(i => i > 42).Where(i => i % 7 == 0);
  
3. public static IEnumerable<int> FilterLeapYears(this int[] ys) => ys.Where(i => DateTime.IsLeapYear(i));
