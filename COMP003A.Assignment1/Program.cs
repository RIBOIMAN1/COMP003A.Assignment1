/*
 * Author: Riley Benson
 * Course: COMP003A
 * Faculty: Jonathan Cruz
 * Purpose: This application demonstrates the basic structure of a .NET console application.
 */

// This namespace contains all the code for the application
namespace COMP003.LectureActivity1
{
    // This is the main class of the application
    internal class Program
    {
        // The entry point of the application
        static void Main(string[] args)
        {
            // Display a single message
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "! My name is Riley Benson.\n\n\nHere are 10 things about me:\n\t1. I have started using computers at the young age of 4 years old.\n\t2. My first computer OS I used was Windows 7.\n\t3. I used to be a Duck Life 1 and 3 speedrunner (unofficially).\n\t4. I prefer Android over iOS and Linux over Windows and Mac.\n\t5. I play Super Smash Bros. somewhat competitively, and have even attneded a few tournaments, including one in-person one.\n\t6. ");
        }
    }
}