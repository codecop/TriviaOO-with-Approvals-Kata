package sample;

import java.util.Arrays;

import org.approvaltests.Approvals;
import org.approvaltests.reporters.ClipboardReporter;
import org.approvaltests.reporters.JunitReporter;
import org.approvaltests.reporters.QuietReporter;
import org.approvaltests.reporters.UseReporter;
import org.codecop.approvaltests.KDiff3Reporter;
import org.junit.Test;

@UseReporter(value = { KDiff3Reporter.class, ClipboardReporter.class, JunitReporter.class, QuietReporter.class })
public class SampleArrayTest {

    @Test
    public void testList() {
        String[] names = { "Llewellyn", "James", "Dan", "Jason", "Katrina" };
        Arrays.sort(names);
        Approvals.verifyAll("", names);
    }

}
