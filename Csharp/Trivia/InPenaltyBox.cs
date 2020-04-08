using System;

namespace UglyTrivia
{
    public class InPenaltyBox : Base, Action
    {
        public InPenaltyBox(CurrentPlayer currentPlayer, PlayerNames names, Places places, Purses purses, PenaltyBox penaltyBox, Categories categories, QuestionsByCategory questions, bool[] isGettingOutOfPenaltyBox)
            : base(currentPlayer, names, places, purses, penaltyBox, categories, questions, isGettingOutOfPenaltyBox)
        {
        }

        public virtual bool Execute()
        {
            if (this.isGettingOutOfPenaltyBox[0])
            {
                this.Println();
                this.purses.Inc();
                bool winner = this.DidPlayerWin();
                this.currentPlayer.Inc();
                return winner;
            }
            else
            {
                this.currentPlayer.Inc();
                return true;
            }
        }

        private void Println()
        {
            Console.WriteLine("Answer was correct!!!!");
        }

        private bool DidPlayerWin()
        {
            return !(this.purses.Current() == 6);
        }
    }
}
