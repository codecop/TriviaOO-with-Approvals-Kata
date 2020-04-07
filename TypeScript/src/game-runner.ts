import { Game } from './game';

export class GameRunner {
    public static main(random): void {
        const game = new Game();
        game.getAdd("Chet").execute();
        game.getAdd("Pat").execute();
        game.getAdd("Sue").execute();

        let notAWinner;
        do {

            const roll = game.getRoll().create(random);
            roll.execute();

            const answer = game.getAnswer().create(random);
            notAWinner = answer.execute();

        } while (notAWinner);
    }
}

GameRunner.main(Math.random);
