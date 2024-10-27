using Challenge;

namespace Tests;

public class BitAlternatorTests
{
    [TestCase(1, ExpectedResult = true)]
    [TestCase(0, ExpectedResult = true)]
    [TestCase(2, ExpectedResult = true)]
    [TestCase(3, ExpectedResult = false)]
    [TestCase(85, ExpectedResult = true)]
    [TestCase(213, ExpectedResult = false)]
    [TestCase(212, ExpectedResult = false)]
    [TestCase(1431655765, ExpectedResult = true)]
    [TestCase(1431655465, ExpectedResult = false)]
    [TestCase(int.MaxValue, ExpectedResult = false)]
    public bool BitsAreAlternating(int aInputNumber)
    {
        return BitAlternator.IntegerHasAlternatingBits(aInputNumber);
    }
}