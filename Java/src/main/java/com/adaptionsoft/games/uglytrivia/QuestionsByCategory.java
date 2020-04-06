package com.adaptionsoft.games.uglytrivia;

public class QuestionsByCategory {

    Questions popQuestions = new PopQuestions();
    Questions scienceQuestions = new ScienceQuestions();
    Questions sportsQuestions = new SportsQuestions();
    Questions rockQuestions = new RockQuestions();
    
    private Categories categories;

    public QuestionsByCategory(Categories categories) {
        this.categories = categories;
    }

    public void ask() {
        if (categories.currentCategory() == "Pop")
            popQuestions.askQuestion();
        if (categories.currentCategory() == "Science")
            scienceQuestions.askQuestion();
        if (categories.currentCategory() == "Sports")
            sportsQuestions.askQuestion();
        if (categories.currentCategory() == "Rock")
            rockQuestions.askQuestion();
    }
    
}
