using System;

namespace RandomNamePrinter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[30];
            int numberOfNames = 30;
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("Please enter a name:");
                string name = Console.ReadLine();
                if(String.IsNullOrEmpty(name))
                {
                    numberOfNames = i;
                    break;
                }
                names[i] = name;
            }
            int randomInt = new Random().Next(0, numberOfNames - 1);
            string nameWinner = names[randomInt];
            Console.WriteLine($"The winner is:{nameWinner}");


            //list all the of other names that did not win.

            //pause with readline
            Console.ReadLine();
        }
    }
}
