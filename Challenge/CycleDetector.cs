using Challenge.Tree;

namespace Challenge;

/// <summary>
/// Detect cycles in a graph.
///
/// Output examples:
/// <code>
/// </code>
///
/// <seealso cref="Graph"/>
/// <seealso cref="Edge"/>
/// <seealso cref="Node"/>
/// </summary>
public class CycleDetector
{
    /// <summary>
    /// Determines whether the given graph has any cycles.
    ///
    /// The method should traverse the graph and check for any circular paths,
    /// returning <c>true</c> if a cycle is found, or <c>false</c> otherwise.
    /// This can be achieved using depth-first search (DFS) or breadth-first search (BFS).
    ///
    /// For example, given the following graph:
    /// <code>
    /// FromEdgeNotation(new string[] {
    ///     "A-B",
    ///     "B-C",
    ///     "C-D",
    ///     "D-A"
    /// })
    /// </code>
    /// The method would return <c>true</c> because there is a cycle: A → B → C → D → A.
    ///
    /// However, if the graph was:
    /// <code>
    /// FromEdgeNotation(new string[] {
    ///     "A-B",
    ///     "B-C",
    ///     "C-D"
    /// })
    /// </code>
    /// The method would return <c>false</c> because there are no cycles.
    ///
    /// <param name="graph">The graph to be analyzed for cycles.</param>
    /// <returns><c>true</c> if the graph contains a cycle; <c>false</c> otherwise.</returns>
    public bool HasCycles(Graph graph)
    {
        /*** TODO: Implement me! */
        throw new NotImplementedException();
    }
}
