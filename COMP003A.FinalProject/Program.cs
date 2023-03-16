/*
 * Author: Jose Angel Gomez Bravo
 * Course: COMP003A
 * Purpose: An intake form for a New User Profile
 */

using System;
using System.Text.RegularExpressions;
using System.Xml;

namespace COMP003A.FinalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            string firstName, Lastname, UserGender;
            int Birthyear;

            PrintSeperator("Information");

            Console.WriteLine("\n");

            do
            {

                Console.Write("Enter First Name: \n");
                firstName = Console.ReadLine().Trim();

            } while (string.IsNullOrEmpty(firstName) || !ValidName(firstName));

            do
            {

                Console.Write("Enter Last Name: \n");
                Lastname = Console.ReadLine().Trim();

            } while (string.IsNullOrEmpty(Lastname) || !ValidName(Lastname));

            do
            {

                Console.Write("Enter Birth Year: \n");
                int.TryParse(Console.ReadLine(), out Birthyear);

            } while (Birthyear < 1900 || Birthyear > DateTime.Now.Year);

            do
            {

                Console.Write("Enter Gender M/F or O: \n");
                UserGender = Console.ReadLine().ToUpper();

            } while (UserGender != "M" && UserGender != "F" && UserGender != "O"); //makes sure that the user's input is a character that was given as an option

            Console.WriteLine("\n");


            PrintSeperator("Questionaire");
            
            Console.WriteLine("\n");

            List<string> Answers = new List<string>();

            string[] array1 = new string[10];

            array1[0] = "What is your favorite hobby?";
            array1[1] = "What is favorite your color?";
            array1[2] = "What is your favorite show?";
            array1[3] = "What is your favorite movie?";
            array1[4] = "What is your favorite place to go?";
            array1[5] = "What is your favorite social media app?";
            array1[6] = "What book would you recommend?";
            array1[7] = "What is your favorite clothing brand?";
            array1[8] = "What is your favorite sport?";
            array1[9] = "Who is your favorite actor?";

            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write($"{array1[i]} \n");
                Answers.Add(Console.ReadLine());
                

            }

            Console.WriteLine("\n");

            PrintSeperator("Summary");

            Console.WriteLine("\n");

            Console.WriteLine($"{firstName} {Lastname}");

            int Userage = AgeCalulator(Birthyear);

            Console.WriteLine($"User's Age: {Userage}");

            switch (UserGender) // Displays the user's full gender description, by interperting the user's input (M, F, and O).
            {
                case "M":
                    Console.WriteLine("User's Gender: Male");
                    break;
                case "F":
                    Console.WriteLine("User's Gender: Female");
                    break;
                case "O":
                    Console.WriteLine("User's Gender: Other Not listed");
                    break;
            }

            for (int i = 0; i < Answers.Count; i++) // Displays question number and corresponding answer.
            {
                Console.WriteLine(array1[i]);
                Console.WriteLine(Answers[i]);
            }

        }

        /// <summary>
        /// Basic seperator with section title 
        /// </summary>
        /// 
        /// 
        /// <param name="title">Section name</param>
        static void PrintSeperator(string title)
        {
            Console.WriteLine("".PadRight(50, '-'));
            Console.WriteLine(title);
            Console.WriteLine("".PadRight(50, '-'));
        }

        /// <summary>
        /// Makes sure that the User's first and last name are both valid inputs (not null, special characters, numbers, etc
        /// </summary>
        /// <param name="name">string first/last name</param>
        /// <returns>true = valid name, false = invalid input</returns>
        static bool ValidName(string name)
        {
            foreach (char c in name)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Calculates the users age by subtracting current year by birth year
        /// </summary>
        /// <param name="Birthyear"></param>
        /// <returns>User's age</returns>
        static int AgeCalulator(int Birthyear)
        {
            return DateTime.Now.Year - Birthyear;
        }

        static bool ValidAsnwer(string Answer)
        {
            while (string.IsNullOrEmpty(Answer))
            {
                Console.WriteLine("Invalid Input");
            }
            return true;
        }
        
        static bool CFristname (string name)
        {
            Console.WriteLine(Regex.IsMatch(name, @"^[a-zA-Z]+$"));
            return true;
        }
    }
}