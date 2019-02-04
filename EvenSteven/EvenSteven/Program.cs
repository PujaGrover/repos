using System;

namespace EvenSteven
{
    class Program
    {
        static void Main(string[] args)
            
        {
            //define a variable called Num to be able to increment the variable by 1
            int Num;
            // Begin by setting the value of Num as 1
            Num = 1;
            while (Num < 100)           // Run a While loop until the value of Num reaches 99 
            {
                Console.WriteLine(Num); // outputs the value of Num which is going to be odd 
                Num = Num + 1;          // add an increment of 1 to the integer Num
                Console.WriteLine("Steven");// creates Num as even integer and gives output as "Steven"
                Num = Num + 1;
                
            }
            Console.ReadLine();             // This command will prevent console window from closing
        }
    }
}
