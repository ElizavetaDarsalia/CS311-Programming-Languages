using System;

class Exercise3
{
    static void Main()
    {
        Console.Write("Enter number you want: ");
        string input = Console.ReadLine();
        int N;

        if (!int.TryParse(input, out N) || N <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
            return;
        }

        string result = "";

        for (int i = 1; i <= N; i++)
        {
            if (i % 15 == 0)
                result += "FizzBuzz ";
            else if (i % 3 == 0)
                result += "Fizz ";
            else if (i % 5 == 0)
                result += "Buzz ";
            else
                result += i + " ";
        }

        Console.WriteLine(result.Trim());
    }
}
