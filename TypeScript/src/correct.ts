import { Action } from "./action";
import { Base } from "./base";
import { Categories } from "./categories";
import { CurrentPlayer } from "./current_player";
import { PenaltyBox } from "./penalty_box";
import { Places } from "./places";
import { PlayerNames } from "./player_names";
import { Purses } from "./purses";
import { QuestionsByCategory } from "./questions_by_category";

export class Correct extends Base implements Action {

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

    public execute(): boolean {
        this.println();
        this.purses.inc();

        const winner: boolean = this.didPlayerWin();
        this.currentPlayer.inc();

        return winner;
    }

    private println(): void {
        console.log("Answer was corrent!!!!");
    }

    private didPlayerWin(): boolean {
        return !(this.purses.current() === 6);
    }

}
