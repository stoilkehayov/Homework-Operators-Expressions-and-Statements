using System;

    class BitwiseExtractBit
    {
        static void Main()
        {
        Console.WriteLine("Enter the integer number:");
        int n = int.Parse(Console.ReadLine());
        int a = 3;
        int nRight = n >> a;
        int bit = nRight & 1;
        Console.WriteLine(bit);
        }
    }

