using System;

namespace Class1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine(); 
            string standardGreeting = "Hello, " + name + " :)";
            Console.WriteLine(standardGreeting);

            if (name == "Amar")
            {
                // Console.WriteLine(standardGreeting + "\nI like your shoes");
                Console.WriteLine("I like your shoes");
            }
            //else if(name == "Brandy")
            if (name == "Brandy")
            {
                // Console.WriteLine(standardGreeting + "\nYou seem like a cool person");
                Console.WriteLine("You seem like a cool person");
            }
            /* else
            {
                Console.WriteLine(standardGreeting);
            }*/
            Console.ReadLine();
        }
    }
}
