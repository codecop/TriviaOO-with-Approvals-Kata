# Ugly Object Oriented Trivia with Approvals Kata Java Setup

This is an [Apache Maven](https://maven.apache.org/) project. Run `mvn test` to
run your tests.

* See [Trivia code base](https://github.com/caradojo/trivia).
* See [hand written Golden Master](https://github.com/jbrains/SurvivingLegacyCode-solutions).
* See [ApprovalTests](https://github.com/approvals/ApprovalTests.Java).

## Check your Coverage

To measure your progress you should use code coverage tools:

* [Cobertura](http://cobertura.github.io/cobertura/) - type `mvn cobertura:cobertura`
  or run `cobertura.bat` or `./cobertura.sh`.

* [PIT](http://pitest.org/) - type `mvn test-compile org pitest:pitest-maven:mutationCoverage`
  or run `pit.bat` or `./pit.sh`.
  Note that PIT does not work if there are any blanks in the path names leading to the current location.
