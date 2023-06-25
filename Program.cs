using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter value for x: ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Enter value for y: ");
        double y = double.Parse(Console.ReadLine());

        double result = CalculateFunction(x, y);
        Console.WriteLine("The result of the function is: {0}", result);

        Console.ReadKey();
    }

    static double CalculateFunction(double x, double y)
    {
        double temp = Math.Abs(x) + Math.Sqrt(x);

        return Math.Sqrt(temp) + y;
    }
}