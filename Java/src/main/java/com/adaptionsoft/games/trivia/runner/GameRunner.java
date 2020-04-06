
package com.adaptionsoft.games.trivia.runner;
import java.util.Random;

import com.adaptionsoft.games.uglytrivia.Action;
import com.adaptionsoft.games.uglytrivia.Game;


public class GameRunner {

	private static boolean notAWinner;

	public static void main(String[] args) {
	    Random rand = new Random();
	    main(rand);
	}

	static void main(Random rand) {
		Game aGame = new Game();
		
		aGame.getAdd("Chet").execute();
		aGame.getAdd("Pat").execute();
		aGame.getAdd("Sue").execute();
		
	
		do {
			
			Action roll = aGame.getRoll().create(rand);
			roll.execute();
			
			Action answer = aGame.getAnswer().create(rand);
			notAWinner = answer.execute();
			
			
		} while (notAWinner);
		
	}
}
