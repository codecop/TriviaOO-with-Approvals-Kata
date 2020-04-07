import { Array6 } from "./array6";
import { CurrentPlayer } from "./current-player";

export class CurrentArray<T> extends Array6<T> {

    currentPlayer: CurrentPlayer;

    public constructor(currentPlayer: CurrentPlayer, init: T) {
        super(init);
        this.currentPlayer = currentPlayer;
    }

    public current(): T {
        return this.get(this.currentPlayer.get());
    }

}
