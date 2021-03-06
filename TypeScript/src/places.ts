import { CurrentArray } from "./current-array";
import { CurrentPlayer } from "./current-player";
import { PlayerNames } from "./player-names";

export class Places extends CurrentArray<number> {

    names: PlayerNames;

    public constructor(currentPlayer: CurrentPlayer, names: PlayerNames) {
        super(currentPlayer, 0);
        this.names = names;
    }

    public add(roll: number): void {
        this.set(this.currentPlayer.get(), this.current() + roll);
    }

    public printlnPlace(): void {
        console.log(this.names.get()
            + "'s new location is "
            + this.current());
    }

}
