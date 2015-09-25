using System;

    class PrimeNumberCheck
    {
        static void Main()
        {
        int n = int.Parse(Console.ReadLine());
        int result1 = n % 2;
        int result2 = n % 3;
        int result3 = n % 5;
        int result4 = n % 7;
        if (result1 == 0 || result2 == 0 || result3 == 0 || result4 == 0)
        {
            Console.WriteLine(false);
        }
        else
        {
            Console.WriteLine(true);
        }
        }
    }

