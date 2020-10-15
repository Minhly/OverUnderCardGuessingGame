using System;
using System.Collections.Generic;
using System.Text;

namespace SpillekortSpil
{
    public class Player
    {

        private int cardDraw;
        private int guessedRight;
        private int points;

        public Player(int cardDraw, int guessedRight, int points)
        {
            this.cardDraw = cardDraw;
            this.guessedRight = guessedRight;
            this.points = points;
        }

        public void SetGuessedRight(int guessRight)
        {
            guessedRight = guessRight;
        }

        public void SetGuessedWrong(int guessWrong)
        {
            points = guessWrong;
        }

        public void SetPlayerGuess(int guess)
        {
            guessedRight = guess;
        }

        public int playerGuess()
        {
            return guessedRight;
        }

        public int playerPoints()
        {
            return points;
        }


    }
}
