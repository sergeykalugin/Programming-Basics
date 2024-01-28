/*
//Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число для проверки:");
        int number = Convert.ToInt32(Console.ReadLine());

        if (IsDivisible(number))
        {
            Console.WriteLine($"{number} кратно одновременно 7 и 23.");
        }
        else
        {
            Console.WriteLine($"{number} не кратно одновременно 7 и 23.");
        }
    }

    static bool IsDivisible(int number)
    {
        return number % 7 == 0 && number % 23 == 0;
    }
}
*/

//Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите координату X (не равную 0):");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите координату Y (не равную 0):");
        int y = Convert.ToInt32(Console.ReadLine());

        if (x == 0 || y == 0)
        {
            Console.WriteLine("Ни одна из координат не должна быть равна 0.");
        }
        else
        {
            int quarter = DetermineQuarter(x, y);
            Console.WriteLine($"Точка находится в {quarter} координатной четверти.");
        }
    }

    static int DetermineQuarter(int x, int y)
    {
        if (x > 0 && y > 0)
            return 1;
        if (x < 0 && y > 0)
            return 2;
        if (x < 0 && y < 0)
            return 3;
        if (x > 0 && y < 0)
            return 4;

        // В случае, если хотя бы одна из координат равна 0, возвращаем -1
        return -1;
    }
}

// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите целое число от 10 до 99:");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number < 10 || number > 99)
        {
            Console.WriteLine("Число не находится в диапазоне от 10 до 99.");
        }
        else
        {
            int largestDigit = FindLargestDigit(number);
            Console.WriteLine($"Наибольшая цифра числа {number} - это {largestDigit}.");
        }
    }

    static int FindLargestDigit(int number)
    {
        int digit1 = number / 10; // Первая цифра
        int digit2 = number % 10; // Вторая цифра

        return Math.Max(digit1, digit2);
    }
}

Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите натуральное число:");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number <= 0)
        {
            Console.WriteLine("Число должно быть натуральным (больше нуля).");
        }
        else
        {
            string result = GetDigitsSeparatedByComma(number);
            Console.WriteLine($"Цифры числа {number}: {result}");
        }
    }

    static string GetDigitsSeparatedByComma(int number)
    {
        string numberAsString = number.ToString();
        string result = "";

        int i = 0;
        while (i < numberAsString.Length)
        {
            result += numberAsString[i];
            if (i < numberAsString.Length - 1)
            {
                result += ", ";
            }
            i++;
        }

        return result;
    }
}
