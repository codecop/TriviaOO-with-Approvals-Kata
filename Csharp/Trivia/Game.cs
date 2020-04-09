using System;

namespace UglyTrivia
{
    public class Game
    {
        Players players;

        CurrentPlayer currentPlayer;

        PlayerNames names;

        Places places;

        Purses purses;

        PenaltyBox penaltyBox;

        Categories categories;

        QuestionsByCategory questions;

        bool[] isGettingOutOfPenaltyBox;

        public Game()
        {
            players = new Players();
            currentPlayer = new CurrentPlayer(players);
            names = new PlayerNames(currentPlayer);
            places = new Places(currentPlayer, names);
            purses = new Purses(currentPlayer, names);
            penaltyBox = new PenaltyBox(currentPlayer, names);
            categories = new Categories(places);
            questions = new QuestionsByCategory(categories);
            isGettingOutOfPenaltyBox = new bool[1];
        }

        public bool IsPlayable()
        {
            return (players.Count() >= 2);
        }

        public Action GetAdd(String playerName)
        {
            return new Add(players, currentPlayer, names, places, purses, penaltyBox, categories, questions, isGettingOutOfPenaltyBox, playerName);
        }

        public RollFactory GetRoll()
        {
            return new RollFactory(currentPlayer, names, places, purses, penaltyBox, categories, questions, isGettingOutOfPenaltyBox);
        }

        public ActionFactory GetAnswer()
        {
            return new ActionFactory(currentPlayer, names, places, purses, penaltyBox, categories, questions, isGettingOutOfPenaltyBox);
        }
    }
}
