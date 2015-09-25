using System;

    class ExtractBitFromInteger
    {
        static void Main()
        {
        int n = int.Parse(Console.ReadLine());
        int a = int.Parse(Console.ReadLine());
        int nRight = n >> a;
        int bit = nRight & 1;
        Console.WriteLine(bit);
        }
    }

