using System;

namespace UglyTrivia
{
    public class Categories
    {
        private Places places;

        public Categories(Places places)
        {
            this.places = places;
        }

        public virtual string CurrentCategory()
        {
            if (this.places.Current() == 0)
            {
                return "Pop";
            }
            if (this.places.Current() == 4)
            {
                return "Pop";
            }
            if (this.places.Current() == 8)
            {
                return "Pop";
            }
            if (this.places.Current() == 1)
            {
                return "Science";
            }
            if (this.places.Current() == 5)
            {
                return "Science";
            }
            if (this.places.Current() == 9)
            {
                return "Science";
            }
            if (this.places.Current() == 2)
            {
                return "Sports";
            }
            if (this.places.Current() == 6)
            {
                return "Sports";
            }
            if (this.places.Current() == 10)
            {
                return "Sports";
            }
            return "Rock";
        }

        public virtual void Println()
        {
            Console.WriteLine("The category is " + this.CurrentCategory());
        }
    }
}
