using Challenge;

namespace Tests;

public class CountTheLettersAndDigitsTests
{
    [TestCase("Hello World!", ExpectedResult = "LETTERS = 10, DIGITS = 0")]
    [TestCase("Hello World! 123", ExpectedResult = "LETTERS = 10, DIGITS = 3")]
    [TestCase("H31l0 World!", ExpectedResult = "LETTERS = 7, DIGITS = 3")]
    [TestCase("Today is 2022-01-01", ExpectedResult = "LETTERS = 7, DIGITS = 8")]
    [TestCase("1234567890", ExpectedResult = "LETTERS = 0, DIGITS = 10")]
    [TestCase("a1b2c3d4e5f6g7h8i9j0", ExpectedResult = "LETTERS = 10, DIGITS = 10")]
    [TestCase("a1b2c3d4e5f6g7h8i9j0k1l2m3n4o5p6q7r8s9t0", ExpectedResult = "LETTERS = 20, DIGITS = 20")]
    [TestCase("a1b2c3d4e5f6g7h8i9j0k1l2m3n4o5p6q7r8s9t0u1v2w3x4y5z6", ExpectedResult = "LETTERS = 26, DIGITS = 26")]
    [TestCase(
        "a1b2c3d4e5f6g7h8i9j0k1l2m3n4o5p6q7r8s9t0u1v2w3x4y5z6a1b2c3d4e5f6g7h8i9j0k1l2m3n4o5p6q7r8s9t0u1v2w3x4y5z6",
        ExpectedResult = "LETTERS = 52, DIGITS = 52")]
    [TestCase("Axion B1osystems", ExpectedResult = "LETTERS = 14, DIGITS = 1")]
    [Test]
    public string Should_Count_Letters_And_Digits(string input)
    {
        var c = new CountTheLettersAndDigits();

        return c.Count(input);
    }
}
