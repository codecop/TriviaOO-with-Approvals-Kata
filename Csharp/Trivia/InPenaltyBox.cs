using System;

namespace UglyTrivia
{
    public class InPenaltyBox : Base, Action
    {
        public InPenaltyBox(CurrentPlayer currentPlayer, PlayerNames names, Places places, Purses purses, PenaltyBox penaltyBox, Categories categories, QuestionsByCategory questions, bool[] isGettingOutOfPenaltyBox)
            : base(currentPlayer, names, places, purses, penaltyBox, categories, questions, isGettingOutOfPenaltyBox)
        {
        }

        public bool Execute()
        {
            if (isGettingOutOfPenaltyBox[0])
            {
                Println();
                purses.Inc();
                bool winner = DidPlayerWin();
                currentPlayer.Inc();
                return winner;
            }
            else
            {
                currentPlayer.Inc();
                return true;
            }
        }

        private void Println()
        {
            Console.WriteLine("Answer was correct!!!!");
        }

        private bool DidPlayerWin()
        {
            return !(purses.Current() == 6);
        }
    }
}
