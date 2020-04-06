package com.adaptionsoft.games.uglytrivia;

public class PenaltyBoxRoll extends Base implements Action {

    private int roll;

    public PenaltyBoxRoll(CurrentPlayer currentPlayer,
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

    @Override
    public boolean execute() {
        println();
        isGettingOutOfPenaltyBox[0] = false;

        return false;
    }

    private void println() {
        names.println();
        System.out.println("They have rolled a " + roll);
        System.out.println(names.get() + " is not getting out of the penalty box");
    }

}
