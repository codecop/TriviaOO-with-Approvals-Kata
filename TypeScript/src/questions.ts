export class Questions {

    popQuestions: any[] = [];

    public constructor(prefix: string) {
        for (let i = 0; i < 50; i++) {
            this.popQuestions.addLast(prefix + " Question " + i);
        }
    }

    public askQuestion(): void {
        console.log(this.popQuestions.removeFirst());
    }

}
