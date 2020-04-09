namespace UglyTrivia
{
    public class CorrectFactory : Base
    {
        public CorrectFactory(CurrentPlayer currentPlayer, PlayerNames names, Places places, Purses purses, PenaltyBox penaltyBox, Categories categories, QuestionsByCategory questions, bool[] isGettingOutOfPenaltyBox)
            : base(currentPlayer, names, places, purses, penaltyBox, categories, questions, isGettingOutOfPenaltyBox)
        {
        }

        public Action Create()
        {
            if (penaltyBox.IsIn())
            {
                return new InPenaltyBox(currentPlayer, names, places, purses, penaltyBox, categories, questions, isGettingOutOfPenaltyBox);
            }
            else
            {
                return new Correct(currentPlayer, names, places, purses, penaltyBox, categories, questions, isGettingOutOfPenaltyBox);
            }
        }
    }
}
