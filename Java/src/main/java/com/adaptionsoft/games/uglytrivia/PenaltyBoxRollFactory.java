package com.adaptionsoft.games.uglytrivia;

public class PenaltyBoxRollFactory extends Base {

    private int roll;

    public PenaltyBoxRollFactory(CurrentPlayer currentPlayer,
            PlayerNames names,
            Places places,
            Purses purses,
            PenaltyBox penaltyBox,
            Categories categories,
            QuestionsByCategory questions,
            boolean[] isGettingOutOfPenaltyBox,
            int roll) {
        super(currentPlayer,
                names,
                places,
                purses,
                penaltyBox,
                categories,
                questions,
                isGettingOutOfPenaltyBox);
        
        this.roll = roll;
    }

    public Action create() {
        if (roll % 2 != 0) {
            return new GettingOutRoll(currentPlayer,
                    names,
                    places,
                    purses,
                    penaltyBox,
                    categories,
                    questions,
                    isGettingOutOfPenaltyBox,
                    roll);
        } else {
            return new PenaltyBoxRoll(currentPlayer,
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

}
