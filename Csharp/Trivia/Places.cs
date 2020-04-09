using System;

namespace UglyTrivia
{
    public class Places : CurrentArray<int>
    {
        internal PlayerNames names;

        public Places(CurrentPlayer currentPlayer, PlayerNames names)
            : base(currentPlayer, 0)
        {
            this.names = names;
        }

        public void Add(int roll)
        {
            this.Set(this.currentPlayer.Get(), this.Current() + roll);
        }

        public void PrintlnPlace()
        {
            Console.WriteLine(this.names.Get()
                + "'s new location is "
                + this.Current());
        }
    }
}
