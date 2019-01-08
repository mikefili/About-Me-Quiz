using System;

namespace Lab01_ABOUT_ME_QUIZ
{
    class Program
    {
        private static int age;
        private static string name;
        private static string birthplace;
        private static bool siblings = true;
        private static bool wutang = true;

    public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mike's About Me Game");
            Console.WriteLine("Press ENTER to play");
            Console.ReadLine();

            Q1();
            Q2();
            Q3();
            bool answer4 = Q4();
            if (answer4 == siblings)
                Console.WriteLine("Correct");
            else
                Console.WriteLine("Sorry, I have one sister.");
            Console.ReadLine();
            bool answer5 = Q5();
            if (answer5 == wutang)
                Console.WriteLine("Correct. Wu Tang Clan ain't nothin to f*ck with.");
            else
                Console.WriteLine("Sorry. Better protect ya neck.");
            Console.ReadLine();
        }

    public static void Q1()
        {
            try
            {
                Console.WriteLine("How old am I?");
                age = Convert.ToInt32(Console.ReadLine());

                if (age == 30)
                    Console.WriteLine("Correct!");
                else if (age != 30)
                    Console.WriteLine("Sorry, I am 30 years old.");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("You hit the generic Exception");
                Console.WriteLine("ERROR: " + e.Message);
                Console.ReadLine();
            }
        }

    public static void Q2()
        {
            try
            {
                Console.WriteLine("Can you spell my last name?");
                name = Console.ReadLine();
                
                if (name.ToUpper() == "FILICETTI")
                    Console.WriteLine("Correct!");
                else if (name.ToUpper() != "FILICETTI")
                    Console.WriteLine("Sorry, it's a tough name to spell.");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("You hit the generic Exception");
                Console.WriteLine("ERROR: " + e.Message);
                Console.ReadLine();
            }
        }

    public static void Q3()
        {
            try
            {
                Console.WriteLine("I was born in California, but can you guess which city?");
                birthplace = Console.ReadLine();

                if (birthplace.ToUpper() == "SAN JOSE")
                    Console.WriteLine("Correct!");
                else if (birthplace.ToUpper() != "FILICETTI")
                    Console.WriteLine("Sorry, it's a big state, no shame there.");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("You hit the generic Exception");
                Console.WriteLine("ERROR: " + e.Message);
                Console.ReadLine();
            }
        }

    public static bool Q4()
        {
            Console.WriteLine("Do I have any siblings?");
            string res1 = Console.ReadLine();

            if (res1.ToUpper() == "YES")
                return true;
            else
                return false;
        }

    public static bool Q5()
        {
            Console.WriteLine("Is the Wu Tang Clan something to f*ck with?");
            string res1 = Console.ReadLine();

            if (res1.ToUpper() == "NO")
                return true;
            else
                return false;
        }
    }
}
