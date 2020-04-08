using UglyTrivia;

namespace Trivia
{
    public class GameRunner
    {
        private static bool notAWinner;

        public static void Main(string[] args)
        {
            System.Random rand = new System.Random();
            Run(rand);
        }

        public static void Run(System.Random rand)
        {
            Game aGame = new Game();

            aGame.GetAdd("Chet").Execute();
            aGame.GetAdd("Pat").Execute();
            aGame.GetAdd("Sue").Execute();

            do
            {

                Action roll = aGame.GetRoll().Create(rand);
                roll.Execute();

                Action answer = aGame.GetAnswer().Create(rand);
                notAWinner = answer.Execute();



            } while (notAWinner);

        }


    }

}
