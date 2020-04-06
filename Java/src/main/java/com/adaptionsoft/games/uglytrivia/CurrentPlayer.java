package com.adaptionsoft.games.uglytrivia;

public class CurrentPlayer {

    Players players;
    int currentPlayer = 0;

    public CurrentPlayer(Players players) {
        this.players = players;
    }

    public int get() {
        return currentPlayer;
    }

    public void inc() {
        currentPlayer = currentPlayer + 1;
        if (currentPlayer == players.count()) currentPlayer = 0;
    }

}
