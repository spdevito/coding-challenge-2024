using Challenge;

namespace Tests;

public class PowerRangerTests
{
    [TestCase(2, 48, 65, ExpectedResult = 2)]
    [TestCase(3, 1, 27, ExpectedResult = 3)]
    [TestCase(1, 1, 1, ExpectedResult = 1)]
    [TestCase(2, 1, 100, ExpectedResult = 10)]
    [TestCase(3, 1, 100, ExpectedResult = 4)]
    [TestCase(4, 250, 1300, ExpectedResult = 2)]
    [TestCase(5, 250, 1300, ExpectedResult = 2)]
    [TestCase(6, 250, 1300, ExpectedResult = 1)]
    [TestCase(11, 250, 1300, ExpectedResult = 1)]
    [TestCase(12, 5, 100, ExpectedResult = 0)]
    [Test]
    public int Should_Count_Powers(int n, int a, int b)
    {
        var pr = new PowerRanger();

        return pr.CountPowers(n, a, b);
    }
}
