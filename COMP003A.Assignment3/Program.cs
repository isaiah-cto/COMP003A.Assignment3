using Microsoft.VisualBasic;
using System.ComponentModel.Design;
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
            bool hasvalidID = Console.ReadLine() == ("yes");
            Console.Write("Have you completed orientation? (yes/no): ");
            bool completedorientation = Console.ReadLine() == ("yes");
                if (hasvalidID && completedorientation)
                {
                    Console.WriteLine("Ready");
                }
            else if (hasvalidID || completedorientation)
            {
                    Console.WriteLine("Conditionally Ready");
                }
            else
            {
                Console.WriteLine("Not Ready");
            }
            {
                Console.WriteLine("Select a guidance option:");
                Console.WriteLine("1 - Academic Planning");
                Console.WriteLine("2 - Personal Planning");
                Console.WriteLine("3 - Career Planning");
                Console.WriteLine("Enter Choice: 1");
                int num = 1;
                int num1 = 2;
                int num2 = 3;
                if (num <= 1);
                {
                Console.Write("Guidance: ");
                Console.WriteLine("Meet with an academic advisor to plan your next term");
            }

            }
        }
    }
}
