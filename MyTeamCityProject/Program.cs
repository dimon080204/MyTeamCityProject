using System;

namespace MyTeamCityProject
{
    public class Program
    {
        public static string SayHello(string name)
        {
            return $"Hello, {name}!";
        }

        public static int CountYourAge(int birthYear)
        {
            int currentYear = DateTime.Now.Year;
            return currentYear - birthYear;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(SayHello("TeamCity"));
            Console.Write("Write your name: ");
            string enteredName = Console.ReadLine();
            Console.WriteLine(SayHello(enteredName));
            Console.Write("Enter your birth year: ");
            try
            {
                int birthYear = int.Parse(Console.ReadLine() ?? "0");
                int age = CountYourAge(birthYear);
                Console.WriteLine($"You are {age} years old.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input for birth year.");
            }
        }
    }
}