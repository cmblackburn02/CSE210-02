using System;

namespace cse210_02
{
    public class Player
    {
        //gets the guess and checks to make sure it's a legit guess.
        public static string makeGuess()
        {
        
            string guess;
            do {

                Console.WriteLine("Is your guess higher or lower? [h/l] ");
                guess = Console.ReadLine();
                if (guess != "h" && guess != "l")
                    Console.WriteLine("Sorry, that is not a valid input. Try again.");
            }while (guess != "h" && guess != "l");

            return guess;
        }
        //This checks if the guess is correct.
        public static bool checkGuess(string guess, int firstNum, int secondNum)
        {
            if ((guess == "h" && secondNum > firstNum) || (guess == "l" && secondNum < firstNum))
                return true;
            else
                return false;
        }
        //This gets the cards and starts the game for a turn
        public static bool letsPlay()
        {

            Cards firstCard = new Cards();
            Cards secondCard = new Cards();

            firstCard.SetCard();
            Console.WriteLine($"The card is: {firstCard.number}");

            
            string guess = makeGuess();

            do
            {
                secondCard.SetCard();
            }while (firstCard.number == secondCard.number);
            Console.WriteLine($"Next card was: {secondCard.number}");

            return checkGuess(guess, firstCard.number, secondCard.number);
        }

        public int points = 300;
        public bool continuePlaying = true;

        //checks to see if the player wants to continue
        public void setContinuePlaying()
        {
            if (points > 0)
            {
                string input;
                do{
                    Console.WriteLine("Play again? [y/n] ");
                    input = Console.ReadLine();
                    if (input != "y" && input != "n")
                        Console.WriteLine("Sorry, that wasn't an option, Please try again.");
                }while (input != "y" && input != "n");

                if (input == "n")
                    continuePlaying = false;
            }
            else
                continuePlaying = false;
        }
        //this simple function just updates the points each turn.
        public void updatePoints(bool correctGuess)
        {
            if (correctGuess)
                points +=100;
            else
                points -= 75;
        }
        
    }

}
