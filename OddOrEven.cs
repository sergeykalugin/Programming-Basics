using System;

class Program
{
    static void Main()
    {
        // Continuously ask for integer input
        while (true)
        {
            Console.WriteLine("Enter an integer or 'q' to exit:");
            string input = Console.ReadLine();

            // Check if the input is 'q' to exit the program
            if (input == "q")
            {
                break;
            }

            int number;
            bool isNumeric = int.TryParse(input, out number);

            // Validate if the input is a number
            if (!isNumeric)
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            // Check if the sum of digits is even and exit if true
            if (IsSumOfDigitsEven(number))
            {
                Console.WriteLine($"The sum of the digits of {number} is even. Exiting program.");
                break;
            }
            else { 
                Console.WriteLine($"The sum of the digits of {number} is odd. Continue");
                continue;
            }
                
        }
    }

    // Method to check if the sum of digits of a number is even
    static bool IsSumOfDigitsEven(int number)
    {
        int sum = 0;
        // Loop through each digit of the number
        while (number > 0)
        {
            sum += number % 10; // Add the last digit to sum
            number /= 10; // Remove the last digit
        }

        // Return true if the sum is even
        return sum % 2 == 0;
    }
}
