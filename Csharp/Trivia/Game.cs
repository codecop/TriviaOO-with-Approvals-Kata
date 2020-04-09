namespace UglyTrivia
{
    public class Game
    {
        internal Players players;

        internal CurrentPlayer currentPlayer;

        internal PlayerNames names;

        internal Places places;

        internal Purses purses;

        internal PenaltyBox penaltyBox;

        internal Categories categories;

        internal QuestionsByCategory questions;

        internal bool[] isGettingOutOfPenaltyBox;

        public Game()
        {
            players = new Players();
            currentPlayer = new CurrentPlayer(this.players);
            names = new PlayerNames(this.currentPlayer);
            places = new Places(this.currentPlayer, this.names);
            purses = new Purses(this.currentPlayer, this.names);
            penaltyBox = new PenaltyBox(this.currentPlayer, this.names);
            categories = new Categories(this.places);
            questions = new QuestionsByCategory(this.categories);
            isGettingOutOfPenaltyBox = new bool[1];
        }

        public bool IsPlayable()
        {
            return (this.players.Count() >= 2);
        }

        public Action GetAdd(string playerName)
        {
            return new Add(this.players, this.currentPlayer, this.names, this.places, this.purses, this.penaltyBox, this.categories, this.questions, this.isGettingOutOfPenaltyBox, playerName);
        }

        public RollFactory GetRoll()
        {
            return new RollFactory(this.currentPlayer, this.names, this.places, this.purses, this.penaltyBox, this.categories, this.questions, this.isGettingOutOfPenaltyBox);
        }

        public ActionFactory GetAnswer()
        {
            return new ActionFactory(this.currentPlayer, this.names, this.places, this.purses, this.penaltyBox, this.categories, this.questions, this.isGettingOutOfPenaltyBox);
        }
    }
}
