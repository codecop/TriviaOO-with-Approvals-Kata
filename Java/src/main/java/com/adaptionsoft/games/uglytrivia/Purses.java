package com.adaptionsoft.games.uglytrivia;

public class Purses extends CurrentArray<Integer> {

    PlayerNames names;

    public Purses(CurrentPlayer currentPlayer, PlayerNames names) {
        super(currentPlayer, 0);
        this.names = names;
    }

    public void inc() {
        add();
        println();
    }
    
    private void add() {
        set(currentPlayer.get(), current() + 1);
    }

    private void println() {
        System.out.println(names.get() 
                + " now has "
                + current()
                + " Gold Coins.");
    }

}
