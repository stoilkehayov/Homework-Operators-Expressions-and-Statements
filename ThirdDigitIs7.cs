using System;

    class ThirdDigitIs7
    {
        static void Main()
        {
        int n = int.Parse(Console.ReadLine());
        int result = (n / 100) % 10;
        Console.WriteLine(result==7);
        }
    }

