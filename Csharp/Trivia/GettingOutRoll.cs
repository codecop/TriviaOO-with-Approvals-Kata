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

        public bool Execute()
        {
            Println();
            isGettingOutOfPenaltyBox[0] = true;
            places.Add(roll);
            if (places.Get(currentPlayer.Get()) > 11) places.Set(currentPlayer.Get(), places.Get(currentPlayer.Get()) - 12);
            places.PrintlnPlace();
            categories.Println();
            questions.Ask();
            return false;
        }

        private void Println()
        {
            names.Println();
            Console.WriteLine("They have rolled a " + roll);
            Console.WriteLine(names.Get() + " is getting out of the penalty box");
        }
    }
}
