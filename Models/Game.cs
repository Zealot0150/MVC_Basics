namespace MVC_Basics.Models
{
    public class Game
    {
        public static int nrGuess = 0;
        public static string Guess(int guessedNumber, int numberToGuess, out bool won)
        {
            nrGuess++;
            won = false;
            if (guessedNumber == numberToGuess)
            {
                won = true;
                return "Du gissa rätt";
            }
            else if (guessedNumber > numberToGuess)
                return "Du gissade för högt ";
            else
                return "Du gissade för lågt";
        }
        public static string NrTries { get { return "" + nrGuess; } }
        public static void Reset()
        {
            nrGuess = 0;
        }
    }



}
