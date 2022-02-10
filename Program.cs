// Programmer: Dragana Nikic
// Project: TechAssignment3_UsingIterativeStatments
// Due Date: 02/10/2022
// Description: Create console program that converts CAD $ into US $. Program will demonstate 
//              use of both conditional and iterative statements.

using System;

namespace TechAssignment3_Using_Iterative_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask user to for input             
            Console.Write("Please enter a CAD increment value between 5 and 25:   ");

            /* 
               Use the try catch to handle possible runtime errors that may occure if user provides bad input.
               The catch block will handle the error, and it will dislay an error message. 
            */
            try
            {

                // This variable will collect data from user input 
                int incrementValue = Convert.ToInt32(Console.ReadLine());

                // Declare variable for conversion rate
                decimal conversionRate = 0.792367m;

                // Declare variable for calculated currency conversioin
                decimal conversionAmount = 0.00m;

                // While loop for confirmation if values that are not between 5 and 25
                while (incrementValue < 5 || incrementValue > 25)
                {
                    Console.Write("Please enter values between 5 and 25 and try again:   ");
                    incrementValue = Convert.ToInt32(Console.ReadLine());
                }

                // If the user inputs values between 5 and 25, execute the For Loop
                if ((incrementValue >= 5) && (incrementValue <= 25))
                {
                    // Display user's input
                    Console.WriteLine("You have entered CAD Increment Value = " + incrementValue + "\n");

                    // Display column names
                    Console.WriteLine("\t" + "CAD" + "\t" + "US");

                    // Execute For Loop
                    for (int i = 0; i <= 200; i += incrementValue)
                    {
                        // Calculate conversion amount
                        conversionAmount = i * conversionRate;

                        // Display incement amounts in CAD and convertion to US. Round to two decimal places. 
                        Console.WriteLine("\t" + i + "\t" + conversionAmount.ToString("C", System.Globalization.CultureInfo.CurrentCulture));
                    }
                }
            } // End of try
            catch
            {
                Console.WriteLine("Oops you entered non-integer value. ");
                Console.WriteLine("Press any key to exit the program. ");
                Console.ReadKey(true);
            } // End of catch
        } // End of Main
    } // End of class
} // End of namespace