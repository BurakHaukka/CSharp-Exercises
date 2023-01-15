//Five judges are used in hill jumping.
//Write a program that asks rating points for one jump and prints the sum of the style points
//such that the smallest and largest style point has been subtracted from the sum.
//Save the given numbers to the list. Check that the given input is a number.

using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        int judge1;
        int judge2;
        int judge3;
        int judge4;
        int judge5;
        List<int> JudgeScores = new List<int>();

        Console.WriteLine("Rating of Judge 1 (Only numbers!!): ");
        JudgeScores.Add(judge1 = Convert.ToInt32(Console.ReadLine()));

        Console.WriteLine("Rating of Judge 2 (Only numbers!!): ");
        JudgeScores.Add(judge2 = Convert.ToInt32(Console.ReadLine()));

        Console.WriteLine("Rating of Judge 3 (Only numbers!!): ");
        JudgeScores.Add(judge3 = Convert.ToInt32(Console.ReadLine()));

        Console.WriteLine("Rating of Judge 4 (Only numbers!!): ");
        JudgeScores.Add(judge4 = Convert.ToInt32(Console.ReadLine()));

        Console.WriteLine("Rating of Judge 5 (Only numbers!!): ");
        JudgeScores.Add(judge5 = Convert.ToInt32(Console.ReadLine()));
        Console.WriteLine();

        JudgeScores.Remove(JudgeScores.Min());
        JudgeScores.Remove(JudgeScores.Max());
        Console.WriteLine("Judges' scores after after minimum and maximum scores removed:");
        for (int i = 0; i < JudgeScores.Count; i++)
        {
            Console.WriteLine(JudgeScores[i]);
            
        }
        Console.WriteLine();
        Console.WriteLine("\nTotal Points are:");
        Console.WriteLine(JudgeScores.Sum());

    }
}