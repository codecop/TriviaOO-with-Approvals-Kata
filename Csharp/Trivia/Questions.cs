using System;
using System.Collections.Generic;

namespace UglyTrivia
{
    public class Questions
    {
        internal LinkedList<String> popQuestions = new LinkedList<String>();

        public Questions(String prefix)
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
