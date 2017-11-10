/* 158.212 Assignment 1 by Michael Coleman 07315554 
 * This program takes a series of user entered integers and performs basic calculations on them, displaying the output.
 * The user can enter a negative number to exit the program. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1 {
    class Program {
        static void Main(string[] args) {
            
            List<int> userIntegers = new List<int>(); //An empty list to store any integers the user enters.
            bool exit = false; //Will equate to true when the user has finished inputting integers.

            while (!exit){
                Console.WriteLine("Please enter a number and press return. Enter a negative number to exit.");
                string input = Console.ReadLine(); //Get the users input and store it in a string. Using readline to account for negative numbers.
                int inputAsInt = Convert.ToInt32(input); //Convert the string to an integer to add to the list.

                if (inputAsInt < 0){ //Evaluate if the user has entered a negative number (less than 0). If so, set exit to true to break out of the loop.
                    exit = true;
               
                }else{
                    userIntegers.Add(inputAsInt); //Otherwise, add it to the list.
                }
            }

            if (userIntegers.Count > 0){ //If the user has input at least one integer, display the statistics.
                Console.WriteLine("Total number of values: " + userIntegers.Count); 
                Console.WriteLine("Sum of Values: " + userIntegers.Sum());
                Console.WriteLine("Average of Values: " + userIntegers.Average()); //This will return the correct average be it an integer or a decimal.
                Console.WriteLine("Minimum Value: " + userIntegers.Min());
                Console.WriteLine("Maximum Value: " + userIntegers.Max());
                Console.WriteLine("Values Entered:");

                for (int index = 0; index < userIntegers.Count; index++){ //Loop through the list and print out the entered integers.
                    Console.Write(userIntegers[index] + " ");
                }

                Console.WriteLine();

            }else{
                Console.WriteLine("There were no numbers entered."); //Otherwise print an error.
            }

            Console.ReadKey();

        }
    }
}
