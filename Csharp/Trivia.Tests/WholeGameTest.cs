using ApprovalTests;
using ApprovalTests.Reporters;
using System;
using System.Linq;
using Xunit;
using Org.Codecop.Tests;

namespace Trivia.Tests
{
    [UseReporter(typeof(QuietReporter))]
    public class WholeGameTest
    {
        private const int NUM_TESTS = 25;

        [Fact]
        public void PlaysTrivia()
        {
            Action runGames = () => Enumerable.Range(1, NUM_TESTS). //
                Select(i => 147621 + 13 * i). //
                Select(seed => new Random(seed)). //
                ToList(). //
                ForEach(random => GameRunner.Run(random));

            var output = Capture.ConsoleOutput(runGames);
            Approvals.Verify(output);
        }
    }
}
