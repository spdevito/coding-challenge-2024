using Challenge;
using Challenge.Tree;

namespace Tests;

public class CycleDetectorTests
{
    [Test]
    public void Should_Return_False_For_Single_Node()
    {
        var graph = new Graph();
        var n = new Node("A");
        graph.AddNode(n);

        var cd = new CycleDetector();
        Assert.That(cd.HasCycles(graph), Is.False, "Should return False for a single node");
    }

    /// <summary>
    ///     <code>
    ///     A --- B --- C
    ///            \
    ///             D --- E --- F
    ///                   \
    ///                    G
    /// </code>
    /// </summary>
    [Test]
    public void Should_Return_False_For_A_Tree()
    {
        var graph = Graph.FromEdgeNotation([
            "A-B", "B-C",
            "B-D", "D-E", "E-F",
            "E-G"
        ]);

        var cd = new CycleDetector();
        Assert.That(cd.HasCycles(graph), Is.False, "Should return False for a tree");
    }

    /// <summary>
    ///     <code>
    ///     A --- B --- C --- H
    ///            \        /
    ///             D --- E --- F
    ///                   \
    ///                    G
    /// </code>
    /// </summary>
    [Test]
    public void Should_Return_True_For_If_Has_Cycle()
    {
        var graph = Graph.FromEdgeNotation([
            "A-B", "B-C", "C-H", "H-E",
            "B-D", "D-E", "E-F",
            "E-G"
        ]);

        var cd = new CycleDetector();
        Assert.That(cd.HasCycles(graph), Is.False, "Should return True if a cycle exists");
    }

    /// <summary>
    ///     <code>
    ///           A
    ///        /     \
    ///      B         C
    ///     / \       / \
    ///    D   E     F   G
    ///       / \
    ///      H   I
    ///           \
    ///            J
    /// </code>
    /// </summary>
    [Test]
    [Repeat(4)]
    public void Should_Return_4_For_Exemplary_Tree()
    {
        var bt = new BinaryTreeMaxDepth();

        var a = new BinaryNode("A");
        var b = new BinaryNode("B");
        var c = new BinaryNode("C");
        var d = new BinaryNode("D");
        var e = new BinaryNode("E");
        var f = new BinaryNode("F");
        var g = new BinaryNode("G");
        var h = new BinaryNode("H");
        var i = new BinaryNode("I");
        var j = new BinaryNode("J");

        a.SetChildren(b, c);
        b.SetChildren(d, e);
        c.SetChildren(f, g);
        e.SetChildren(h, i);
        i.SetChildren(null, j);

        Assert.That(bt.GetMaxDepth(a), Is.EqualTo(4), "Should return 4 for the exemplary tree");
    }


    [Test]
    [Repeat(3)]
    public void Should_Return_3_For_Chain()
    {
        var bt = new BinaryTreeMaxDepth();

        var a = new BinaryNode("A");
        var b = new BinaryNode("B");
        var c = new BinaryNode("C");
        var d = new BinaryNode("D");

        a.SetChildren(null, b);
        b.SetChildren(c, null);
        c.SetChildren(null, d);

        Assert.That(bt.GetMaxDepth(a), Is.EqualTo(3), "Should return 3 for the 'A-B-C-D' chain");
    }
}
