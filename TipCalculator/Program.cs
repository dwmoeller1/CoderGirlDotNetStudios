using System;

namespace TipCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxRetries = 5;
            decimal bill = GetParsedInput("What was the bill amount?", maxRetries);
            decimal tipPercent = GetParsedInput("What percent would you like to tip?", maxRetries);

            decimal tipAmount = CalculateTipAmount(tipPercent, bill);
            decimal totalBill = CalculateTotalBill(tipAmount, bill);

            Console.WriteLine($"You tip amount is ${tipAmount}.");
            Console.WriteLine($"Your total bill ${totalBill}.");

            Console.ReadLine();
        }

        static void PrintRetryResponse(int retries, int maxRetries, string userInput)
        {
            if (retries < maxRetries)
            {
                Console.WriteLine($"The value {userInput} is not a valid amount. Please try again.");
            }
            else
            {
                Console.WriteLine("You have reached the max number of retries.");
            }
        }

        static decimal GetParsedInput(string prompt, int maxRetries)
        {
            int retries = 0;
            while (retries < maxRetries)
            {
                string inputString = GetInput(prompt);

                if (decimal.TryParse(inputString, out decimal parsedInput))
                {
                    return parsedInput;
                }

                retries++;
                PrintRetryResponse(retries, maxRetries, inputString);
            }
            return 0;
        }

        static string GetInput(string prompt)
        {
            Console.WriteLine(prompt);
            string inputString = Console.ReadLine();
            return inputString.Trim().Trim('%', '$');
        }

        static decimal CalculateTipAmount(decimal tipPercent, decimal bill)
        {
            return Math.Round(tipPercent * bill / 100, 2);
        }

        private static decimal CalculateTotalBill(decimal tipAmount, decimal bill)
        {
           return Math.Round(bill + tipAmount, 2);
        }
    }
}
