using System;

namespace ExampleIfElse1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define the input variable and get input from user
            Console.WriteLine("Input a character: ");
            char input = (char) Console.Read();

            //Console.ReadLine();

            //check if input is a Letter first
            if (char.IsLetter(input))
            {  
                if (char.IsLower(input))
                {
                    Console.WriteLine("The input character is in lowercase.");
                    //Console.ReadLine();
                }
                else 
                {
                    Console.WriteLine("The input character is in Uppercase.");
                    //Console.ReadLine();
                }
            }
            // input is not a letter; check if it is a number
            else if (char.IsNumber(input))
            {
                
                Console.WriteLine("The input character is a number.");
                        //Console.ReadLine();
            }
            else
            // input is not a letter or a number
            {
                        Console.WriteLine("The input character isn't alphanumeric.");
                        //Console.ReadLine();
            }
            Console.WriteLine("I am done!!");
            Console.ReadLine();
        }
    }
}
