package com.adaptionsoft.games.uglytrivia;

public abstract class Base {

    CurrentPlayer currentPlayer;
    PlayerNames names;
    Places places;
    Purses purses;
    PenaltyBox penaltyBox;

    Categories categories;
    QuestionsByCategory questions;

    boolean[] isGettingOutOfPenaltyBox;

    public Base(CurrentPlayer currentPlayer,
            PlayerNames names,
            Places places,
            Purses purses,
            PenaltyBox penaltyBox,
            Categories categories,
            QuestionsByCategory questions,
            boolean[] isGettingOutOfPenaltyBox) {
        this.currentPlayer = currentPlayer;
        this.names = names;
        this.places = places;
        this.purses = purses;
        this.penaltyBox = penaltyBox;
        this.categories = categories;
        this.questions = questions;
        this.isGettingOutOfPenaltyBox = isGettingOutOfPenaltyBox;
    }

}
