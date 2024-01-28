using System;

class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5 }; // Example array
        Console.WriteLine("Original array:");
        Console.WriteLine(string.Join(", ", array));

        ReverseArray(array);

        Console.WriteLine("Reversed array:");
        Console.WriteLine(string.Join(", ", array));
    }

    // Method to reverse the array
    static void ReverseArray(int[] array)
    {
        int temp;
        int n = array.Length;
        for (int i = 0; i < n / 2; i++)
        {
            temp = array[i];
            array[i] = array[n - i - 1];
            array[n - i - 1] = temp;
        }
    }
}
