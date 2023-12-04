using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число для вычисления факториала: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Обчислення факторіалу числа
        long factorial = 1;

        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }

        // Виведення результату
        Console.WriteLine($"Факториал числа {number}: {factorial}");
    }
}