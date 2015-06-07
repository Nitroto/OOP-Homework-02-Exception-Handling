using System;

/// Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. If an invalid number or 
/// non-number text is entered, the method should throw an exception. Using this method write a program that enters 10 numbers: 
/// a1, a2, … a10, such that 1 < a1 < … < a10 < 100. If the user enters an invalid number, let the user to enter again.

class EnterNumbers
{
    static void Main()
    {
        int start = 1;
        int end = 100;
        int[] numbers = new int[10];


        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = ReadNumber(start+1, end-(numbers.Length-i));
            start = numbers[i];
        }
        Console.WriteLine("Your numbers are:");
        Console.WriteLine(string.Join(",", numbers));

    }
    private static int ReadNumber(int start, int end)
    {
        try
        {
            string userInput = Console.ReadLine();
            int num;
            bool successfullyParsed = int.TryParse(userInput, out num);
            if (!successfullyParsed || num < start || num > end)
            {
                throw new ArgumentException("num", "Invalid number!");
            }
            return num;
        }
        catch (ArgumentException)
        {
            Console.WriteLine("You have entered an incorrect number. Please enter a new number.");
            return ReadNumber(start, end);
        }
    }
}
