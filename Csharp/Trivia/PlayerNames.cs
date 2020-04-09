using System;

namespace UglyTrivia
{
    public class PlayerNames : Players
    {
        internal CurrentPlayer currentPlayer;

        public PlayerNames(CurrentPlayer currentPlayer)
        {
            this.currentPlayer = currentPlayer;
        }

        public object Get()
        {
            return this.elements[this.currentPlayer.Get()];
        }

        public override void Println()
        {
            Console.WriteLine(this.Get() + " is the current player");
        }
    }
}
