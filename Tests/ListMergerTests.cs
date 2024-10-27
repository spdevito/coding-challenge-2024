using Challenge;

namespace Tests;

public class ListMergerTests
{
    [Test]
    [TestCaseSource(nameof(TestCaseValidDataSource))]
    public void Should_Merge_Two_Lists(int[] expected, int[] left, int[] right)
    {
        var lm = new ListMerger();

        var merged = lm.Merge(left, right);
        CollectionAssert.AreEqual(expected, merged, $"Received [ {string.Join(", ", merged)} ]");
    }

    private static IEnumerable<TestCaseData> TestCaseValidDataSource()
    {
        return new List<TestCaseData>
        {
            new(
                new int[] { },
                new int[] { },
                new int[] { }),
            new(
                new[] { 1, 2, 3 },
                new[] { 1 },
                new[] { 2, 3 }),
            new(
                new[] { 1, 2, 2, 3, 4, 9 },
                new[] { 2, 3, 9 },
                new[] { 1, 2, 4 }),
            new(
                new[] { 1, 2 },
                new int[] { },
                new[] { 1, 2 }),
            new(
                new[] { 1, 2, 3, 7, 8, 9 },
                new[] { 7, 8, 9 },
                new[] { 1, 2, 3 }),
            new(
                new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
                new[] { 1, 2, 6 },
                new [] { 3, 4, 5, 7, 8, 9 }),
            new(
                new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
                new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
                new int[] { }),
            new(
                new[] { 1, 1, 1, 1},
                new[] {1, 1},
                new[] {1, 1}),
            new(
                new[] {-2, -1, 0, 1, 2},
                new[] {-2, 0, 2},
                new[] {-1, 1}),
            new(
                new[] {-20, -5, 10},
                new[] {-5},
                new[] {-20, 10})
        };
    }
}
