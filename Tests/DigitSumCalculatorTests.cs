using Challenge;

namespace Tests;

public class DigitSumCalculatorTests
{
    [Test]
    [TestCaseSource(nameof(TestCaseDataSource))]
    public void SumOfDigits_PositiveValue_ShouldReturnCorrectValue(int expected, int input)
    {
        var calculator = new DigitSumCalculator();

        Assert.That(calculator.SumOfDigits(input), Is.EqualTo(expected));
    }

    [Test]
    public void SumOfDigits_NegativeValue_ShouldThrowArgumentException()
    {
        var calculator = new DigitSumCalculator();

        Assert.Throws<ArgumentException>(() => calculator.SumOfDigits(-1));
    }

    private static IEnumerable<TestCaseData> TestCaseDataSource() =>
        new List<TestCaseData>
        {
            new(6, 123),
            new(0, 0),
            new(15, 555),
            new(1, 10),
            new(1, 1000000),
            new(2, 101),
            new(3, 102),
            new(23, 314159),
            new(45, 1234567890)
        };
}
