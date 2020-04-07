import { Categories } from "./categories";
import { Questions } from "./questions";

export class QuestionsByCategory {

    popQuestions: Questions = new PopQuestions();
    scienceQuestions: Questions = new ScienceQuestions();
    sportsQuestions: Questions = new SportsQuestions();
    rockQuestions: Questions = new RockQuestions();

    private categories: Categories;

    public constructor(categories: Categories) {
        this.categories = categories;
    }

    public ask(): void {
        if (this.categories.currentCategory() === "Pop")
            this.popQuestions.askQuestion();
        if (this.categories.currentCategory() === "Science")
            this.scienceQuestions.askQuestion();
        if (this.categories.currentCategory() === "Sports")
            this.sportsQuestions.askQuestion();
        if (this.categories.currentCategory() === "Rock")
            this.rockQuestions.askQuestion();
    }

}
