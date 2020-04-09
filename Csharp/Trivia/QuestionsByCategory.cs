namespace UglyTrivia
{
    public class QuestionsByCategory
    {
        Questions popQuestions = new PopQuestions();

        Questions scienceQuestions = new ScienceQuestions();

        Questions sportsQuestions = new SportsQuestions();

        Questions rockQuestions = new RockQuestions();

        private Categories categories;

        public QuestionsByCategory(Categories categories)
        {
            this.categories = categories;
        }

        public void Ask()
        {
            if (categories.CurrentCategory() == "Pop")
            {
                popQuestions.AskQuestion();
            }
            if (categories.CurrentCategory() == "Science")
            {
                scienceQuestions.AskQuestion();
            }
            if (categories.CurrentCategory() == "Sports")
            {
                sportsQuestions.AskQuestion();
            }
            if (categories.CurrentCategory() == "Rock")
            {
                rockQuestions.AskQuestion();
            }
        }
    }
}
