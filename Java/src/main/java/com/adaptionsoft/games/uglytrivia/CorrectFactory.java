package com.adaptionsoft.games.uglytrivia;

public class CorrectFactory extends Base {

    public CorrectFactory(CurrentPlayer currentPlayer,
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

    public Action create() {
        if (penaltyBox.isIn()) {
            return new InPenaltyBox(currentPlayer,
                    names,
                    places,
                    purses,
                    penaltyBox,
                    categories,
                    questions,
                    isGettingOutOfPenaltyBox);
        } else {
            return new Correct(currentPlayer,
                    names,
                    places,
                    purses,
                    penaltyBox,
                    categories,
                    questions,
                    isGettingOutOfPenaltyBox);
        }
    }

}
