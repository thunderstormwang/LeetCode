namespace LeetCode
{
    public class DoublyListNode
    {
        public int val;
        public DoublyListNode next;
        public DoublyListNode pre;

        public DoublyListNode(int v)
        {
            val = v;
            pre = null;
            next = null;
        }
    }
}