using System;

namespace UglyTrivia
{
    public class PlayerNames : Players
    {
        CurrentPlayer currentPlayer;

        public PlayerNames(CurrentPlayer currentPlayer)
        {
            this.currentPlayer = currentPlayer;
        }

        public String Get()
        {
            return elements[currentPlayer.Get()];
        }

        public override void Println()
        {
            Console.WriteLine(Get() + " is the current player");
        }
    }
}
