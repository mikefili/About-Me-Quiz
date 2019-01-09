using System;

namespace Lab01_ABOUT_ME_QUIZ
{
    class Program
    {
        //declare variables by data type and set booleans
        private static int age;
        private static string name;
        private static string birthplace;
        private static readonly bool siblings = true;
        private static readonly bool wutang = true;

    // Main method
    public static void Main(string[] args)
        {
            // welcome user to game and confirm they are ready to play
            Console.WriteLine("Welcome to Mike's About Me Game");
            Console.WriteLine("Press ENTER to play");
            Console.ReadLine();

            // call question 1
            QuestionOne();
            // call question 2
            QuestionTwo();
            // call question 3
            QuestionThree();
            // call question 4 and compare resulting booleans
            bool answer4 = QuestionFour();
            if (answer4 == siblings)
                Console.WriteLine("Correct, I have a sister named Sarah");
            else
                Console.WriteLine("Sorry, I have one sister.");
            // call question 5 and compare resulting booleans
            bool answer5 = QuestionFive();
            if (answer5 == wutang)
                Console.WriteLine("Correct. The Wu Tang Clan indeed ain't nothin to f*ck with.");
            else
                Console.WriteLine("Sorry. The Wu Tang Clan ain't nothin to f*ck with. Better protect ya neck.");
            // thank user for playing then close app
            Console.WriteLine("Thanks for playing! Press ENTER to exit.");
            Console.ReadLine();
        }

    // QuestionOne method
    public static int QuestionOne()
        {
            // try/catch block that confirms the correct type of input is received
            // try block
            try
            {
                // ask user how old I am
                Console.WriteLine("How old am I?");
                // convert user response to int
                string age = Console.ReadLine();

                // if the user answers "30" write "Correct!"
                if (Convert.ToInt32(age) == 30)
                    Console.WriteLine("Correct!");
                // if the user answers a number other than "30" write "Sorry, I am 30 years old."
                else
                    Console.WriteLine("Sorry, I am 30 years old.");
            }
            // catch block
            catch (Exception e)
            {
                // if the user provides a non-int response, write the appropriate error message
                Console.WriteLine("You hit the generic Exception");
                Console.WriteLine("ERROR: " + e.Message);
            }
            return age;
        }

    // QuestionTwo method
    public static string QuestionTwo()
        {
            // ask user if they can spell Filicetti
            Console.WriteLine("Can you spell my last name?");
            // take in response as variable name
            name = Console.ReadLine();
                
            // convert answer to uppercase & confirm correct spelling
            if (name.ToUpper() == "FILICETTI")
            {
                Console.WriteLine("Correct!");
            }
            Console.WriteLine("Sorry, it's a tough name to spell.");
            return name;
        }

    // QuestionThree method
    public static string QuestionThree()
        {
            // ask user in which Californian city I was born
            Console.WriteLine("I was born in California, but can you guess which city?");
            // take in response as variable birthplace
                birthplace = Console.ReadLine();

            // convert answer to uppercase & confirm correct spelling
            if (birthplace.ToUpper() == "SAN JOSE")
            {
                Console.WriteLine("Correct!");
            }
            Console.WriteLine("Sorry, it's a big state, no shame there.");
            return birthplace;
        }

    // QuestionFour method
    public static bool QuestionFour()
        {
            // ask user if I have any siblings
            Console.WriteLine("Do I have any siblings?");
            // take in response as variable res1
            string res1 = Console.ReadLine();

            // if res1 is yes return true
            if (res1.ToUpper() == "YES")
                return true;
            // if res1 is anything else return false
            else
                return false;
        }

    // QuestionFive method
    public static bool QuestionFive()
        {
            // ask user if the Wu is something to f*ck with
            Console.WriteLine("Is the Wu Tang Clan something to f*ck with?");
            // take in response as variable res2
            string res2 = Console.ReadLine();

            // if res2 is no return true
            if (res2.ToUpper() == "NO")
                return true;
            // if res2 is anything else return false
            else
                return false;
        }
    }
}
