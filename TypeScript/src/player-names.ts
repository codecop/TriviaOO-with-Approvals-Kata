import { CurrentPlayer } from "./current-player";
import { Players } from "./players";

export class PlayerNames extends Players {

    currentPlayer: CurrentPlayer;

    public constructor(currentPlayer: CurrentPlayer) {
        super();
        this.currentPlayer = currentPlayer;
    }

    public get(): any {
        return this.elements[this.currentPlayer.get()];
    }

    public println(): void {
        console.log(this.get() + " is the current player");
    }
}
