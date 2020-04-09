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

        public String CurrentCategory()
        {
            if (places.Current() == 0) return "Pop";
            if (places.Current() == 4) return "Pop";
            if (places.Current() == 8) return "Pop";
            if (places.Current() == 1) return "Science";
            if (places.Current() == 5) return "Science";
            if (places.Current() == 9) return "Science";
            if (places.Current() == 2) return "Sports";
            if (places.Current() == 6) return "Sports";
            if (places.Current() == 10) return "Sports";
            return "Rock";
        }

        public void Println()
        {
            Console.WriteLine("The category is " + CurrentCategory());
        }
    }
}
