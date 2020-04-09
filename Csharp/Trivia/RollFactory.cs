using System;

namespace UglyTrivia
{
    public class RollFactory : Base
    {
        public RollFactory(CurrentPlayer currentPlayer, PlayerNames names, Places places, Purses purses, PenaltyBox penaltyBox, Categories categories, QuestionsByCategory questions, bool[] isGettingOutOfPenaltyBox)
            : base(currentPlayer, names, places, purses, penaltyBox, categories, questions, isGettingOutOfPenaltyBox)
        {
        }

        public Action Create(Random rand)
        {
            int roll = this.CalcRoll(rand);
            if (this.penaltyBox.IsIn())
            {
                PenaltyBoxRollFactory factory = new PenaltyBoxRollFactory(this.currentPlayer, this.names, this.places, this.purses, this.penaltyBox, this.categories, this.questions, this.isGettingOutOfPenaltyBox, roll);
                return factory.Create();
            }
            else
            {
                return new Roll(this.currentPlayer, this.names, this.places, this.purses, this.penaltyBox, this.categories, this.questions, this.isGettingOutOfPenaltyBox, roll);
            }
        }

        private int CalcRoll(Random rand)
        {
            return rand.Next(5) + 1;
        }
    }
}
