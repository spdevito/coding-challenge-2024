using Challenge.Tree;

namespace Tests;

public class SimplifiedFractionsTests
{
    [TestCase("4/8", ExpectedResult = "1/2")]
    [TestCase("15/25", ExpectedResult = "3/5")]
    [TestCase("4/2", ExpectedResult = "2")]
    [TestCase("1/1", ExpectedResult = "1")]
    [TestCase("5/7", ExpectedResult = "5/7")]
    [TestCase("0/1", ExpectedResult = "0")]
    [TestCase("1000/1001", ExpectedResult = "1000/1001")]
    [TestCase("-5/10", ExpectedResult = "-1/2")]
    [TestCase("-5/-10", ExpectedResult = "1/2")]
    [TestCase("5/-10", ExpectedResult = "-1/2")]
    [Test]
    public string Should_Simplify_Fractions(string input)
    {
        var sf = new SimplifiedFractions();
        return sf.Simplify(input);
    }
}
