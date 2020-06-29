using System;

namespace QuickAppForGitHubCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please, type your name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Hello {0} !", name);            
        }
    }
}
