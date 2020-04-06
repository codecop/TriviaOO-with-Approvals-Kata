package com.adaptionsoft.games.uglytrivia;

import java.util.Random;

public class RollFactory extends Base {

    public RollFactory(CurrentPlayer currentPlayer,
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
        int roll = calcRoll(rand);
        if (penaltyBox.isIn()) {
            PenaltyBoxRollFactory factory = new PenaltyBoxRollFactory(currentPlayer,
                    names,
                    places,
                    purses,
                    penaltyBox,
                    categories,
                    questions,
                    isGettingOutOfPenaltyBox,
                    roll);
            return factory.create();
        } else {
            return new Roll(currentPlayer,
                    names,
                    places,
                    purses,
                    penaltyBox,
                    categories,
                    questions,
                    isGettingOutOfPenaltyBox,
                    roll);
        }
    }

    private int calcRoll(Random rand) {
        return rand.nextInt(5) + 1;
    }
}
