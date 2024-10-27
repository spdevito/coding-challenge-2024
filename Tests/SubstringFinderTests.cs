using Challenge;

namespace Tests;

public class SubstringFinderTests
{
    [TestCase("abcabcbb", ExpectedResult = 3)]
    [TestCase("bbbbb", ExpectedResult = 1)]
    [TestCase("pwwkew", ExpectedResult = 3)]
    [TestCase("", ExpectedResult = 0)]
    [TestCase(" ", ExpectedResult = 1)]
    [TestCase("au", ExpectedResult = 2)]
    [TestCase("dvdf", ExpectedResult = 3)]
    [TestCase("aab", ExpectedResult = 2)]
    [TestCase("abba", ExpectedResult = 2)]
    [TestCase("abcabcs", ExpectedResult = 4)]
    [Test]
    public int LengthOfLongestSubstring_ShouldReturnCorrectValue(string input)
    {
        var calculator = new SubstringFinder();

        return calculator.LengthOfLongestSubstring(input);
    }
}
