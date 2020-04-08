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

        public virtual bool IsIn()
        {
            return this.Get(this.currentPlayer.Get());
        }

        public virtual void Println()
        {
            Console.WriteLine(this.names.Get() + " was sent to the penalty box");
        }
    }
}
