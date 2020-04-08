using System;

namespace UglyTrivia
{
    public class PenaltyBoxRoll : Base, Action
    {
        private int roll;

        public PenaltyBoxRoll(CurrentPlayer currentPlayer, PlayerNames names, Places places, Purses purses, PenaltyBox penaltyBox, Categories categories, QuestionsByCategory questions, bool[] isGettingOutOfPenaltyBox, int roll)
            : base(currentPlayer, names, places, purses, penaltyBox, categories, questions, isGettingOutOfPenaltyBox)
        {
            this.roll = roll;
        }

        public virtual bool Execute()
        {
            this.Println();
            this.isGettingOutOfPenaltyBox[0] = false;
            return false;
        }

        private void Println()
        {
            this.names.Println();
            Console.WriteLine("They have rolled a " + this.roll);
            Console.WriteLine(this.names.Get() + " is not getting out of the penalty box");
        }
    }
}
