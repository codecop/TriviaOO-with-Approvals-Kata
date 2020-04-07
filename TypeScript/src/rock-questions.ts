import { Questions } from "./questions";

export class RockQuestions extends Questions {

    public constructor() {
        super("Rock");
    }

    public createRockQuestion(index: number): string {
        return "Rock Question " + index;
    }

}
