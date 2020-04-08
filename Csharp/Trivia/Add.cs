namespace UglyTrivia
{
    public class Add : Base, Action
    {
        private Players players;

        private string playerName;

        public Add(Players players, CurrentPlayer currentPlayer, PlayerNames names, Places places, Purses purses, PenaltyBox penaltyBox, Categories categories, QuestionsByCategory questions, bool[] isGettingOutOfPenaltyBox, string playerName)
            : base(currentPlayer, names, places, purses, penaltyBox, categories, questions, isGettingOutOfPenaltyBox)
        {
            this.players = players;
            this.playerName = playerName;
        }

        public virtual bool Execute()
        {
            this.players.Add(this.playerName);
            this.names.Add(this.playerName);
            this.places.Set(this.players.Count(), 0);
            this.purses.Set(this.players.Count(), 0);
            this.penaltyBox.Set(this.players.Count(), false);
            this.players.Println();
            return true;
        }
    }
}
