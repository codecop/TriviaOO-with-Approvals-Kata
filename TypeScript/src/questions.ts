export class Questions {

    popQuestions: Array<string> = [];

    public constructor(prefix: string) {

        for (let i = 0; i < 50; i++) {
            this.popQuestions.push(prefix + " Question " + i);
        }
    }

    public askQuestion(): void {
        console.log(this.popQuestions.shift());
    }

}
