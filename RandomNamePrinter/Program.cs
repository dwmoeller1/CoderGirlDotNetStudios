using System;

namespace RandomNamePrinter
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfNames = 30;
            string[] names = new string[numberOfNames];
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
            int randomInt = new Random().Next(0, numberOfNames);
            string nameWinner = names[randomInt];
            Console.WriteLine($"The winner is:{nameWinner}");

            Console.WriteLine("The other names are:");
            for(int i=0; i< numberOfNames;i++)
            {
                if (i != randomInt)
                {
                    Console.WriteLine(names[i]);
                }
            }

            Console.ReadLine();
        }
    }
}
