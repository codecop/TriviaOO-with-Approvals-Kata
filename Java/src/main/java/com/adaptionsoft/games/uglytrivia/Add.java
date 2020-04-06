package com.adaptionsoft.games.uglytrivia;

public class Add extends Base implements Action {

    private Players players;
    private String playerName;

    public Add(Players players,
            CurrentPlayer currentPlayer,
            PlayerNames names,
            Places places,
            Purses purses,
            PenaltyBox penaltyBox,
            Categories categories,
            QuestionsByCategory questions,
            boolean[] isGettingOutOfPenaltyBox,
            String playerName) {
        super(currentPlayer,
                names,
                places,
                purses,
                penaltyBox,
                categories,
                questions,
                isGettingOutOfPenaltyBox);

        this.players = players;
        this.playerName = playerName;
    }

    @Override
    public boolean execute() {
        players.add(playerName);
        names.add(playerName);
        places.set(players.count(), 0);
        purses.set(players.count(), 0);
        penaltyBox.set(players.count(), false);
        players.println();

        return true;
    }

}
