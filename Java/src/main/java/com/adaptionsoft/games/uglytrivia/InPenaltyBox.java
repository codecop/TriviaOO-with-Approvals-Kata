package com.adaptionsoft.games.uglytrivia;

public class InPenaltyBox extends Base implements Action {

    public InPenaltyBox(CurrentPlayer currentPlayer,
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
        if (isGettingOutOfPenaltyBox[0]) {
            println();
            purses.inc();

            boolean winner = didPlayerWin();
            currentPlayer.inc();

            return winner;
        } else {
            currentPlayer.inc();
            return true;
        }
    }

    private void println() {
        System.out.println("Answer was correct!!!!");
    }

    private boolean didPlayerWin() {
        return !(purses.current() == 6);
    }

}
