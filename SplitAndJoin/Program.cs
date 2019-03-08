using System;

namespace SplitAndJoin
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 33, 3, 6, 2 };
            string output = String.Join(",", numbers);
            Console.WriteLine(output);

            string someNumberString = "23,64,33,9,101";
            string[] someStringArrayOfNumbers = someNumberString.Split(',');
            int[] someArrayOfInts = new int[someNumberString.Length];
            for (int i = 0; i < someStringArrayOfNumbers.Length; i++)
            {
                int number = Convert.ToInt32(someStringArrayOfNumbers[i]);
                someArrayOfInts[i] = number;
            }

            Console.ReadLine();
        }
    }
}
