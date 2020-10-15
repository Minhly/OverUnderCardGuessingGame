using System;

namespace SpillekortSpil
{       
    
    public enum suits {Joker=0, Club=1,Diamond=2,Heart=3,Spade=4}
    public enum ranks {Joker=14, Ace=1, Two=2, Three=3, Four=4, Five=5, Six=6, Seven=7, Eight=8, Nine=9, Ten=10, Jack=11, Queen=12, King=13 }

    public class Card
    {
        private suits suit;
        private ranks rank;

        public Card(suits st, ranks rnk)
        {
            this.suit = st;
            this.rank = rnk;
        }

        public suits GetSuite()
        {
            return this.suit;
        }

        public ranks GetRanks()
        {
            return this.rank;
        }

    }
}
