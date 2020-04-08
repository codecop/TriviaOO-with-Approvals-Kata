using System;
using System.Collections;

namespace UglyTrivia
{
    public class Players
    {
        internal ArrayList elements = new ArrayList();

        public virtual void Add(string playerName)
        {
            this.elements.Add(playerName);
        }

        public virtual void Println()
        {
            this.PrintlnAdded();
            this.PrintlnNum();
        }

        private void PrintlnAdded()
        {
            Console.WriteLine(this.elements[this.elements.Count - 1] + " was added");
        }

        private void PrintlnNum()
        {
            Console.WriteLine("They are player number " + this.Count());
        }

        public virtual int Count()
        {
            return this.elements.Count;
        }
    }
}
