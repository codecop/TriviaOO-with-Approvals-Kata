import { Action } from "./action";
import { Base } from "./base";
import { Categories } from "./categories";
import { CurrentPlayer } from "./current-player";
import { PenaltyBox } from "./penalty-box";
import { Places } from "./places";
import { PlayerNames } from "./player-names";
import { Players } from "./players";
import { Purses } from "./purses";
import { QuestionsByCategory } from "./questions-by-category";

export class Add extends Base implements Action {

    private players: Players;
    private playerName: string;

    public constructor(
        players: Players,
        currentPlayer: CurrentPlayer,
        names: PlayerNames,
        places: Places,
        purses: Purses,
        penaltyBox: PenaltyBox,
        categories: Categories,
        questions: QuestionsByCategory,
        isGettingOutOfPenaltyBox: boolean[],
        playerName: string) {
        super(currentPlayer,
            names,
            places,
            purses,
            penaltyBox,
            categories,
            questions,
            isGettingOutOfPenaltyBox);

        this.players = players;
        this.playerName = playerName;
    }

    public execute(): boolean {
        this.players.add(this.playerName);
        this.names.add(this.playerName);
        this.places.set(this.players.count(), 0);
        this.purses.set(this.players.count(), 0);
        this.penaltyBox.set(this.players.count(), false);
        this.players.println();

        return true;
    }

}
