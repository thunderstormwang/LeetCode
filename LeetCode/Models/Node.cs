namespace LeetCode.Models;

public class Node
{
    public int val;
    public IList<Node> children;

    public Node()
    { }

    public Node(int val)
    {
        this.val = val;
    }

    public Node(int val,
        IList<Node> children)
    {
        this.val = val;
        this.children = children;
    }
}