namespace UglyTrivia
{
    public class CurrentArray<T> : Array6<T>
    {
        internal CurrentPlayer currentPlayer;

        public CurrentArray(CurrentPlayer currentPlayer, T init)
            : base(init)
        {
            this.currentPlayer = currentPlayer;
        }

        public virtual T Current()
        {
            return this.Get(this.currentPlayer.Get());
        }
    }
}
