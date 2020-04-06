import { Action } from "./action";
import { Base } from "./base";
import { Categories } from "./categories";
import { CurrentPlayer } from "./current_player";
import { GettingOutRoll } from "./getting_out_roll";
import { PenaltyBox } from "./penalty_box";
import { PenaltyBoxRoll } from "./penalty_box_roll";
import { Places } from "./places";
import { PlayerNames } from "./player_names";
import { Purses } from "./purses";
import { QuestionsByCategory } from "./questions_by_category";

export class PenaltyBoxRollFactory extends Base {

    private roll: number;

    public constructor(
        currentPlayer: CurrentPlayer,
        names: PlayerNames,
        places: Places,
        purses: Purses,
        penaltyBox: PenaltyBox,
        categories: Categories,
        questions: QuestionsByCategory,
        isGettingOutOfPenaltyBox: boolean[],
        roll: number) {
        super(currentPlayer,
            names,
            places,
            purses,
            penaltyBox,
            categories,
            questions,
            isGettingOutOfPenaltyBox);

        this.roll = roll;
    }

    public create(): Action {
        if (this.roll % 2 !== 0) {
            return new GettingOutRoll(this.currentPlayer,
                this.names,
                this.places,
                this.purses,
                this.penaltyBox,
                this.categories,
                this.questions,
                this.isGettingOutOfPenaltyBox,
                this.roll);
        } else {
            return new PenaltyBoxRoll(this.currentPlayer,
                this.names,
                this.places,
                this.purses,
                this.penaltyBox,
                this.categories,
                this.questions,
                this.isGettingOutOfPenaltyBox,
                this.roll);
        }
    }

}
