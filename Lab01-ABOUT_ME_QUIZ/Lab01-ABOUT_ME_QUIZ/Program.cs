using System;

namespace Lab01_ABOUT_ME_QUIZ
{
    class Program
    {
        private static int age;
        private static string name;
        private static string birthplace;
        private static bool siblings;
        private static bool wutang;

    public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mike Filicetti's About Me Game");
            Console.WriteLine("Press ENTER to play");
            Console.ReadLine();

            Q1();
            
        }

    public static void Q1()
        {
            try
            {
                Console.WriteLine("How old am I?");
                age = Convert.ToInt32(Console.ReadLine());

                if (age == 30)
                    Console.WriteLine("Correct");
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

        }

    public static void Q3()
        {

        }

    public static void Q4()
        {

        }

    public static void Q5()
        {

        }
    }
}
