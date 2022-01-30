namespace MVC_Basics.Models
{
    public class Game
    {
        public string Guess(int guessedNumber, int numberToGuess, out bool won)
        {
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
    }
}
