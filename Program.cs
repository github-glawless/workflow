using System;

namespace workflow
{
    class Program
    {
        // Create a program that creates a ticket for a user.
        // If the user is a senior citizen of 65 years or older
        //    they receive a discounted price of $10/ticket.
        //If the user is 12 years old or younger, 
        //    they receive a discounted price of $8/ticket.
        //Else 
        //    full price of a ticket is $14.
        //Age Price 0-12 $8 
        //         13-64 $14 
        //         65+ $10
        // Add the following to your program 
        // that prints the ticket prices for a user:
        // Create a new variable named isStudent that is a boolean.
        // Add another condition that checks if isStudent is true.
        // If a user is a student, 
        //     the user gets the same price as a user who is 12 years old or younger.
        // Add a condition that throws an exception for negative age values.
        // Add a try/catch block the catches the exception that is thrown.

        static void Main(string[] args)
        {
            
            int price = 14; // default to highest price 
           // bool valid = false ;

            bool isStudent = false;
            bool result = false; 
            //string value = string.Empty;

            Console.WriteLine("What is your age:");
            
            string line = Console.ReadLine(); // Read string from console
            
            int age;

            if (int.TryParse(line, out age)) // Try to parse the string as an integer 
            {
                Console.WriteLine("Are you a student?(Y/N)");
                //              isStudent ? "Y" : "N");

                try {
                    string value = Console.ReadLine();
                    result = Convert.ToBoolean (value) ;
                    Console.WriteLine(value);
                }
               
                catch (Exception e) {
                    Console.WriteLine ($"@@@Formatting is incorrect for the boolean'{e}'") ;
                } 

                Console.WriteLine(result);
                Console.WriteLine(isStudent);
                               
                if(age < 13) {
                    price = 8;
                } else {
                    if(age > 64) {
                        price = 10;
                    }
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid age (0-120)!");
            }
        }
    }
}
