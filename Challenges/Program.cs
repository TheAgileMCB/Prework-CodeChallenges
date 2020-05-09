using System;

namespace Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            // array of int and user int
            int[] numbers = new int[5];

            // request 5 int from 1-10
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Please enter a number from 1 - 10.");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            // output the array of 5 int
            Console.WriteLine(string.Join(",", numbers));

            // user selects 1
            Console.WriteLine("Now, choose one these values.");
            int userValue = int.Parse(Console.ReadLine());

            int result = ScoreCalculator(userValue, numbers);

            // output "score"
            Console.WriteLine($"Your score is {result}");

            // compose readme

        }

        // score = int * frequency of int
        static int ScoreCalculator(int userValue, int[] numbers)
        {
            int scoreCounter = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (userValue == numbers[i])
                {
                    scoreCounter++;
                }
            }

            int result = userValue * scoreCounter;
            return result;
        }
    }
}
