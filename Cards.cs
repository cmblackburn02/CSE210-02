using System;

namespace cse210_02
{
    public class Cards
    {
        public int number;
        
        private static Random rng = new Random();
        //this generates the random card each turn.
        public void SetCard()
        {

            //Random num = new Random();
            number = rng.Next(1, 14);
        }

    }
}
