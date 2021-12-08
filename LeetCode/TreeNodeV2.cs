namespace LeetCode
{
    public class TreeNodeV2
    {
        public readonly int val;
        public TreeNodeV2 left;
        public TreeNodeV2 right;
        public TreeNodeV2 next;

        public TreeNodeV2(int val)
        {
            this.val = val;
        }

        public TreeNodeV2(int val,
            TreeNodeV2 left,
            TreeNodeV2 right,
            TreeNodeV2 next)
        {
            this.val = val;
            this.left = left;
            this.right = right;
            this.next = next;
        }
    }
}