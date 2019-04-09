using NUnit.Framework;

namespace KSharpParser.Tests
{
    public class EnumerableTests
    {
        [TestFixture]
        public class AnyTests : KSharpTestBase
        {
            [TestCase("Any(\"a\")", "a")]
            public void Any(string input, string expected)
            {
                var tree = GetParser(input).begin_expression();

                string result = Visitor.GetFirstResult(tree) as string;

                Assert.AreEqual(expected, result);
            }
        }
    }
}
