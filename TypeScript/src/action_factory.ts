import { Action } from "./action";
import { Base } from "./base";
import { Categories } from "./categories";
import { CorrectFactory } from "./correct_factory";
import { CurrentPlayer } from "./current_player";
import { PenaltyBox } from "./penalty_box";
import { Places } from "./places";
import { PlayerNames } from "./player_names";
import { Purses } from "./purses";
import { QuestionsByCategory } from "./questions_by_category";
import { Wrong } from "./wrong";

export class ActionFactory extends Base {

    public constructor(
        currentPlayer: CurrentPlayer,
        names: PlayerNames,
        places: Places,
        purses: Purses,
        penaltyBox: PenaltyBox,
        categories: Categories,
        questions: QuestionsByCategory,
        isGettingOutOfPenaltyBox: boolean[]) {
        super(currentPlayer,
            names,
            places,
            purses,
            penaltyBox,
            categories,
            questions,
            isGettingOutOfPenaltyBox);
    }

    public create(rand): Action {
        let action: Action;
        if (rand.nextInt(9) === 7) {
            action = this.wrongAnswer();
        } else {
            action = this.wasCorrectlyAnswered();
        }
        return action;
    }

    public wasCorrectlyAnswered(): Action {
        const factory: CorrectFactory = new CorrectFactory(this.currentPlayer,
            this.names,
            this.places,
            this.purses,
            this.penaltyBox,
            this.categories,
            this.questions,
            this.isGettingOutOfPenaltyBox);
        return factory.create();
    }

    public wrongAnswer(): Action {
        return new Wrong(this.currentPlayer,
            this.names,
            this.places,
            this.purses,
            this.penaltyBox,
            this.categories,
            this.questions,
            this.isGettingOutOfPenaltyBox);
    }

}
