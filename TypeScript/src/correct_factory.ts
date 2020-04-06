import { Action } from "./action";
import { Base } from "./base";
import { Categories } from "./categories";
import { Correct } from "./correct";
import { CurrentPlayer } from "./current_player";
import { InPenaltyBox } from "./in_penalty_box";
import { PenaltyBox } from "./penalty_box";
import { Places } from "./places";
import { PlayerNames } from "./player_names";
import { Purses } from "./purses";
import { QuestionsByCategory } from "./questions_by_category";

export class CorrectFactory extends Base {

    public constructor(
        currentPlayer: CurrentPlayer,
        names: PlayerNames,
        places: Places,
        purses: Purses,
        penaltyBox: PenaltyBox,
        categories: Categories,
        questions: QuestionsByCategory,
        isGettingOutOfPenaltyBox: boolean[]) {
        super(currentPlayer,
            names,
            places,
            purses,
            penaltyBox,
            categories,
            questions,
            isGettingOutOfPenaltyBox);
    }

    public create(): Action {
        if (this.penaltyBox.isIn()) {
            return new InPenaltyBox(this.currentPlayer,
                this.names,
                this.places,
                this.purses,
                this.penaltyBox,
                this.categories,
                this.questions,
                this.isGettingOutOfPenaltyBox);
        } else {
            return new Correct(this.currentPlayer,
                this.names,
                this.places,
                this.purses,
                this.penaltyBox,
                this.categories,
                this.questions,
                this.isGettingOutOfPenaltyBox);
        }
    }

}
