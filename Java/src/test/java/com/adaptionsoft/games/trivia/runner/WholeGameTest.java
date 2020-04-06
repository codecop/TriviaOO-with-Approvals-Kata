package com.adaptionsoft.games.trivia.runner;

import java.util.Random;
import java.util.stream.IntStream;

import org.approvaltests.Approvals;
import org.approvaltests.reporters.ClipboardReporter;
import org.approvaltests.reporters.QuietReporter;
import org.approvaltests.reporters.UseReporter;
import org.codecop.approvaltests.KDiff3Reporter;
import org.codecop.junit.CaptureSystemOut;
import org.junit.Rule;
import org.junit.Test;

// no JunitReporter.class because diff is large
@UseReporter(value = { KDiff3Reporter.class, ClipboardReporter.class, QuietReporter.class })
public class WholeGameTest {

    private static final int NUM_TESTS = 25;

    @Rule
    public CaptureSystemOut stdOut = new CaptureSystemOut();

    @Test
    public void playsTrivia() {
        IntStream.range(1, NUM_TESTS). //
                map(i -> 147621 + 13 * i). //
                mapToObj(Random::new). //
                forEach(GameRunner::main);

        Approvals.verify(stdOut.asString());
    }

}
