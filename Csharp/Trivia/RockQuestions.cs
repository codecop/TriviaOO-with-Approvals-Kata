using System;

namespace UglyTrivia
{
    public class RockQuestions : Questions
    {
        public RockQuestions()
            : base("Rock")
        {
        }

        public String CreateRockQuestion(int index)
        {
            return "Rock Question " + index;
        }
    }
}
