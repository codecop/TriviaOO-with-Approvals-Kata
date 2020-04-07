import { Categories } from "./categories";
import { PopQuestions } from "./pop-questions";
import { RockQuestions } from "./rock-questions";
import { ScienceQuestions } from "./science-questions";
import { SportsQuestions } from "./sports-questions";

export class QuestionsByCategory {

    popQuestions = new PopQuestions();
    scienceQuestions = new ScienceQuestions();
    sportsQuestions = new SportsQuestions();
    rockQuestions = new RockQuestions();

    private categories: Categories;

    public constructor(categories: Categories) {
        this.categories = categories;
    }

    public ask(): void {
        if (this.categories.currentCategory() == 'Pop')
            this.popQuestions.askQuestion();
        if (this.categories.currentCategory() == 'Science')
            this.scienceQuestions.askQuestion();
        if (this.categories.currentCategory() == 'Sports')
            this.sportsQuestions.askQuestion();
        if (this.categories.currentCategory() == 'Rock')
            this.rockQuestions.askQuestion();
    }

}
