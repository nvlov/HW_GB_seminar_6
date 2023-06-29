/*Задача 41: 
Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

using System;

class Program
{
    static void Main()
    {
        Console.Clear();
		Console.WriteLine("Enter numbers separated by spaces:");
        string input = Console.ReadLine();

        string[] numbers = input.Split(' ');

        int positiveCount = 0;

        foreach (string number in numbers)
        {
            int value;
            if (int.TryParse(number, out value) && value > 0)
            {
                positiveCount++;
            }
        }

        Console.WriteLine($"The number of positive values entered: {positiveCount}");
    }
}

