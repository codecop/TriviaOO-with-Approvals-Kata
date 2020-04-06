package com.adaptionsoft.games.uglytrivia;

public class CurrentArray<T> extends Array6<T> {

    CurrentPlayer currentPlayer;

    public CurrentArray(CurrentPlayer currentPlayer, T init) {
        super(init);
        this.currentPlayer = currentPlayer;
    }

    public T current() {
        return get(currentPlayer.get());
    }

}
