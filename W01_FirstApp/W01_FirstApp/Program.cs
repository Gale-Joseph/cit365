/*  This program does the following: 
 *      1. Stores and prints two variables, name and location.
 *      2. Each variable is outputted with a WriteLine statement
 *      3. Outputs the current date but not the time
 *      4. Ouputs the number of days until Christmas of the current year with an appropriate output label
 *      5. Runs program 2.1 from the class text
 *      6. Adds appropriate string tags requesting user input
 *      7. Displays length of wood needed and total area of glass needed for a complete window or 2 panes of glass
 *      
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W01_FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables using string type
            string studentName = "Joseph Gale";
            string location = "Iowa";

            //current datetime object with just year, month, and date for printing and whole number result of days till Christmas
            DateTime date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            DateTime christmas = new DateTime(DateTime.Now.Year, 12, 25);
            double daysToChristmas = (christmas - date).TotalDays;

            //string interpolation reference: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated
            Console.WriteLine($"My name is {studentName}.");
            Console.WriteLine($"I live in {location}.");

            //printing just day reference: https://stackoverflow.com/questions/6817266/how-to-get-the-current-date-without-the-time
            Console.WriteLine($"The current date is {date.ToString("MM/dd/yyyy")}.");
                        
            Console.Write($"Get ready for the holidays because it's only {daysToChristmas} days until Christmas {date.Year}!");

            //program 2.1 from text
            //declare basic variables for height and width of a window 
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            //request width, store as a string and parse into a double variable:
            Console.WriteLine("\nPlease enter the width of a pane of glass in meters:");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            //request height, store as a string and parse into a double variable:
            Console.WriteLine("\nPlease enter the height of a pane of glass in meters:");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            //calculate the total length of wood needed for frame in feet, and calcuate the area of glass in meters
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            //calculate the total feet of wood and glass for 1 complete window or 2 panes of glass
            Console.WriteLine("The length of the wood is " +
                woodLength + " feet.");
            Console.WriteLine("The area of the glass is " +
                glassArea + " square meters.");

            //keep console window open  
            Console.ReadKey();

        }
    }
}
