package com.adaptionsoft.games.uglytrivia;

public class PlayerNames extends Players {

    CurrentPlayer currentPlayer;

    public PlayerNames(CurrentPlayer currentPlayer) {
        this.currentPlayer = currentPlayer;
    }

    public Object get() {
        return elements.get(currentPlayer.get());
    }

    @Override
    public void println() {
        System.out.println(get() + " is the current player");
    }
}
