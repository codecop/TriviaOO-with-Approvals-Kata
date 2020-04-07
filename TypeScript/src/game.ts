import { Action } from "./action";
import { ActionFactory } from "./action-factory";
import { Add } from "./add";
import { Categories } from "./categories";
import { CurrentPlayer } from "./current-player";
import { PenaltyBox } from "./penalty-box";
import { Places } from "./places";
import { PlayerNames } from "./player-names";
import { Players } from "./players";
import { Purses } from "./purses";
import { QuestionsByCategory } from "./questions-by-category";
import { RollFactory } from "./roll-factory";

export class Game {

    players: Players = new Players();
    currentPlayer: CurrentPlayer = new CurrentPlayer(this.players);
    names: PlayerNames = new PlayerNames(this.currentPlayer);
    places: Places = new Places(this.currentPlayer, this.names);
    purses: Purses = new Purses(this.currentPlayer, this.names);
    penaltyBox: PenaltyBox = new PenaltyBox(this.currentPlayer, this.names);

    categories: Categories = new Categories(this.places);
    questions: QuestionsByCategory = new QuestionsByCategory(this.categories);

    isGettingOutOfPenaltyBox: boolean[] = [false];

    public isPlayable(): boolean {
        return (this.players.count() >= 2);
    }

    public getAdd(playerName: string): Action {
        return new Add(this.players,
            this.currentPlayer,
            this.names,
            this.places,
            this.purses,
            this.penaltyBox,
            this.categories,
            this.questions,
            this.isGettingOutOfPenaltyBox,
            playerName);
    }

    public getRoll(): RollFactory {
        return new RollFactory(this.currentPlayer,
            this.names,
            this.places,
            this.purses,
            this.penaltyBox,
            this.categories,
            this.questions,
            this.isGettingOutOfPenaltyBox);
    }

    public getAnswer(): ActionFactory {
        return new ActionFactory(this.currentPlayer,
            this.names,
            this.places,
            this.purses,
            this.penaltyBox,
            this.categories,
            this.questions,
            this.isGettingOutOfPenaltyBox);
    }

}
