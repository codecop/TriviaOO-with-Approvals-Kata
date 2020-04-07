import { Players } from "./players";

export class CurrentPlayer {

    players: Players;
    currentPlayer: number = 0;

    public constructor(players: Players) {
        this.players = players;
    }

    public get(): number {
        return this.currentPlayer;
    }

    public inc(): void {
        this.currentPlayer = this.currentPlayer + 1;
        if (this.currentPlayer === this.players.count()) this.currentPlayer = 0;
    }

}
