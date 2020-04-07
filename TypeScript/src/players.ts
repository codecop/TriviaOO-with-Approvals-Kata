export class Players {

    elements = [];

    public add(playerName: string): void {
        this.elements.push(playerName);
    }

    public println(): void {
        this.printlnAdded();
        this.printlnNum();
    }

    private printlnAdded(): void {
        console.log(this.elements[this.elements.length - 1] + " was added");
    }

    private printlnNum(): void {
        console.log("They are player number " + this.count());
    }

    public count(): number {
        return this.elements.length;
    }

}
