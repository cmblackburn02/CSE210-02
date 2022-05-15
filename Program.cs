using System;


//This is a game called HILO
//Created by Cecilee Blackburn 

namespace cse210_02
{
    class Program
    {

        static void Main(string[] args)
        {

            Player player = new Player();
            bool result;

            while (player.continuePlaying)
            {
                result = letsPlay();
                player.updatePoints(result);
                Console.WriteLine($"Your score is: {player.points}");
                player.setContinuePlaying();

            }
            Console.WriteLine("Thanks for playing!");
        }
            
    }
    }

