using Challenge;

namespace Tests;

public class AnagramCheckerTests
{
    [Test]
    [TestCaseSource(nameof(TestCaseValidDataSource))]
    public void AreAnagrams_ForAnagramStrings_ShouldReturnTrue(string first, string second)
    {
        var checker = new AnagramChecker();

        Assert.That(checker.AreAnagrams(first, second), Is.True);
    }

    [Test]
    [TestCaseSource(nameof(TestCaseInvalidDataSource))]
    public void AreAnagrams_ForRandomStrings_ShouldReturnFalse(string first, string second)
    {
        var checker = new AnagramChecker();

        Assert.That(checker.AreAnagrams(first, second), Is.False);
    }

    private static IEnumerable<TestCaseData> TestCaseValidDataSource() =>
        new List<TestCaseData>
        {
            new("Listen", "Silent"),
            new("Dormitory", "Dirty room"),
            new("The eyes", "They see"),
            new("Astronomer", "Moon starer"),
            new("The Morse Code", "Here come dots"),
            new("Funeral", "Real fun")            
        };

    private static IEnumerable<TestCaseData> TestCaseInvalidDataSource() =>
        new List<TestCaseData>
        {
            new("Hello", "World"),
            new("Test", "Taste"),
            new("abc", "def"),
            new("Test", "T3st")
        };
}
