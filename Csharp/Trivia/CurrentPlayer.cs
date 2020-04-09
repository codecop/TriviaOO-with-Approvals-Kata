namespace UglyTrivia
{
    public class CurrentPlayer
    {
        Players players;

        int currentPlayer = 0;

        public CurrentPlayer(Players players)
        {
            this.players = players;
        }

        public int Get()
        {
            return currentPlayer;
        }

        public void Inc()
        {
            currentPlayer++;
            if (currentPlayer == players.Count()) currentPlayer = 0;
        }
    }
}
