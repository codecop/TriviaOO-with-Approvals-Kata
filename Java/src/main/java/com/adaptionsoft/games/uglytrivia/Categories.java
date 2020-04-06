package com.adaptionsoft.games.uglytrivia;

public class Categories {

    private Places places;

    public Categories(Places places) {
        this.places = places;
    }

    public String currentCategory() {
        if (places.current() == 0) return "Pop";
        if (places.current() == 4) return "Pop";
        if (places.current() == 8) return "Pop";
        if (places.current() == 1) return "Science";
        if (places.current() == 5) return "Science";
        if (places.current() == 9) return "Science";
        if (places.current() == 2) return "Sports";
        if (places.current() == 6) return "Sports";
        if (places.current() == 10) return "Sports";
        return "Rock";
    }

    public void println() {
        System.out.println("The category is " + currentCategory());
    }
    
}
