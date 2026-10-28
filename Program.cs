// задание 1
// PrintHeader("заголовок 1");
// Console.WriteLine();
// PrintHeader("заголовок 2");
// static void PrintLine() 
// {
//     Console.WriteLine("(^_^) (^_^) (^_^) (^_^)");
// }
// static void PrintHeader(string title)
// {
//     PrintLine();
//     Console.WriteLine($"{title}");
//     PrintLine();
// }
// задание 2.1 и 2.2
// int max1 = Max(10, 20);
// Console.WriteLine(max1);
// int max2 = Max(-5, -15);
// Console.WriteLine(max2);
// Console.WriteLine();
// Console.WriteLine(IsEven(4));
// Console.WriteLine(IsEven(7));
// Console.WriteLine(IsEven(0));
// static int Max(int a, int b)
// {
//     if (a > b)
//     {
//         return a;
//     }
//     return b;
// }
// static bool IsEven(int n)
// {
//     return n % 2 == 0;
// }
// задание 3
// int[] arr = { 120, 45, 300, 80, 15, 210 };
// Console.WriteLine(Average(arr));
// Console.WriteLine(CountGreater(arr, 100));
// static double Average(int[] arr)
// {
//     double sum = 0;
//     foreach (int x in arr)
//     {
//         sum += x;
//     }
//     return sum / arr.Length;
// }
// static int CountGreater(int[] arr, int limit)
// {
//     int с = 0;
//     foreach (int x in arr)
//     {
//         if (x > limit)
//         {
//             с++;
//         }
//     }
//     return с;
// }
// задание 4
// double c1 = 0;
// Console.WriteLine($"{c1} °C = {ToFahrenheit(c1)} °F");
// double c2 = 100;
// Console.WriteLine($"{c2} °C = {ToFahrenheit(c2)} °F");
// double c3 = 37;
// Console.WriteLine($"{c3} °C = {ToFahrenheit(c3)} °F");
// static double ToFahrenheit(double celsius)
// {
//     return celsius * 9 / 5 + 32;
// }
// задание 5
// Console.WriteLine($"Factorial(5) = {Factorial(5)}");
// for (int i = 2; i <= 50; i++)
// {
//     if (IsPrime(i))
//     {
//         Console.Write(i + " ");
//     }
// }
// static int Factorial(int n)
// {
//     int с = 1;
//     for (int i = 1; i <= n; i++)
//     {
//         с *= i;
//     }
//     return с;
// }
// static bool IsPrime(int n)
// {
//     for (int i = 2; i * i <= n; i++)
//     {
//         if (n % i == 0) return false;
//     }
//     return true;
// }

