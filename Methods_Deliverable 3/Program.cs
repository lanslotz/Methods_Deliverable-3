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
                // this variable is used to capture what the user has entered.
                string input = Console.ReadLine();
                // this variable is used to record the message after executing the function PrintMessage.
                string message = PrintMessage(input);
                // display the entire message on console
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
        //create new method to generate the hello message.
        private static string PrintMessage(string get_input)
        {
            // this variable is used to create a new message based on the user input.
            string final_message = "Hello " + get_input + "!";
            // return new message generated.
            return final_message;

        }
    }
}
