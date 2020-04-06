package com.adaptionsoft.games.uglytrivia;

public class Places extends CurrentArray<Integer> {

    PlayerNames names;

    public Places(CurrentPlayer currentPlayer, PlayerNames names) {
        super(currentPlayer, 0);
        this.names = names;
    }

    public void add(int roll) {
        set(currentPlayer.get(), current() + roll);
    }

    public void printlnPlace() {
        System.out.println(names.get() 
                + "'s new location is " 
                + current());
    }
    
}
