using System;

namespace NumberGuesser 
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Hello world");
            Random rnd = new Random();  

            int num = rnd.Next(0,100);

            bool win = false;

            do
            {
                Console.WriteLine("Guess a number between 0-100: ");
                string guess = Console.ReadLine();
                int numGuess = int.Parse(guess);

                if(numGuess > num)
                {
                    Console.WriteLine("You are too high!");
                }
                else if(numGuess < num)
                {
                    Console.WriteLine("You are too low!");
                }
                else if(numGuess == num)
                {
                    win = true;
                    Console.WriteLine("You are a winner!");
                }
            }while(win==false);
        }
    }

}
