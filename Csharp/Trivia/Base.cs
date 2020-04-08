namespace UglyTrivia
{
    public abstract class Base
    {
        internal CurrentPlayer currentPlayer;

        internal PlayerNames names;

        internal Places places;

        internal Purses purses;

        internal PenaltyBox penaltyBox;

        internal Categories categories;

        internal QuestionsByCategory questions;

        internal bool[] isGettingOutOfPenaltyBox;

        public Base(CurrentPlayer currentPlayer, PlayerNames names, Places places, Purses purses, PenaltyBox penaltyBox, Categories categories, QuestionsByCategory questions, bool[] isGettingOutOfPenaltyBox)
        {
            this.currentPlayer = currentPlayer;
            this.names = names;
            this.places = places;
            this.purses = purses;
            this.penaltyBox = penaltyBox;
            this.categories = categories;
            this.questions = questions;
            this.isGettingOutOfPenaltyBox = isGettingOutOfPenaltyBox;
        }
    }
}
