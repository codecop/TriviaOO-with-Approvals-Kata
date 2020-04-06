package com.adaptionsoft.games.uglytrivia;

import java.util.LinkedList;

public class Questions {

    LinkedList popQuestions = new LinkedList();

    public Questions(String prefix) {
        for (int i = 0; i < 50; i++) {
            popQuestions.addLast(prefix + " Question " + i);
        }
    }

    public void askQuestion() {
        System.out.println(popQuestions.removeFirst());
    }

}
