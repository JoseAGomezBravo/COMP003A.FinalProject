/*
 * Author: Jose Angel Gomez Bravo
 * Course: COMP003A
 * Purpose: An intake form for a New User Profile
 */

namespace COMP003A.FinalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            string Firstname, Lastname, UserGender;
            int Birthyear;

            PrintSeperator("Information");

            Console.WriteLine("\n");

            do
            {

                Console.Write("Enter First Name: \n");
                Firstname = Console.ReadLine().Trim();

            } while (string.IsNullOrEmpty(Firstname) || !ValidName(Firstname));

            do
            {

                Console.Write("Enter Last Name: \n");
                Lastname = Console.ReadLine().Trim();
            } while (string.IsNullOrEmpty(Firstname) || !ValidName(Firstname));

            do
            {

                Console.Write("Enter Birth Year: \n");
                int.TryParse(Console.ReadLine(), out Birthyear);

            } while (Birthyear < 1990 || Birthyear > DateTime.Now.Year);

            do
            {

                Console.Write("Enter Gender M/F or O: \n");
                UserGender = Console.ReadLine().ToUpper();

            } while (UserGender != "M" && UserGender != "F" && UserGender != "O"); //makes sure that the user's input is a character that was given as an option

            Console.WriteLine("\n");

            switch (UserGender) // changes font color according the user input
            {
                case "M":
                    Console.ForegroundColor= ConsoleColor.Blue;
                    break;
                case "F":
                    Console.ForegroundColor= ConsoleColor.Red;
                    break;
                case"O":
                    Console.ForegroundColor= ConsoleColor.White;
                    break;
            }

            PrintSeperator("Questionaire");

            Console.WriteLine("\n");

            List<string> Answers = new List<string>();

            Console.Write("What is your favorite hobby? \n");
            Answers.Add(Console.ReadLine());

            Console.Write("What is favorite your color? \n");
            Answers.Add(Console.ReadLine());

            Console.Write("What is your favorite show? \n");
            Answers.Add(Console.ReadLine());

            Console.Write("What is your favorite movie? \n");
            Answers.Add(Console.ReadLine());

            Console.Write("What is your favorite place to go? \n");
            Answers.Add(Console.ReadLine());

            Console.Write("What is your favorite social media app? \n");
            Answers.Add(Console.ReadLine());

            Console.Write("What book would you recommend? \n");
            Answers.Add(Console.ReadLine());

            Console.Write("What is your favorite clothing brand? \n");
            Answers.Add(Console.ReadLine());

            Console.Write("What is your favorite sport? \n");
            Answers.Add(Console.ReadLine());

            Console.Write("Who is your favorite actor? \n");
            Answers.Add(Console.ReadLine());

            Console.WriteLine("\n");

            PrintSeperator("Summary");

            Console.WriteLine("\n");

            Console.WriteLine($"{Firstname} {Lastname}");

            int Userage = AgeCalulator(Birthyear);

            Console.WriteLine($"User's Age: {Userage}");

            switch (UserGender) // Displays the user's full gender description, by interperting the user's input (M, F, and O).
            {
                case "M":
                    Console.WriteLine("User Gender's: Male");
                    break;
                case "F":
                    Console.WriteLine("User Gender's: Female");
                    break;
                case "O":
                    Console.WriteLine("User Gender's: Other Not listed");
                    break;
            }

            for (int i = 0; i < Answers.Count; i++) // Displays question number and corresponding answer.
            {
                Console.WriteLine("Question {0}: {1}", i + 1, Answers[i]);
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

    }
}