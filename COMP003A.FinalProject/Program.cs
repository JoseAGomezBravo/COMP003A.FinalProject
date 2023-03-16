/*
 * Author: Jose Angel Gomez Bravo
 * Course: COMP003A
 * Purpose: An intake form for a New User Profile
 */

using System;
using System.Text.RegularExpressions;
using System.Transactions;
using System.Xml;
using System.Xml.Linq;

namespace COMP003A.FinalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string firstName, lastName, userGender;
            int birthYear;

            PrintSeperator("Information");

            Console.WriteLine("\n");
            //Regex.IsMatch(name, @"^[a-zA-Z]+$"
            //while (string.IsNullOrEmpty(firstName) || !ValidName(firstName));
            bool validiNput = false;

            do
            {

                Console.Write("Enter First Name: \n");
                firstName = Console.ReadLine().Trim();

                if (Regex.IsMatch(firstName, @"^[a-zA-Z]+$"))
                {
                    validiNput = true;
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

            } while (!validiNput);

            bool vaLidinput = false;
            do
            {

                Console.Write("Enter Last Name: \n");
                lastName = Console.ReadLine().Trim();

                if (Regex.IsMatch(lastName, @"^[a-zA-Z]+$"))
                {
                    vaLidinput = true;
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

            } while (!vaLidinput);

            bool validInput = false;

            do
            {
                Console.WriteLine("When were you born?");
                birthYear = Convert.ToInt32(Console.ReadLine());

                if (birthYear < 1900 || birthYear > DateTime.Now.Year)
                {
                    Console.WriteLine("Invalid Input");
                }
                else
                {
                    validInput = true;
                }

            } while (!validInput);

            bool validinPut = false;

            do
            {

                Console.Write("Enter Gender M/F or O: \n");
                userGender = Console.ReadLine().ToUpper();

                if (userGender != "M" && userGender != "F" && userGender != "0")
                {
                    Console.WriteLine("Invalid Input");

                }
                else
                {
                    validinPut= true;
                }

            } while (!validinPut); //makes sure that the user's input is a character that was given as an option

            Console.WriteLine("\n");


            PrintSeperator("Questionaire");
            
            Console.WriteLine("\n");

            List<string> anSwers = new List<string>();

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
                anSwers.Add(Console.ReadLine());
            }

            Console.WriteLine("\n");

            PrintSeperator("Summary");

            Console.WriteLine("\n");

            Console.WriteLine($"{firstName} {lastName}");

            int Userage = AgeCalulator(birthYear);

            Console.WriteLine($"User's Age: {Userage}");

            switch (userGender) // Displays the user's full gender description, by interperting the user's input (M, F, and O).
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

            for (int i = 0; i < anSwers.Count; i++) // Displays question number and corresponding answer.
            {
                Console.WriteLine(array1[i]);
                Console.WriteLine(anSwers[i]);
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
        /// Calculates the users age by subtracting current year by birth year
        /// </summary>
        /// <param name="Birthyear"></param>
        /// <returns>User's age</returns>
        static int AgeCalulator(int birthYear)
        {
            return DateTime.Now.Year - birthYear;
        }

    }
}