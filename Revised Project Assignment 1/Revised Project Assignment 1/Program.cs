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
            Console.WriteLine("Hello, " + name + "! My name is Riley Benson.\n\n");
            Console.WriteLine("Here are 10 things about me:\n\t");
            Console.WriteLine("1. I have started using computers at the young age of 4 years old.\t");
            Console.WriteLine("2. My first computer OS I used was Windows 7.\t");
            Console.WriteLine("3. I used to be a Duck Life 1 and 3 speedrunner (unofficially).\n\t");
            Console.WriteLine("4. I prefer Android over iOS and Linux over Windows (still like Windows though, and also don't have much Mac experience).\n\t");
            Console.WriteLine("5. I play Super Smash Bros. somewhat competitively, and have even attneded a few tournaments, including one in-person one.\n\t");
            Console.WriteLine("6. I like always playing video games on the hardest difficulty (except permadeath).\n\t");
            Console.WriteLine("7. I like listening to a variety of music, including music from Korn, Journey, and Eminem just to name a few.\n\t");
            Console.WriteLine("8. I got my car for only $1000.\n\t");
            Console.WriteLine("9. The first coding language I ever learned were Minecraft commands, including command blocks.\n\t");
            Console.WriteLine("10. I used to be an unofficial Minecraft and Fortnite map creator a long time ago (maps weren't released to the public, but friends would sometimes play my maps).");
        }
    }
}