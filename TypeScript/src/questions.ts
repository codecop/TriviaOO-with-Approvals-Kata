export class Questions {

    popQuestions = [];

    public constructor(prefix: string) {
        for (let i = 0; i < 50; i++) {
            this.popQuestions.push(prefix + " Question " + i);
        }
    }

    public askQuestion(): void {
        const question = this.popQuestions[0];
        this.popQuestions = this.popQuestions.slice(1);
        console.log(question);
    }

}
