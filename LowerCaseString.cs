using System;

class Program
{
    static void Main()
    {
        string originalString = "Hello, World!";
        char[] charArray = originalString.ToCharArray();

        for (int i = 0; i < charArray.Length; i++)
        {
            if (charArray[i] >= 'A' && charArray[i] <= 'Z')
            {
                // Преобразование в строчную букву
                charArray[i] = (char)(charArray[i] - 'A' + 'a');
            }
        }

        string lowerCaseString = new string(charArray);

        Console.WriteLine("Original String: " + originalString);
        Console.WriteLine("Lower Case String: " + lowerCaseString);
    }
}