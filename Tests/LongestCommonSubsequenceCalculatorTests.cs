using Challenge;

namespace Tests;

public class LongestCommonSubsequenceCalculatorTests
{
    [Test]
    [TestCase("abcde", "ace", ExpectedResult = 3)]
    [TestCase("abc", "abc", ExpectedResult = 3)]
    [TestCase("abc", "def", ExpectedResult = 0)]
    [TestCase("aaaa", "aa", ExpectedResult = 2)]
    [TestCase("abcdxyz", "dxyz", ExpectedResult = 4)]
    [TestCase("abcd", "wxyz", ExpectedResult = 0)]
    [TestCase("abcdeabcdeabcde", "abcde", ExpectedResult = 5)]
    [TestCase("hello", "hello", ExpectedResult = 5)]
    [TestCase("", "abc", ExpectedResult = 0)]
    [TestCase("", "", ExpectedResult = 0)]
    public int LongestCommonSubsequence_ShouldReturnCorrectLength(string input1, string input2)
    {
        var calculator = new LongestCommonSubsequenceCalculator();

        return calculator.LongestCommonSubsequence(input1, input2);
    }
}
