using System;

    class DivideBy7and5
    {
        static void Main()
        {
        int n = int.Parse(Console.ReadLine());
        int result1 = n % 5;
        int result2 = n % 7;
        Console.WriteLine(result1 == 0 && result2 == 0);
        }
    }

