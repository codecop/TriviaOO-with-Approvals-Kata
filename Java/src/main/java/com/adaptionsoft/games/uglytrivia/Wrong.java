package com.adaptionsoft.games.uglytrivia;

public class Wrong extends Base implements Action {

    public Wrong(CurrentPlayer currentPlayer,
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

    @Override
    public boolean execute() {
        println();

        penaltyBox.set(currentPlayer.get(), true);

        currentPlayer.inc();
        return true;
    }

    private void println() {
        System.out.println("Question was incorrectly answered");
        penaltyBox.println();
    }
}
