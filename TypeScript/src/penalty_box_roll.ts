import { Action } from "./action";
import { Base } from "./base";
import { Categories } from "./categories";
import { CurrentPlayer } from "./current_player";
import { PenaltyBox } from "./penalty_box";
import { Places } from "./places";
import { PlayerNames } from "./player_names";
import { Purses } from "./purses";
import { QuestionsByCategory } from "./questions_by_category";

export class PenaltyBoxRoll extends Base implements Action {

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

    public execute(): boolean {
        this.println();
        this.isGettingOutOfPenaltyBox[0] = false;

        return false;
    }

    private println(): void {
        this.names.println();
        console.log("They have rolled a " + this.roll);
        console.log(this.names.get() + " is not getting out of the penalty box");
    }

}
