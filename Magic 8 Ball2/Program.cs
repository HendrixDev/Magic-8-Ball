using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Magic_8_Ball2
{
    //abstract class Zack
    //{
    //    public static string name = "Zack";
    //    public static string alias = "Zachery";
    //    private static int age = 24;

    //}

    /// <summary>
    /// Entry point for magic 8 ball program
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            //Preserve current console text color
            ConsoleColor oldColor = Console.ForegroundColor;

            TellPeopleProgram();

            //Create a randomizer object
            Random randomObject = new Random();


            //Loop Forever
            while (true)
            {
                string questionString = GetQuestionFromUser();

                int numberOfSecondsToSleep = randomObject.Next(5) + 1;
                Console.WriteLine("Give me a sec to think...");
                Thread.Sleep(numberOfSecondsToSleep * 500);

                if( questionString.Length == 0)

                {
                    Console.WriteLine("You Need to ask a question, you fool!");
                    continue;
                }

                //See if the user typed 'quit' as the question
                if (questionString.ToLower() == "quit")
                {
                    break;
                }

                if (questionString.ToLower() == "you suck")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("NO YOU SUCK! BYE!! >:(");
                    break;
                

                }

                //Get a random number
                int randomNumber = randomObject.Next(4);

                Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);

                //Use random number to determine response
                switch (randomNumber)
                {
                    case 0:
                        {
                            Console.WriteLine("YES!");
                            break;
                        }
                    case 1:
                        {
                            Console.WriteLine("NO!");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Maybe...");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("OMG YES!");
                            break;
                        }
                }
            }
            //Cleaning up
            Console.ForegroundColor = oldColor;
        }

        /// <summary>
        /// This will tell people the name of the program and who created it
        /// </summary>
        static void TellPeopleProgram()
        {
            //Change Console Text Color
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Magic 8 Ball");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" (By: Zack Hendrix)");
        }

        static string GetQuestionFromUser()
        {
                //This Block of code will ask the user for a question
                //and store the question text in questionString variable
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Ask a Question?: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                string questionString = Console.ReadLine();

            return questionString;

    }
    }




}


