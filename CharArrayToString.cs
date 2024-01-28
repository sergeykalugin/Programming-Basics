using System;

class Program
{
    static void Main()
    {
        char[,] charArray = {
            {'h', 'e', 'l', 'l', 'o'},
            {'w', 'o', 'r', 'l', 'd'}
        };

        string result = ConvertCharArrayToString(charArray);
        Console.WriteLine(result);
    }

    static string ConvertCharArrayToString(char[,] array)
    {
        string result = "";
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                result += array[i, j];
            }
        }
        return result;
    }
}
