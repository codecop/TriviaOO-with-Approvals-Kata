import { Categories } from "./categories";
import { CurrentPlayer } from "./current-player";
import { PenaltyBox } from "./penalty-box";
import { Places } from "./places";
import { PlayerNames } from "./player-names";
import { Purses } from "./purses";
import { QuestionsByCategory } from "./questions-by-category";

export class Base {

    currentPlayer: CurrentPlayer;
    names: PlayerNames;
    places: Places;
    purses: Purses;
    penaltyBox: PenaltyBox;

    categories: Categories;
    questions: QuestionsByCategory;

    isGettingOutOfPenaltyBox: boolean[];

    public constructor(
        currentPlayer: CurrentPlayer,
        names: PlayerNames,
        places: Places,
        purses: Purses,
        penaltyBox: PenaltyBox,
        categories: Categories,
        questions: QuestionsByCategory,
        isGettingOutOfPenaltyBox: boolean[]) {
        this.currentPlayer = currentPlayer;
        this.names = names;
        this.places = places;
        this.purses = purses;
        this.penaltyBox = penaltyBox;
        this.categories = categories;
        this.questions = questions;
        this.isGettingOutOfPenaltyBox = isGettingOutOfPenaltyBox;
    }

}
