using System;
public class Program
{
    static void Main()
    {
        Console.WriteLine("Программа для нахождения периметра, полупериметра и площади треугольника по трём его сторонам");
        try
        {
            Console.Write("Введите длину стороны a: ");
            double a = double.Parse(Console.Readline());
            Console.Write("Введите длину стороны b: ");
            double b = double.Parse(Console.Readline());
            Console.Write("Введите длину стороны c: ");
            double c = double.Parse(Console.Readline());
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка, введите числовые значения для сторон треугольника");
        }
    }

public static double CalculateTriangleArea(double a, double b, double c)
    {
        try
        {
            Console.Write("Введите длину стороны a: ");
            double a = double.Parse(Console.Readline());
            Console.Write("Введите длину стороны b: ");
            double b = double.Parse(Console.Readline());
            Console.Write("Введите длину стороны c: ");
            double c = double.Parse(Console.Readline());
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка, введите числовые значения для сторон треугольника");
        }
    }
}

