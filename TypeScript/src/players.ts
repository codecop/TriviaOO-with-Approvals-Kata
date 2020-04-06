export class Players {

    elements: any[] = [];

    public add(playerName: string): void {
        this.elements.add(playerName);
    }

    public println(): void {
        this.printlnAdded();
        this.printlnNum();
    }

    private printlnAdded(): void {
        console.log(this.elements.getLast() + " was added");
    }

    private printlnNum(): void {
        console.log("They are player number " + this.count());
    }

    public count(): number {
        return this.elements.size();
    }

}
