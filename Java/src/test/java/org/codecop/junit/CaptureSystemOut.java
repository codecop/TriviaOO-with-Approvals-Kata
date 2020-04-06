package org.codecop.junit;

import java.io.ByteArrayOutputStream;
import java.io.PrintStream;

import org.junit.rules.ExternalResource;

public class CaptureSystemOut extends ExternalResource {

    private PrintStream out;
    private ByteArrayOutputStream stdOut;

    @Override
    protected void before() {
        out = System.out;
        stdOut = new ByteArrayOutputStream();
        System.setOut(new PrintStream(stdOut));
    }

    @Override
    protected void after() {
        System.setOut(out);
    }

    public String asString() {
        return stdOut.toString();
    }

}
