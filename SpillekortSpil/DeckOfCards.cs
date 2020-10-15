using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace SpillekortSpil
{
    public class DeckOfCards
    {
        private Card[] Deck;
        public int cardDraw = 0;
        public DeckOfCards(int noOfJokers = 2)
        {

            this.Deck = new Card[52 + noOfJokers];
            
            int i = 0;
            for (i = 0; i < noOfJokers; i++)
            {
                Card Joker = new Card(suits.Joker, ranks.Joker);
                this.Deck[i] = Joker;
            }

            foreach (suits suit in Enum.GetValues(typeof(suits)))
            {

                foreach (ranks rank in Enum.GetValues(typeof(ranks)))
                {
                    if(suit != suits.Joker && rank != ranks.Joker)
                    {
                        Card crd = new Card(suit, rank);
                        this.Deck[i] = crd;
                        i++;
                    }
                }
            }
            
        }

        public void ShuffleDeck()
        {
            var r = new Random();
            int d = 0;
            foreach (var card in this.Deck)
            {
                //get random number from deck
                int rnd = r.Next(0, this.Deck.Length);
                //Replace Cards from the two index from the Deck
                this.Deck[d] = this.Deck[rnd];
                this.Deck[rnd] = card;
                d++;
            }
        }

        public Card DrawCard()
        {
           this.cardDraw++;
            return this.Deck[this.cardDraw];
        }

        public Card DrawCard2()
        {
            this.cardDraw++;
            return this.Deck[this.cardDraw];
        }

        public Card[] GetDeck(){
            return Deck;
        }
    }
}
