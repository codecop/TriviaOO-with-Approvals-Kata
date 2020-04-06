package com.adaptionsoft.games.uglytrivia;

public class Roll extends Base implements Action {

    private int roll;

    public Roll(CurrentPlayer currentPlayer,
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

        places.add(roll);
        if (places.get(currentPlayer.get()) > 11) places.set(currentPlayer.get(), places.get(currentPlayer.get()) - 12);
        places.printlnPlace();

        categories.println();
        questions.ask();

        return false;
    }

    private void println() {
        names.println();
        System.out.println("They have rolled a " + roll);
    }

}
