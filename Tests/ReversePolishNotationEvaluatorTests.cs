using Challenge;

namespace Tests;

public class ReversePolishNotationEvaluatorTests
{
    [Test]
    [TestCaseSource(nameof(TestCaseValidDataSource))]
    public void EvaluateRPN_ShouldReturnCorrectResult(int expected, string[] input)
    {
        var evaluator = new ReversePolishNotationEvaluator();

        Assert.That(evaluator.EvaluateRPN(input), Is.EqualTo(expected));
    }

    [Test]
    public void EvaluateRPN_EdgeCase_DivideByZero()
    {
        var evaluator = new ReversePolishNotationEvaluator();

        // 1. Division by zero (should throw an exception)
        Assert.Throws<DivideByZeroException>(() => evaluator.EvaluateRPN(["4", "0", "/"]));
    }

    [Test]
    public void EvaluateRPN_EdgeCase_InvalidExpression()
    {
        var evaluator = new ReversePolishNotationEvaluator();

        // 2. Invalid expression (not enough operands)
        Assert.Throws<InvalidOperationException>(() => evaluator.EvaluateRPN(["2", "+"]));
    }

    [Test]
    public void EvaluateRPN_EdgeCase_TooManyOperands()
    {
        var evaluator = new ReversePolishNotationEvaluator();

        // 3. Invalid expression (too many operands)
        Assert.Throws<InvalidOperationException>(() => evaluator.EvaluateRPN(["2", "3", "4", "+"]));
    }

    [Test]
    public void EvaluateRPN_EdgeCase_UnknownOperatior()
    {
        var evaluator = new ReversePolishNotationEvaluator();

        // 3. Invalid expression (too many operands)
        Assert.Throws<InvalidOperationException>(() => evaluator.EvaluateRPN(["2", "3", "unknownOperator"]));
    }

    private static IEnumerable<TestCaseData> TestCaseValidDataSource()
    {
        return new List<TestCaseData>
        {
            new(5, new[] { "5" }),
            new(9, new[] { "2", "1", "+", "3", "*" }),
            new(6, new[] { "4", "13", "5", "/", "+" }),
            new(22, new[] { "10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+" }),
            new(6, new[] { "-2", "-3", "*" }),
            new(2, new[] { "8", "4", "/" })
        };
    }
}
