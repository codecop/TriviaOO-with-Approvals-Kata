package com.adaptionsoft.games.uglytrivia;

import java.util.LinkedList;

public class Players {

    LinkedList elements = new LinkedList();

    public void add(String playerName) {
        elements.add(playerName);
    }

    public void println() {
        printlnAdded();
        printlnNum();
    }

    private void printlnAdded() {
        System.out.println(elements.getLast() + " was added");
    }

    private void printlnNum() {
        System.out.println("They are player number " + count());
    }

    public int count() {
        return elements.size();
    }

}
