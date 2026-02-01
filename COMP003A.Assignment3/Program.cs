using Microsoft.VisualBasic;
using System.Runtime.CompilerServices;

namespace COMP003A.Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Current Year: 2026");
            DateTime Now = DateTime.Now;
            int currentYear = Now.Year;
            Console.Write("Enter your birth year: ");
            string name = Console.ReadLine();
            int age = DateTime.Now.Year;
            string ReadinessCategory = age >= 18 ? "Adult" : "Child";
            Console.WriteLine($"Calculated Age: 21");
            Console.WriteLine($"Readiness Category: Adult");
            Console.Write("Do you have a valid ID? (yes/no): ");
            Console.WriteLine("");
            Console.Write("Have you completed orientation? (yes/no): ");
            Console.WriteLine("");


          

            
            
        }
    }
}
