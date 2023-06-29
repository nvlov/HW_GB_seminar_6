/*Задача 43: 
Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

using System;

class Program
{
    static void Main()
    {
        Console.Clear();
		Console.WriteLine("Enter the values for Line 1 (y = k1 * x + b1):");
        double k1 = ReadDouble("k1");
        double b1 = ReadDouble("b1");

        Console.WriteLine("Enter the values for Line 2 (y = k2 * x + b2):");
        double k2 = ReadDouble("k2");
        double b2 = ReadDouble("b2");

        double xIntersection = (b2 - b1) / (k1 - k2);
        double yIntersection = k1 * xIntersection + b1;

        Console.WriteLine("The intersection point is: ({0}, {1})", xIntersection, yIntersection);
    }

    static double ReadDouble(string variableName)
    {
        Console.Write($"Enter {variableName}: ");
        return double.Parse(Console.ReadLine()!);
    }
}
