using System;
using System.Collections.Generic;
using System.Text;

namespace SpillekortSpil
{
    public class GameController
    {
        bool loopy = true;   
        int x = 0;
        int[] playerPoints1 = new int[2];
        public void StartGame2()
        {
            while (loopy == true)
            {
                RoundStart2();
            }
        }

        public void RoundStart2()
        {
            DeckOfCards Deck = new DeckOfCards(4);
            Player player1 = new Player(0, 0, 0);
            Deck.ShuffleDeck();
            int c = 0;
            int g = 0;
            int w = 0;
            while (player1.playerGuess() < 3)
            {
                var newCard = Deck.GetDeck()[c];
                Console.WriteLine(newCard.GetRanks() + " " + newCard.GetSuite());
                if (newCard.GetRanks() == ranks.Joker)
                {
                    Console.WriteLine("Haha Joker you lost!!");
                    w++;
                    player1.SetGuessedWrong(w);
                    c++;
                    Console.WriteLine("\n");
                    newCard = Deck.GetDeck()[c];
                    Console.WriteLine(newCard.GetRanks() + " " + newCard.GetSuite());
                }
                Console.WriteLine("Is the next card Higher(o) or lower(u): ");
                char guess = Convert.ToChar(Console.ReadLine());
                c++;
                var newCard2 = Deck.GetDeck()[c];
                Console.WriteLine(newCard2.GetRanks() + " " + newCard2.GetSuite());
                c++;
                if (guess == 'o')
                {
                    if (newCard2.GetRanks() > newCard.GetRanks())
                    {
                        g++;
                        player1.SetGuessedRight(g);
                        Console.WriteLine("You got {0} right so far!\n", g);
                    }
                    else
                    {
                        w++;
                        player1.SetGuessedWrong(w);
                        Console.WriteLine("Wrong!");
                        Console.WriteLine("\n");
                    }
                }
                else if (guess == 'u')
                {
                    if (newCard2.GetRanks() < newCard.GetRanks())
                    {
                        g++;
                        player1.SetGuessedRight(g);
                        Console.WriteLine("You got {0} right so far!\n", g);
                    }
                    else
                    {
                        w++;
                        player1.SetGuessedWrong(w);
                        Console.WriteLine("Wrong!");
                        Console.WriteLine("\n");
                    }
                }
            }
            Console.Clear();
            Console.WriteLine("Press enter to start next player");
            int pointCount = w;
            playerPoints1[x] = pointCount;
            x++;
            Console.ReadLine();
            if (x == 2)
            {
                loopy = false;
                Console.WriteLine("Player1 Loserpoints: {0}", playerPoints1[0]);
                Console.WriteLine("Player2 Loserpoints: {0}", playerPoints1[1]);
            }
        }

        public void CardGuess()
        {

        }
    }
}
