using System;

namespace UglyTrivia
{
    public class Add : Base, Action
    {
        private Players players;

        private String playerName;

        public Add(Players players, CurrentPlayer currentPlayer, PlayerNames names, Places places, Purses purses, PenaltyBox penaltyBox, Categories categories, QuestionsByCategory questions, bool[] isGettingOutOfPenaltyBox, String playerName)
            : base(currentPlayer, names, places, purses, penaltyBox, categories, questions, isGettingOutOfPenaltyBox)
        {
            this.players = players;
            this.playerName = playerName;
        }

        public bool Execute()
        {
            players.Add(playerName);
            names.Add(playerName);
            places.Set(players.Count(), 0);
            purses.Set(players.Count(), 0);
            penaltyBox.Set(players.Count(), false);
            players.Println();
            return true;
        }
    }
}
