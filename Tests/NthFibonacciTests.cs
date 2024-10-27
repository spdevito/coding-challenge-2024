using Challenge;

namespace Tests;

public class NthFibonacciTests
{
    [TestCase(1, ExpectedResult = "1")]
    [TestCase(2, ExpectedResult = "1")]
    [TestCase(3, ExpectedResult = "2")]
    [TestCase(7, ExpectedResult = "13")]
    [TestCase(10, ExpectedResult = "55")]
    [TestCase(20, ExpectedResult = "6765")]
    [TestCase(30, ExpectedResult = "832040")]
    [TestCase(140, ExpectedResult = "81055900096023504197206408605")]
    [TestCase(150, ExpectedResult = "9969216677189303386214405760200")]
    [TestCase(170, ExpectedResult = "150804340016807970735635273952047185")]
    [Test]
    public string Should_Return_Nth_Fibonacci_Number(int input)
    {
        var nf = new NthFibonacci();

        return nf.Fibonacci(input);
    }
}
