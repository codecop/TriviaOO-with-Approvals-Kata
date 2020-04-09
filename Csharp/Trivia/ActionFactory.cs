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
                action = WrongAnswer();
            }
            else
            {
                action = WasCorrectlyAnswered();
            }
            return action;
        }

        public Action WasCorrectlyAnswered()
        {
            CorrectFactory factory = new CorrectFactory(currentPlayer, names, places, purses, penaltyBox, categories, questions, isGettingOutOfPenaltyBox);
            return factory.Create();
        }

        public Action WrongAnswer()
        {
            return new Wrong(currentPlayer, names, places, purses, penaltyBox, categories, questions, isGettingOutOfPenaltyBox);
        }
    }
}
