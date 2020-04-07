import { Action } from "./action";
import { Base } from "./base";
import { Categories } from "./categories";
import { CurrentPlayer } from "./current-player";
import { PenaltyBox } from "./penalty-box";
import { Places } from "./places";
import { PlayerNames } from "./player-names";
import { Purses } from "./purses";
import { QuestionsByCategory } from "./questions-by-category";


export class Roll extends Base implements Action {

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

        this.places.add(this.roll);
        if (this.places.get(this.currentPlayer.get()) > 11) this.places.set(this.currentPlayer.get(), this.places.get(this.currentPlayer.get()) - 12);
        this.places.printlnPlace();

        this.categories.println();
        this.questions.ask();

        return false;
    }

    private println(): void {
        this.names.println();
        console.log("They have rolled a " + this.roll);
    }

}
