package com.adaptionsoft.games.uglytrivia;

public class RockQuestions extends Questions {

    public RockQuestions() {
        super("Rock");
    }

    public String createRockQuestion(int index) {
        return "Rock Question " + index;
    }

}
