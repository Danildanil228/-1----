using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите координаты вершин четырехугольника:");
        Console.Write("x1 = ");
        double x1 = double.Parse(Console.ReadLine());
        Console.Write("y1 = ");
        double y1 = double.Parse(Console.ReadLine());
        Console.Write("x2 = ");
        double x2 = double.Parse(Console.ReadLine());
        Console.Write("y2 = ");
        double y2 = double.Parse(Console.ReadLine());
        Console.Write("x3 = ");
        double x3 = double.Parse(Console.ReadLine());
        Console.Write("y3 = ");
        double y3 = double.Parse(Console.ReadLine());
        Console.Write("x4 = ");
        double x4 = double.Parse(Console.ReadLine());
        Console.Write("y4 = ");
        double y4 = double.Parse(Console.ReadLine());
        double s1 = Distance(x1, y1, x2, y2);
        double s2 = Distance(x2, y2, x3, y3);
        double s3 = Distance(x3, y3, x4, y4);
        double s4 = Distance(x4, y4, x1, y1);
        double p = s1 + s2 + s3 + s4;
        Console.WriteLine("Периметр четырехугольника: " + p);
    }
    static double Distance(double x1, double y1, double x2, double y2)
    {
        double dx = x2 - x1;
        double dy = y2 - y1;
        return Math.Sqrt(dx * dx + dy * dy);
    }
}

Console.Write("Введите y: ");
double y = double.Parse(Console.ReadLine());
Console.WriteLine("Введите m: ");
double m = double.Parse(Console.ReadLine());
Double H = (m * m + 2.8 * m + 0.355) / (Math.Cos(2 * y) + 3.6);
Console.WriteLine($"H={H:F2}");