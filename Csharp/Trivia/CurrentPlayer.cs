namespace UglyTrivia
{
    public class CurrentPlayer
    {
        internal Players players;

        internal int currentPlayer = 0;

        public CurrentPlayer(Players players)
        {
            this.players = players;
        }

        public int Get()
        {
            return this.currentPlayer;
        }

        public void Inc()
        {
            this.currentPlayer++;
            if (this.currentPlayer == this.players.Count()) this.currentPlayer = 0;
        }
    }
}
