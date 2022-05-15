using System;

namespace cse210_02
{
    public class Cards
    {
        public int number;
        
        //this generates the random card each turn.
        public void SetCard()
        {
            Random num = new Random();
            number = num.Next(1, 14);
        }


            

    }
}

