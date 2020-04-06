package com.adaptionsoft.games.uglytrivia;

public class Game {

    Players players = new Players();
    CurrentPlayer currentPlayer = new CurrentPlayer(players);
    PlayerNames names = new PlayerNames(currentPlayer);
    Places places = new Places(currentPlayer, names);
    Purses purses = new Purses(currentPlayer, names);
    PenaltyBox penaltyBox = new PenaltyBox(currentPlayer, names);
    
    Categories categories = new Categories(places);
    QuestionsByCategory questions = new QuestionsByCategory(categories);

    boolean[] isGettingOutOfPenaltyBox = new boolean[1];

    public boolean isPlayable() {
        return (players.count() >= 2);
    }

    public Action getAdd(String playerName) {
        return new Add(players,
                currentPlayer,
                names,
                places,
                purses,
                penaltyBox,
                categories,
                questions,
                isGettingOutOfPenaltyBox,
                playerName);
    }

    public RollFactory getRoll() {
        return new RollFactory(currentPlayer,
                names,
                places,
                purses,
                penaltyBox,
                categories,
                questions,
                isGettingOutOfPenaltyBox);
    }

    public ActionFactory getAnswer() {
        return new ActionFactory(currentPlayer,
                names,
                places,
                purses,
                penaltyBox,
                categories,
                questions,
                isGettingOutOfPenaltyBox);
    }

}
