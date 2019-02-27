using System;

namespace TipCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal bill = 0;
            decimal tipPercent = 0;
            //This is a typical way of doing a while loop when there is only one logical way to exit the loop 
            //(ie. getting a parsable input), and you are ok with looping forever till that condition is met.
            //Notice that I did a seperate loop for each entry. Why that instead of one loop for both entries?
            while (true)
            {
                Console.WriteLine("What was your bill amount?");
                string billInput = Console.ReadLine();

                billInput = billInput.Trim().Trim('$');

                if (decimal.TryParse(billInput, out bill))
                {                    
                    break;
                }

                Console.WriteLine($"The value {billInput} is not a valid bill amount. Please try again.");
            }

            while (true)
            { 
                Console.WriteLine("What percent would you like to tip?");
                string tipPercentInput = Console.ReadLine();
                tipPercentInput = tipPercentInput.Trim().Trim('%');

                if (decimal.TryParse(tipPercentInput, out tipPercent))
                {
                    break;
                }

                Console.WriteLine($"The value {tipPercentInput} is not a valid tip. Please try again.");
            }

            decimal tipAmount = Math.Round(tipPercent * bill / 100, 2);
            decimal totalBill = Math.Round(bill + tipAmount, 2);

            Console.WriteLine($"You tip amount is ${tipAmount}.");
            Console.WriteLine($"Your total bill ${totalBill}.");

            Console.ReadLine();
        }
    }
}
