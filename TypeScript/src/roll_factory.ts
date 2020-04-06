import { Action } from "./action";
import { Base } from "./base";
import { Categories } from "./categories";
import { CurrentPlayer } from "./current_player";
import { PenaltyBox } from "./penalty_box";
import { PenaltyBoxRollFactory } from "./penalty_box_roll_factory";
import { Places } from "./places";
import { PlayerNames } from "./player_names";
import { Purses } from "./purses";
import { QuestionsByCategory } from "./questions_by_category";

export class RollFactory extends Base {

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

    public create(rand: any): Action {
        const roll: number = this.calcRoll(rand);
        if (this.penaltyBox.isIn()) {
            const factory: PenaltyBoxRollFactory = new PenaltyBoxRollFactory(this.currentPlayer,
                this.names,
                this.places,
                this.purses,
                this.penaltyBox,
                this.categories,
                this.questions,
                this.isGettingOutOfPenaltyBox,
                roll);
            return factory.create();
        } else {
            return new Roll(this.currentPlayer,
                this.names,
                this.places,
                this.purses,
                this.penaltyBox,
                this.categories,
                this.questions,
                this.isGettingOutOfPenaltyBox,
                roll);
        }
    }

    private calcRoll(rand: any): number {
        return rand.nextInt(5) + 1;
    }
}
