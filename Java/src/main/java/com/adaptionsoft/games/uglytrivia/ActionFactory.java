package com.adaptionsoft.games.uglytrivia;

import java.util.Random;

public class ActionFactory extends Base {

    public ActionFactory(CurrentPlayer currentPlayer,
            PlayerNames names,
            Places places,
            Purses purses,
            PenaltyBox penaltyBox,
            Categories categories,
            QuestionsByCategory questions,
            boolean[] isGettingOutOfPenaltyBox) {
        super(currentPlayer,
                names,
                places,
                purses,
                penaltyBox,
                categories,
                questions,
                isGettingOutOfPenaltyBox);
    }

    public Action create(Random rand) {
        Action action;
        if (rand.nextInt(9) == 7) {
            action = wrongAnswer();
        } else {
            action = wasCorrectlyAnswered();
        }
        return action;
    }

    public Action wasCorrectlyAnswered() {
        CorrectFactory factory = new CorrectFactory(currentPlayer,
                names,
                places,
                purses,
                penaltyBox,
                categories,
                questions,
                isGettingOutOfPenaltyBox);
        return factory.create();
    }

    public Action wrongAnswer() {
        return new Wrong(currentPlayer,
                names,
                places,
                purses,
                penaltyBox,
                categories,
                questions,
                isGettingOutOfPenaltyBox);
    }

}
