/*
    Author: Zhenwei Li
    Date: 02/06/2020
    Comments: This C# Console application code demonstrates the use of
              Methods after getting a string from users. 

*/

using System;

namespace Methods_Deliverable_3
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Get input from user
            Console.WriteLine("Please enter your name.");

            // user try-catch to prevent unexpected user input
            try
            {
                string input = Console.ReadLine();

                string message = PrintMessage(input);

                Console.WriteLine(message);
            } // End of try
            catch
            {   
                //display message to let user know what to enter.
                Console.WriteLine("You must enter a string value. Please exit and try again");
                Console.WriteLine("Press any key to exit the program and try again ...");
                Console.ReadKey(true);
            }
            
        }
        private static string PrintMessage(string get_input)
        {
            string final_message = "Hello " + get_input + "!";
            return final_message;

        }
    }
}
