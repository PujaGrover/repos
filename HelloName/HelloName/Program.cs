using System;

namespace HelloName
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare a variable to store the name of the user
            string Name;

            //Print out the question for the user to know what he has to input
            Console.WriteLine("What is your name?");

            //Store the input from user in the variable Name
            Name = Console.ReadLine();

            //Print the message based on the name entered by the user
            if (Name == "Amar")
            {
                Console.WriteLine("Hello " + Name + " :)\n" + "I like your shoes");
            }
            else if (Name == "Brandy")
            {
                Console.WriteLine("Hello " + Name + " :)\n" + "You seem like a cool person");
            }
            else
            {
                Console.WriteLine("Hello " + Name + " :)");
            }
           
            //Use Readline to stop the screen from closing the console display window
            Console.ReadLine();

        }
    }
}
