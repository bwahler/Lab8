using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 4;)
            {
                try
                {
                    Console.WriteLine("Welcome to our C# class. which student would you like to learn about? (Enter a number 0 - 18)");
                    int userInput = int.Parse(Console.ReadLine());
                    StudentBio(userInput);
                    Console.WriteLine("Would you like to know more?");
                    string userContinue = Console.ReadLine();
                    if (userContinue == "n")
                    {
                        return;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("This is not a valid input");
                }
            }
        }
        public static void StudentBio(int userInput)
        {
            string[,] studentBio = new string[19, 3]
            {
                {"Andrea", "Rochester, MI", "Loaded Fries"},
                {"Anthony", "Harrison, MI", "Spagetti"},
                {"Brian", "West Bloomfield, MI", "Pot Roast"},
                {"Camille", "Pontiac, MI", "Fried Chicken"},
                {"Clayton", "Indianapolis, IN", "Ice Cream"},
                {"Damacious", "Detroit, MI", "Alfredo"},
                {"David", "Warren, MI", "Pizza"},
                {"Evan", "Toledo, OH", "Grilled Octopus"},
                {"Heather", "Okemos, MI", "Pizza"},
                {"Jacky", "Detroit, MI", "Sushi"},
                {"Johnathan", "Brighton, MI", "Korean"},
                {"Katie", "Woodhaven, MI", "Lasagna"},
                {"Levi", "Detroit, MI", "Pizza"},
                {"Mauricio", "Ypsilanti, MI", "Grilled Chicken"},
                {"Nicholas", "Ann Arbor", "Tacos"},
                {"Rudy", "Detroit, MI", "Salad"},
                {"Sean O", "Clarkston, MI", "Pasta"},
                {"Steve", "Perrysburg, OH", "Pizza"},
                {"Ty", "Holly, MI", "Pasta"},
            };
            try
            {
                Console.WriteLine(studentBio[userInput, 0]);
                Console.WriteLine("Would you like to know about their hometown or favorite food");
                string fact = Console.ReadLine().ToLower();
                if (fact == "hometown")
                {
                    Console.WriteLine(studentBio[userInput, 1]);
                }
                else if (fact == "favorite food")
                {
                    Console.WriteLine(studentBio[userInput, 2]);
                }
            }

            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Please try again");
            }
        }
    }
}