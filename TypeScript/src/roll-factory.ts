import { Action } from "./action";
import { Base } from "./base";
import { Categories } from "./categories";
import { CurrentPlayer } from "./current-player";
import { PenaltyBox } from "./penalty-box";
import { PenaltyBoxRollFactory } from "./penalty-box-roll-factory";
import { Places } from "./places";
import { PlayerNames } from "./player-names";
import { Purses } from "./purses";
import { QuestionsByCategory } from "./questions-by-category";
import { Roll } from "./roll";

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

    public create(random): Action {
        const roll: number = this.calcRoll(random);
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

    private calcRoll(random): number {
        return Math.floor(random() * 6) + 1;
    }
}
