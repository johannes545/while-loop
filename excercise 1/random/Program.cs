using System;

namespace random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 10);
            int userInput = 0;


            

            while (favNumber != userInput) 
            {
                Console.WriteLine("what is your favorite number?");
                userInput = int.Parse(Console.ReadLine());

                
                if (favNumber > userInput)
                {
                    Console.WriteLine("too low");
                    
                }
                else if (favNumber < userInput)
                {
                    Console.WriteLine("too high");
                }
                else
                {
                    Console.WriteLine("spot on, congratz");
                }

            }
            
            

        }
    }
}
