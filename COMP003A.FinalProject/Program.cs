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

            } while (UserGender != "M" && UserGender != "F" && UserGender != "O");

            Console.WriteLine("\n");

            Console.ForegroundColor= ConsoleColor.Blue;

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


            PrintSeperator("Summary");

            Console.WriteLine("\n");

            Console.WriteLine($"{Firstname} {Lastname}");

            int Userage = AgeCalulator(Birthyear);

            Console.WriteLine($"User's Age: {Userage}");

            switch (UserGender) 
            {
                case "M":
                    Console.WriteLine("User Gender: Male");
                    break;
                case "F":
                    Console.WriteLine("User Gender: Female");
                    break;
                case "O":
                    Console.WriteLine("User Gender: Other Not listed");
                    break;
            }

        }

        /// <summary>
        /// Basic seperator with section title 
        /// </summary>
        /// <param name="title">Section name</param>
        static void PrintSeperator(string title)
        {
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine(title);
            Console.WriteLine("".PadRight(50, '*'));
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

        static int AgeCalulator(int Birthyear)
        {
            return DateTime.Now.Year - Birthyear;
        }

    }
}