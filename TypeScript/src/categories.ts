import { Places } from "./places";

export class Categories {

    private places: Places;

    public constructor(places: Places) {
        this.places = places;
    }

    public currentCategory(): string {
        if (this.places.current() === 0) return "Pop";
        if (this.places.current() === 4) return "Pop";
        if (this.places.current() === 8) return "Pop";
        if (this.places.current() === 1) return "Science";
        if (this.places.current() === 5) return "Science";
        if (this.places.current() === 9) return "Science";
        if (this.places.current() === 2) return "Sports";
        if (this.places.current() === 6) return "Sports";
        if (this.places.current() === 10) return "Sports";
        return "Rock";
    }

    public println(): void {
        console.log("The category is " + this.currentCategory());
    }

}
