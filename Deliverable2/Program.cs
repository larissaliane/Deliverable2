using System;

namespace Deliverable2
{
    class Program
    {
        public static void Main(string[] args)
        {
           
            string lastInput = null;
          
            while (lastInput != "bye") 
            {
                Console.WriteLine("What would you like to say?");
                string input = Console.ReadLine().ToLower();

                if (lastInput == input)
                {
                    Console.WriteLine("I'm sorry but you have already said that");
                }

                else if (input == "hello")
                {
                    
                    Console.WriteLine("Hi good to see you");
                    
                }
                else if (input == "bye")
                {
                    

                    Console.WriteLine("Good Bye!");
                    
                }
                else if (input == "sup")
                {
                    Console.WriteLine("I am good");
                    
                }
                else if (input == "hello there")
                {
                    Console.WriteLine("General Kenobi");
                    
                }
                else if (lastInput == input)
                {
                    Console.WriteLine("I'm sorry but you have already said that");
                }
                            
                lastInput = input;
               

            }

        }
    }
}
