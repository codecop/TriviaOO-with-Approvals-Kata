import { mocha } from "approvals";
import { expect } from "chai";
import { GameRunner } from "../src/game-runner";
mocha();

const approvalConfig = {};

describe("whole game", () => {

  let gameConsoleOutput: string;
  let originalConsoleLog: (message: any) => void;

  function gameConsoleLog(msg: string) {
    gameConsoleOutput += msg + "\r\n";
  }

  beforeEach(() => {
    // prepare capturing console.log to our own gameConsoleLog.
    gameConsoleOutput = "";
    originalConsoleLog = console.log;
    console.log = gameConsoleLog;
  });

  afterEach(() => {
    // reset original console.log
    console.log = originalConsoleLog;
  });

  it("should access game", () => {
    expect(GameRunner).to.not.be.undefined;
  });

  it("plays Trivia", function() { // this must be function for approvals.verify to work
    const randoms = [
      0.32, 0.14, 0.08, 0.94, 0.62, 0.63, 0.86, 0.80, 0.87, 0.15, 0.27, 0.25, 0.94, 0.18, 0.92, 0.73,
      0.71, 0.13, 0.67, 0.27, 0.96, 0.63, 0.49, 0.81, 0.92, 0.99, 0.57, 0.07, 0.47, 0.30, 0.97, 0.99, 0.89, 0.78,
      0.83, 0.80, 0.76, 0.97, 0.46, 0.08, 0.09, 0.02, 0.55, 0.50, 0.82, 0.78, 0.36, 0.69, 0.20, 0.65, 0.36, 0.39,
      0.98, 0.21, 0.62, 0.11, 0.75, 0.32, 0.82, 0.56, 0.08, 0.71, 0.55, 0.74, 0.78, 0.64, 0.85, 0.00, 0.40, 0.93,
      0.39, 0.93, 0.82, 0.40, 0.77, 0.04, 0.12, 0.65, 0.36, 0.51, 0.29, 0.95, 0.77, 0.46, 0.08, 0.87, 0.60, 0.64,
      0.96, 0.60, 0.23, 0.67, 0.52, 0.22, 0.61, 0.72, 0.67, 0.43, 0.19, 0.14];
    let run: number;
    let i: number;

    function fakeRandom() {
      i = (i + 1) % 100;
      return randoms[i];
    }

    for (run = 0; run < 10; run += 1) {
      i = run * 10;
      GameRunner.main(fakeRandom);
    }

    this.verify(gameConsoleOutput, approvalConfig);
  });

});
