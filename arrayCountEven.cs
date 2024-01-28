using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int[] numbers = new int[10]; // Array of 10 three-digit numbers

        // Filling the array with random three-digit numbers
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(100, 1000); // Random numbers from 100 to 999
        }

        // Displaying the numbers in the array
        Console.WriteLine("Array of random three-digit numbers:");
        Console.WriteLine(string.Join(", ", numbers));

        // Counting and displaying the number of even numbers in the array
        int evenCount = CountEvenNumbers(numbers);
        Console.WriteLine($"Number of even numbers in the array: {evenCount}");
    }

    // Method to count the number of even numbers in an array
    static int CountEvenNumbers(int[] array)
    {
        int count = 0;
        foreach (int number in array)
        {
            if (number % 2 == 0)
            {
                count++;
            }
        }
        return count;
    }
}
