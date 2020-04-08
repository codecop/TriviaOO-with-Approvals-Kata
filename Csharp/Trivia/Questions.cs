using System;
using System.Collections;

namespace UglyTrivia
{
    public class Questions
    {
        internal ArrayList popQuestions = new ArrayList();

        public Questions(string prefix)
        {
            for (int i = 0; i < 50; i++)
            {
                this.popQuestions.Add(prefix + " Question " + i);
            }
        }

        public virtual void AskQuestion()
        {
            var question = this.popQuestions[0];
            this.popQuestions.RemoveAt(0);
            Console.WriteLine(question);
        }
    }
}
