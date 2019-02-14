using System;

namespace TipCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What was your bill amount?");
            string billInput = Console.ReadLine();

            billInput = billInput.Trim().Trim('$');
            double bill;
            if (!double.TryParse(billInput, out bill))
            {
                Console.WriteLine($"The value {billInput} is not a valid bill amount.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("What percent would you like to tip?");
            string tipPercentInput = Console.ReadLine();

            tipPercentInput = tipPercentInput.Trim().Trim('%');
            double tipPercent;
            if (!double.TryParse(tipPercentInput, out tipPercent))
            {
                Console.WriteLine($"The value {tipPercentInput} is not a valid tip.");
            }

            double tipAmount = Math.Round(tipPercent * bill / 100, 2);
            double totalBill = Math.Round(bill + tipAmount, 2);

            Console.WriteLine($"You tip amount is ${tipAmount}.");
            Console.WriteLine($"Your total bill ${totalBill}.");

            Console.ReadLine();
        }
    }
}
