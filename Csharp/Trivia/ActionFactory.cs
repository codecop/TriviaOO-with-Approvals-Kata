using System;

namespace UglyTrivia
{
    public class ActionFactory : Base
    {
        public ActionFactory(CurrentPlayer currentPlayer, PlayerNames names, Places places, Purses purses, PenaltyBox penaltyBox, Categories categories, QuestionsByCategory questions, bool[] isGettingOutOfPenaltyBox)
            : base(currentPlayer, names, places, purses, penaltyBox, categories, questions, isGettingOutOfPenaltyBox)
        {
        }

        public Action Create(Random rand)
        {
            Action action;
            if (rand.Next(9) == 7)
            {
                action = this.WrongAnswer();
            }
            else
            {
                action = this.WasCorrectlyAnswered();
            }
            return action;
        }

        public Action WasCorrectlyAnswered()
        {
            CorrectFactory factory = new CorrectFactory(this.currentPlayer, this.names, this.places, this.purses, this.penaltyBox, this.categories, this.questions, this.isGettingOutOfPenaltyBox);
            return factory.Create();
        }

        public Action WrongAnswer()
        {
            return new Wrong(this.currentPlayer, this.names, this.places, this.purses, this.penaltyBox, this.categories, this.questions, this.isGettingOutOfPenaltyBox);
        }
    }
}
