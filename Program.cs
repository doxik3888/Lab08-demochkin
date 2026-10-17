// PrintHeader("Привет");
// int z = Max(4, 5);
// bool x = IsEven(7);
// int w = CountGreater([4, 5, 6, 7, 8], 6);
// double e = Average([4, 5, 6, 7, 8]);
// Console.WriteLine(ToFahrenheit(32));
// Console.WriteLine(ToFahrenheit(212));
// Console.WriteLine(ToFahrenheit(98.6));
// Console.WriteLine(e);
// Console.WriteLine(w);
// Console.WriteLine(z);
// Console.WriteLine(x);
Console.WriteLine("1 - сумма двух чисел");
Console.WriteLine("2 - большее из двух чисел");
Console.WriteLine("3 - факториал");
Console.WriteLine("0 -выход");
string a = Console.ReadLine();
while (a != "0")
{
    if (a == "1")
    {
        Console.WriteLine("Число 1: ");
        int q = int.Parse(Console.ReadLine());
        Console.WriteLine("Число 2: ");
        int w = int.Parse(Console.ReadLine());
        Console.WriteLine($"{w + q}");
    }
    else if (a == "2")
    {
        Console.WriteLine("Число 1: ");
        int q = int.Parse(Console.ReadLine());
        Console.WriteLine("Число 2: ");
        int w = int.Parse(Console.ReadLine());
        Console.WriteLine($"{Max(q, w)}");
    }
    else if (a == "3")
    {
        Console.WriteLine("Число: ");
        int q = int.Parse(Console.ReadLine());
        Console.WriteLine($"{Factorial(q)}");
    }
    else
    {
        Console.WriteLine("Такой команды нет");
    }
    Console.WriteLine("1 - сумма двух чисел");
    Console.WriteLine("2 - большее из двух чисел");
    Console.WriteLine("3 - факториал");
    Console.WriteLine("0 -выход");
    a = Console.ReadLine();
}
// for (int i = 2; i <= 50; i++)
// {
//     if (IsPrime(i))
//     {
//         Console.WriteLine(i);
//     }
// }
static void PrintLine()
{
    Console.WriteLine("^_^");
}

static void PrintHeader(string title)
{
    PrintLine();
    Console.WriteLine($"{title}");
    PrintLine();
}

static int Max(int a, int b)
{
    if (a > b)
    {
        return a;
    }
    else if (b > a)
    {
        return b;
    }
    else
    {
        return a;
    }
}

static bool IsEven(int n)
{
    return n % 2 == 0;
}


static double Average(int[] arr)
{
    double q = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        q += arr[i];
    }
    return q / arr.Length;
}

static  int CountGreater(int[] arr, int limit)
{
    int q = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > limit)
        {
            q++;
        }
    }
    return q;
}

static double ToFahrenheit(double celsius)
{
    double f3 = celsius * 9 / 5 + 32;
    return f3;
}

static long Factorial(int n)
{
    int q = 1;
    for (int i = 1; i <= n; i++)
    {
        q *= i;
    }
    return q;
}

static bool IsPrime(int n)
{
    int q = 0;
    for (int i = 1; i <= n; i++)
    {
        if (n % i == 0)
        {
            q++;
        }
    }
    return q == 2;
}