using System;
using System.Collections.Generic;
using System.Collections;

namespace LaunchScrabble
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a your list of words. Separate each with a comma.");
            string userInput = Console.ReadLine();
            string[] wordArray = userInput.Trim().ToLower().Split(",");
            int score = GetScore(wordArray);

            Console.WriteLine($"You scored {score} points");

            Console.ReadLine();
        }

        public static int GetScore(string[] wordArray)
        {
            int score = 0;
            for(int i = 0; i< wordArray.Length; i++)
            {
                string wordToScore = wordArray[i].Trim();
                if(wordToScore[0] == 'q')
                {
                    if (wordToScore.Length < 2 || wordToScore[1] != 'u')
                        return 0;
                    else
                        score += 10;
                }
                else
                {
                    score++;
                }
            }

            return score;
        }
    }
}
