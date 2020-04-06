package com.adaptionsoft.games.uglytrivia;

public class Correct extends Base implements Action {

    public Correct(CurrentPlayer currentPlayer,
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
        purses.inc();

        boolean winner = didPlayerWin();
        currentPlayer.inc();

        return winner;
    }

    private void println() {
        System.out.println("Answer was corrent!!!!");
    }

    private boolean didPlayerWin() {
        return !(purses.current() == 6);
    }

}
