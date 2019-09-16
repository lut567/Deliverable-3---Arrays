/*
 * 
 * coder: Shane Luttmann
 * 9/15/19
 * Deliverable 3  - Array
 * 
 */

using System;

namespace Deliverable_3___Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Cont var to run the first while loop
                string cont = "Yes";
                // count var to show how many tmes the program has excuited
                int count = 1;
                // Array with all elements inside
                int[] elementArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
                
                //First while loop that loops the program if the user requests
                while ( cont == "Yes" || cont == "yes" || cont == "Y" || cont == "y")
                {
                    // writeline that shows the user how any times the program has ran
                    Console.WriteLine("Times program has run: " + count);

                    // for loop to run through the array and display each element
                    for (int i = 0; i < elementArray.Length; i++)
                    {
                        // output
                        Console.WriteLine("Element value = " + elementArray[i]);
                    }

                    // Asks for user input if the user wants to program to run again
                    Console.Write("Do yu want to run the program again?: ");
                    cont = Console.ReadLine();

                    // I the user want the program to run again, this If loop will clear the console and count up the amount of times it has ran
                    if (cont == "Yes" || cont == "yes" || cont == "Y" || cont == "y")
                    {
                        // clear console
                        Console.Clear();
                        // count up times ran
                        count++;
                    }
                    else
                    {
                        // ends the program
                        Environment.Exit(0);
                    }
                }
            }
            catch (Exception ex)
            {
                // Shows if an error occured
                Console.WriteLine(ex.Message);
            }
        }
    }
}
