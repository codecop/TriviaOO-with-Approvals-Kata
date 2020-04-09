namespace UglyTrivia
{
    public class RockQuestions : Questions
    {
        public RockQuestions()
            : base("Rock")
        {
        }

        public string CreateRockQuestion(int index)
        {
            return "Rock Question " + index;
        }
    }
}
