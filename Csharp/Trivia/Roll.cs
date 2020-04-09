using System;

namespace UglyTrivia
{
    public class Roll : Base, Action
    {
        private int roll;

        public Roll(CurrentPlayer currentPlayer, PlayerNames names, Places places, Purses purses, PenaltyBox penaltyBox, Categories categories, QuestionsByCategory questions, bool[] isGettingOutOfPenaltyBox, int roll)
            : base(currentPlayer, names, places, purses, penaltyBox, categories, questions, isGettingOutOfPenaltyBox)
        {
            this.roll = roll;
        }

        public bool Execute()
        {
            this.Println();
            this.places.Add(this.roll);
            if (this.places.Get(this.currentPlayer.Get()) > 11)
            {
                this.places.Set(this.currentPlayer.Get(), this.places.Get(this.currentPlayer.Get()) - 12);
            }
            this.places.PrintlnPlace();
            this.categories.Println();
            this.questions.Ask();
            return false;
        }

        private void Println()
        {
            this.names.Println();
            Console.WriteLine("They have rolled a " + this.roll);
        }
    }
}
