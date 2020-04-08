using ApprovalTests;
using ApprovalTests.Reporters;
using System;
using Xunit;

namespace Sample.Tests
{
    // [UseReporter(typeof(ClipboardReporter))]
    [UseReporter(typeof(QuietReporter))]
    public class SampleArrayTest
    {
        [Fact]
        public void TestList()
        {
            var names = new[] { "Llewellyn", "James", "Dan", "Jason", "Katrina" };
            Array.Sort(names);
            Approvals.VerifyAll(names, label: "");
        }
    }
}
