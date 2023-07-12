using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // // Convert a string to an integer using TryParse
            Console.WriteLine("Enter a number");
            string a = Console.ReadLine();
            if (int.TryParse(a, out int result))
            {
                Console.WriteLine("Parsed number using int parse is :" + (result*5));
            }

            else
            {
                Console.WriteLine("TryParse failed.Invalid input string.");
            }

            //convert string to DateTime
            try
            {
                Console.WriteLine("Enter a date (MM/dd/yyyy): ");
                string dateInput = Console.ReadLine();
                DateTime val = Convert.ToDateTime(dateInput);
                Console.WriteLine("Enter the months to subtract :");
                int months = Convert.ToInt32(Console.ReadLine());
                DateTime newDate = val.AddMonths(-months);
                Console.WriteLine(newDate.ToShortDateString());
            }
            catch(Exception ex) {
                Console.WriteLine(ex.Message);
            }
            /// Convert a string to a TimeSpan object using Parse
            Console.WriteLine("Enter a time (hh:mm:ss): ");
            string timeInput = Console.ReadLine();
            try
            {
                TimeSpan time = TimeSpan.Parse(timeInput);
                TimeSpan newTime = time.Add(new TimeSpan(2, 0, 0));
                Console.WriteLine($"Two hours later will be: {newTime.ToString()}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid time in the format hh:mm:ss.");
            }
        }
    }
}
