using System;

namespace UglyTrivia
{
    public class PenaltyBox : Array6<bool>
    {
        internal CurrentPlayer currentPlayer;

        internal PlayerNames names;

        public PenaltyBox(CurrentPlayer currentPlayer, PlayerNames names)
            : base(false)
        {
            this.currentPlayer = currentPlayer;
            this.names = names;
        }

        public bool IsIn()
        {
            return this.Get(this.currentPlayer.Get());
        }

        public void Println()
        {
            Console.WriteLine(this.names.Get() + " was sent to the penalty box");
        }
    }
}
