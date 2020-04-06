import { Array6 } from "./array6";
import { CurrentPlayer } from "./current_player";
import { PlayerNames } from "./player_names";

export class PenaltyBox extends Array6<boolean> {

    currentPlayer: CurrentPlayer;
    names: PlayerNames;

    public constructor(currentPlayer: CurrentPlayer, names: PlayerNames) {
        super(false);
        this.currentPlayer = currentPlayer;
        this.names = names;
    }

    public isIn(): boolean {
        return this.get(this.currentPlayer.get());
    }

    public println(): void {
        console.log(this.names.get() + " was sent to the penalty box");
    }

}
