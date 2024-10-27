using Challenge;

namespace Tests;

public class ValidParenthesesTests
{
    [Test]
    [TestCaseSource(nameof(TestCaseValidDataSource))]
    public void Should_Pass_On_Valid_Parentheses(string input)
    {
        var par = new ValidParentheses();

        Assert.That(par.IsValid(input), Is.True, $"Should return True for '{input}'");
    }

    [Test]
    [TestCaseSource(nameof(TestCaseInalidDataSource))]
    public void Should_Fail_On_Invalid_Parentheses(string input)
    {
        var par = new ValidParentheses();

        Assert.That(par.IsValid(input), Is.False, $"Should return False for '{input}'");
    }

    private static IEnumerable<TestCaseData> TestCaseValidDataSource() =>
        new List<TestCaseData>
        {
            new(""),
            new("test"),
            new("3 - 9 * (5 + 3)"),
            new("this (is [() {[ () ]} ] is) valid"),
            new("((   {[({})]} test ((([{}])__[] __ ))))")
        };

    private static IEnumerable<TestCaseData> TestCaseInalidDataSource() =>
        new List<TestCaseData>
        {
            new("["),
            new("(((a))]"),
            new("((( ))"),
            new("({[})"),
            new("]()"),
            new(":-)")
        };
}
