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

        public bool Execute()
        {
            Println();
            isGettingOutOfPenaltyBox[0] = false;
            return false;
        }

        private void Println()
        {
            names.Println();
            Console.WriteLine("They have rolled a " + roll);
            Console.WriteLine(names.Get() + " is not getting out of the penalty box");
        }
    }
}
