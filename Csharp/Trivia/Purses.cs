using System;

namespace UglyTrivia
{
    public class Purses : CurrentArray<int>
    {
        internal PlayerNames names;

        public Purses(CurrentPlayer currentPlayer, PlayerNames names)
            : base(currentPlayer, 0)
        {
            this.names = names;
        }

        public virtual void Inc()
        {
            this.Add();
            this.Println();
        }

        private void Add()
        {
            this.Set(this.currentPlayer.Get(), this.Current() + 1);
        }

        private void Println()
        {
            Console.WriteLine(this.names.Get() + " now has " + this.Current() + " Gold Coins.");
        }
    }
}
