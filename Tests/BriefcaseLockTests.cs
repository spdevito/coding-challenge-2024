using Challenge;

namespace Tests;

public class BriefcaseLockTests
{
    [TestCase("0000", "0000", ExpectedResult = 0)]
    [TestCase("0000", "1000", ExpectedResult = 1)]
    [TestCase("9001", "0000", ExpectedResult = 2)]
    [TestCase("4089", "5672", ExpectedResult = 9)]
    [TestCase("1111", "1100", ExpectedResult = 2)]
    [TestCase("1111", "1234", ExpectedResult = 6)]
    [TestCase("2391", "4984", ExpectedResult = 10)]
    [TestCase("0000", "1987", ExpectedResult = 7)]
    [TestCase("1987", "0000", ExpectedResult = 7)]
    [TestCase("3333","8888", ExpectedResult = 20)]
    [Test]
    public int Should_Count_Fewest_Lock_Turns(string start, string target)
    {
        var bc = new BriefcaseLock();
        return bc.TurnsRequired(start, target);
    }
}
