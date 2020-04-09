using System;

namespace UglyTrivia
{
    public class Places : CurrentArray<int>
    {
        PlayerNames names;

        public Places(CurrentPlayer currentPlayer, PlayerNames names)
            : base(currentPlayer, 0)
        {
            this.names = names;
        }

        public void Add(int roll)
        {
            Set(currentPlayer.Get(), Current() + roll);
        }

        public void PrintlnPlace()
        {
            Console.WriteLine(names.Get()
                + "'s new location is "
                + Current());
        }
    }
}
