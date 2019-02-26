using System;

namespace TipCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double bill = 0;
            double tipPercent = 0;

            //Here is how you might do it if you only wanted to give them a limited amount of retries
            int retries = 0;
            int maxRetries = 5;
            while (retries < maxRetries)
            {
                Console.WriteLine("What was your bill amount?");
                string billInput = Console.ReadLine();

                billInput = billInput.Trim().Trim('$');

                if (double.TryParse(billInput, out bill))
                {                    
                    break;
                }

                retries++;
                if(retries < maxRetries)
                {
                    Console.WriteLine($"The value {billInput} is not a valid bill amount. Please try again.");            
                }
                else
                {
                    Console.WriteLine("You have reached the max number of retries.");
                }
            }

            retries = 0;
            while (retries < maxRetries)
            { 
                Console.WriteLine("What percent would you like to tip?");
                string tipPercentInput = Console.ReadLine();
                tipPercentInput = tipPercentInput.Trim().Trim('%');

                if (double.TryParse(tipPercentInput, out tipPercent))
                {
                    break;
                }

                retries++;
                if (retries < maxRetries)
                {
                    Console.WriteLine($"The value {tipPercentInput} is not a valid tip. Please try again.");
                }
                else
                {
                    Console.WriteLine("You have reached the max number of retries.");
                }
            }

            double tipAmount = Math.Round(tipPercent * bill / 100, 2);
            double totalBill = Math.Round(bill + tipAmount, 2);

            Console.WriteLine($"You tip amount is ${tipAmount}.");
            Console.WriteLine($"Your total bill ${totalBill}.");

            Console.ReadLine();
        }
    }
}
