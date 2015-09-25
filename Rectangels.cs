using System;

    class Rectangels
    {
        static void Main()
        {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        Console.WriteLine("{0}", 2 * width + 2 * height);
        Console.WriteLine("{0}", width * height);
        }
    }

