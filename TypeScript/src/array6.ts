export class Array6<T> {

    private array: any[] = [null, null, null, null, null, null];

    public constructor(init: T) {
        for (let i = 0; i < 6; i++) {
            this.set(i, init);
        }
    }

    public set(i: number, value: T): void {
        this.array[i] = value;
    }

    public get(i: number): T {
        return this.array[i];
    }

}
