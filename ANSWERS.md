# Answers

## C&#35;

1. Flatten the numbers in `xs`.
  public static IEnumerable<int> Flatten(this IEnumerable<int>[] xs) => xs.SelectMany(i => i);

2. Select numbers in `ys` which are divisible by `7` and greater than `42`.
  public static IEnumerable<int> FilterBy7and42(this int[] ys) => ys.Where(i => i > 42).Where(i => i % 7 == 0);
  
3. Select numbers in `ys` which are *leap years*. 
  public static IEnumerable<int> FilterLeapYears(this int[] ys) => ys.Where(i => DateTime.IsLeapYear(i));
