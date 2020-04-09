using System;
using System.Collections.Generic;

namespace UglyTrivia
{
    public class Players
    {
        internal List<String> elements = new List<String>();

        public void Add(String playerName)
        {
            elements.Add(playerName);
        }

        public virtual void Println()
        {
            PrintlnAdded();
            PrintlnNum();
        }

        private void PrintlnAdded()
        {
            Console.WriteLine(elements[elements.Count - 1] + " was added");
        }

        private void PrintlnNum()
        {
            Console.WriteLine("They are player number " + Count());
        }

        public int Count()
        {
            return elements.Count;
        }
    }
}
