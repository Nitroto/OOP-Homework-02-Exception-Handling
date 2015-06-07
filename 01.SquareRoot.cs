using System;

/// Write a program that reads an integer number and calculates and prints its square root. If the number is invalid or negative, 
/// print "Invalid number". In all cases finally print "Good bye". Use try-catch-finally.

class SquareRoot
{
    static void Main()
    {
        CalculateSquareRoot();
    }

    public static void CalculateSquareRoot()
    {
        try
        {
            int number = int.Parse(Console.ReadLine());
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException("number", "Number shoud be positive integer number!");
            }
            Console.WriteLine("Square root of {0} is {1}", number, Math.Sqrt(number));
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number!");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Invalid number!");
        }
        finally
        {
            Console.WriteLine("Good bye!");
        }
    }
}
