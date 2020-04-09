using System;

namespace UglyTrivia
{
    public class Correct : Base, Action
    {
        public Correct(CurrentPlayer currentPlayer, PlayerNames names, Places places, Purses purses, PenaltyBox penaltyBox, Categories categories, QuestionsByCategory questions, bool[] isGettingOutOfPenaltyBox)
            : base(currentPlayer, names, places, purses, penaltyBox, categories, questions, isGettingOutOfPenaltyBox)
        {
        }

        public bool Execute()
        {
            this.Println();
            this.purses.Inc();
            bool winner = this.DidPlayerWin();
            this.currentPlayer.Inc();
            return winner;
        }

        private void Println()
        {
            Console.WriteLine("Answer was corrent!!!!");
        }

        private bool DidPlayerWin()
        {
            return !(this.purses.Current() == 6);
        }
    }
}
