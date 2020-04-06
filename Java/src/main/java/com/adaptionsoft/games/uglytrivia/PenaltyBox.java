package com.adaptionsoft.games.uglytrivia;

public class PenaltyBox extends Array6<Boolean> {

    CurrentPlayer currentPlayer;
    PlayerNames names;

    public PenaltyBox(CurrentPlayer currentPlayer, PlayerNames names) {
        super(false);
        this.currentPlayer = currentPlayer;
        this.names = names;
    }

    public boolean isIn() {
        return get(currentPlayer.get());
    }

    public void println() {
        System.out.println(names.get() + " was sent to the penalty box");
    }

}
