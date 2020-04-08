namespace UglyTrivia
{
    public class QuestionsByCategory
    {
        internal Questions popQuestions = new PopQuestions();

        internal Questions scienceQuestions = new ScienceQuestions();

        internal Questions sportsQuestions = new SportsQuestions();

        internal Questions rockQuestions = new RockQuestions();

        private Categories categories;

        public QuestionsByCategory(Categories categories)
        {
            this.categories = categories;
        }

        public virtual void Ask()
        {
            if (this.categories.CurrentCategory() == "Pop")
            {
                this.popQuestions.AskQuestion();
            }
            if (this.categories.CurrentCategory() == "Science")
            {
                this.scienceQuestions.AskQuestion();
            }
            if (this.categories.CurrentCategory() == "Sports")
            {
                this.sportsQuestions.AskQuestion();
            }
            if (this.categories.CurrentCategory() == "Rock")
            {
                this.rockQuestions.AskQuestion();
            }
        }
    }
}
