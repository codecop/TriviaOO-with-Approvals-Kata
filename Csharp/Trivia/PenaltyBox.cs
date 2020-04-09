using System;

namespace UglyTrivia
{
    public class PenaltyBox : Array6<bool>
    {
        CurrentPlayer currentPlayer;

        PlayerNames names;

        public PenaltyBox(CurrentPlayer currentPlayer, PlayerNames names)
            : base(false)
        {
            this.currentPlayer = currentPlayer;
            this.names = names;
        }

        public bool IsIn()
        {
            return Get(currentPlayer.Get());
        }

        public void Println()
        {
            Console.WriteLine(names.Get() + " was sent to the penalty box");
        }
    }
}
