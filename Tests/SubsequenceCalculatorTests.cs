using Challenge;

namespace Tests;

public class SubsequenceCalculatorTests
{
    [TestCase(new[] { 10, 9, 2, 5, 3, 7, 101, 18 }, ExpectedResult = 4)]
    [TestCase(new[] { 5 }, ExpectedResult = 1)]
    [TestCase(new[] { 1, 2, 3, 4, 5 }, ExpectedResult = 5)]
    [TestCase(new[] { 5, 4, 3, 2, 1 }, ExpectedResult = 1)]
    [TestCase(new[] { 1, 0, 0, 0, 0, 5 }, ExpectedResult = 2)]
    [TestCase(new[] { 1, 3, 5, 4, 7, 8, 6, 9 }, ExpectedResult = 6)]
    [TestCase(new[] { 7, 7, 7, 7 }, ExpectedResult = 1)]
    [TestCase(new int[] { }, ExpectedResult = 0)]
    [TestCase(new[] { -2, -1, 0, 1, 2}, ExpectedResult = 5)]
    [TestCase(new[] { -1, 3, 6, 7, 9, 4, 10, 5, 6 }, ExpectedResult = 6)]
    [Test]
    public int LengthOfLIS_ShouldReturnCorrectValue(int[] input)
    {
        var calculator = new SubsequenceCalculator();

        return calculator.LengthOfLIS(input);
    }
}
