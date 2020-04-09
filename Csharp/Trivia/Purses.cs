using System;

namespace UglyTrivia
{
    public class Purses : CurrentArray<int>
    {
        PlayerNames names;

        public Purses(CurrentPlayer currentPlayer, PlayerNames names)
            : base(currentPlayer, 0)
        {
            this.names = names;
        }

        public void Inc()
        {
            Add();
            Println();
        }

        private void Add()
        {
            Set(currentPlayer.Get(), Current() + 1);
        }

        private void Println()
        {
            Console.WriteLine(names.Get()
                + " now has "
                + Current()
                + " Gold Coins.");
        }
    }
}
