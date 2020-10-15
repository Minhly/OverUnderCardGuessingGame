using System;
using System.Collections.Generic;
using System.Text;

namespace SpillekortSpil
{
    public class PlayCardGame
    {
        DeckOfCards Deck = new DeckOfCards(4);
        Player player1 = new Player(0, 0, 0);
        int rightGuess = 0;
        int wrongGuess = 0;
        int nextPlayerCounter = 0;
        bool loopy = true;
        int[] playerPoints1 = new int[2];
        public void StartGame()
        {
            while (loopy == true)
            {
                this.Deck.ShuffleDeck();
                while (rightGuess < 3)
                {
                    RoundStart();
                }
                NextPlayer();
            }
        }

        public void RoundStart()
        {
            Card newCard = this.Deck.DrawCard();
            Card newCard2 = this.Deck.DrawCard();
            Console.WriteLine(newCard.GetRanks() + " " + newCard.GetSuite());
            this.JokerRule(newCard, newCard2, player1);
            this.PlayerChoice(newCard,newCard2,player1);
        }

        public void PlayerChoice(Card newCard, Card newCard2, Player player1)
        {
            Console.WriteLine("Is the next card Higher(o) or lower(u): ");
            char guess = Convert.ToChar(Console.ReadLine());
            if (guess == 'o')
            {
                if (newCard2.GetRanks() > newCard.GetRanks())
                {
                    rightGuess++;
                    player1.SetGuessedRight(rightGuess);
                    Console.WriteLine(newCard2.GetRanks() + " " + newCard2.GetSuite());
                    Console.WriteLine("You got {0} right so far!\n", rightGuess);
                }
                else
                {
                    wrongGuess++;
                    player1.SetGuessedWrong(wrongGuess);
                    Console.WriteLine(newCard2.GetRanks() + " " + newCard2.GetSuite());
                    Console.WriteLine("Wrong!");
                    Console.WriteLine("\n");
                }
            }
            else if (guess == 'u')
            {
                if (newCard2.GetRanks() < newCard.GetRanks())
                {
                    rightGuess++;
                    player1.SetGuessedRight(rightGuess);
                    Console.WriteLine(newCard2.GetRanks() + " " + newCard2.GetSuite());
                    Console.WriteLine("You got {0} right so far!\n", rightGuess);
                }
                else
                {
                    wrongGuess++;
                    player1.SetGuessedWrong(wrongGuess);
                    Console.WriteLine(newCard2.GetRanks() + " " + newCard2.GetSuite());
                    Console.WriteLine("Wrong!");
                    Console.WriteLine("\n");
                }
            }
        }

        public void NextPlayer()
        {
            Console.Clear();
            rightGuess = 0;
            int pointCount = wrongGuess;
            playerPoints1[nextPlayerCounter] = pointCount;
            nextPlayerCounter++;
            if (nextPlayerCounter == 2)
            {
                loopy = false;
                Console.WriteLine("Player1 Loserpoints: {0}", playerPoints1[0]);
                Console.WriteLine("Player2 Loserpoints: {0}", playerPoints1[1]);
            }
        }

        public void JokerRule(Card newCard, Card newCard2, Player player1)
        {
            if (newCard.GetRanks() == ranks.Joker)
            {
                Console.WriteLine("Haha Joker you lost!!");
                wrongGuess++;
                player1.SetGuessedWrong(wrongGuess);
                Console.WriteLine("\n");
                newCard = this.Deck.DrawCard();
                Console.WriteLine(newCard.GetRanks() + " " + newCard.GetSuite());
            }
        }

    }
}
