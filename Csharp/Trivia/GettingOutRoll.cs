using System;

namespace UglyTrivia
{
    public class GettingOutRoll : Base, Action
    {
        private int roll;

        public GettingOutRoll(CurrentPlayer currentPlayer, PlayerNames names, Places places, Purses purses, PenaltyBox penaltyBox, Categories categories, QuestionsByCategory questions, bool[] isGettingOutOfPenaltyBox, int roll)
            : base(currentPlayer, names, places, purses, penaltyBox, categories, questions, isGettingOutOfPenaltyBox)
        {
            this.roll = roll;
        }

        public virtual bool Execute()
        {
            this.Println();
            this.isGettingOutOfPenaltyBox[0] = true;
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
            Console.WriteLine(this.names.Get() + " is getting out of the penalty box");
        }
    }
}
