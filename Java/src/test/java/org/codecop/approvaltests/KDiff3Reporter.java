package org.codecop.approvaltests;

import java.text.MessageFormat;

import org.approvaltests.reporters.GenericDiffReporter;

/**
 * Copy of KDiff3Reporter with path for Windows x64.
 * 
 * @author Peter Kofler
 */
public class KDiff3Reporter extends GenericDiffReporter {
    private static final String DIFF_PROGRAM = "C:\\Program Files (x86)\\KDiff3\\kdiff3.exe";
    private static final String MESSAGE = MessageFormat.format("Unable to find KDiff3 at {0}", DIFF_PROGRAM);
    public static final KDiff3Reporter INSTANCE = new KDiff3Reporter();

    public KDiff3Reporter() {
        super(DIFF_PROGRAM, "%s %s -m", MESSAGE, GenericDiffReporter.TEXT_FILE_EXTENSIONS);
    }
}
