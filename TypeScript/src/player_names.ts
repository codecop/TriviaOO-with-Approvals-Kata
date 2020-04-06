import { CurrentPlayer } from "./current_player";
import { Object } from "./object";
import { Players } from "./players";

export class PlayerNames extends Players {

    currentPlayer: CurrentPlayer;

    public constructor(currentPlayer: CurrentPlayer) {
        super();
        this.currentPlayer = currentPlayer;
    }

    public get(): any {
        return this.elements.get(this.currentPlayer.get());
    }

    public println(): void {
        console.log(this.get() + " is the current player");
    }
}
