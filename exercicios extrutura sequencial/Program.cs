using System;
using System.Globalization;

public class Program
{
    public static void Main()
    {
        double pi = 3.14159;
        double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double area;

        area = pi * (raio * raio);

        Console.WriteLine(area.ToString("F4", CultureInfo.InvariantCulture));
    }
}