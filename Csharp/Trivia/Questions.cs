using System;
using System.Collections.Generic;

namespace UglyTrivia
{
    public class Questions
    {
        internal LinkedList<string> popQuestions = new LinkedList<string>();

        public Questions(string prefix)
        {
            for (int i = 0; i < 50; i++)
            {
                popQuestions.AddLast(prefix + " Question " + i);
            }
        }

        public void AskQuestion()
        {
            Console.WriteLine(popQuestions.First.Value);
            popQuestions.RemoveFirst();
        }
    }
}
