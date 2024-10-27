using Challenge;

namespace Tests;

public class NumberPalindromeTests
{
    [Test]
    [TestCaseSource(nameof(TestCaseValidDataSource))]
    public void Should_Pass_On_Palindrome(ulong input)
    {
        var np = new NumberPalindrome();

        Assert.That(np.IsPalindrome(input), Is.True, $"Should return True for {input}");
    }

    [Test]
    [TestCaseSource(nameof(TestCaseInvalidDataSource))]
    public void Should_Fail_On_NonPalindrome(ulong input)
    {
        var np = new NumberPalindrome();

        Assert.That(np.IsPalindrome(input), Is.False, $"Should return False for {input}");
    }

    private static IEnumerable<TestCaseData> TestCaseValidDataSource() =>
        new List<TestCaseData>
        {
            new(0UL),
            new(9UL),
            new(11UL),
            new(121UL),
            new(1221UL),
            new(12345654321UL)
        };

    private static IEnumerable<TestCaseData> TestCaseInvalidDataSource() =>
        new List<TestCaseData>
        {
            new(12UL),
            new(123123UL),
            new(1234021UL),
            new(12340321UL)
        };
}
