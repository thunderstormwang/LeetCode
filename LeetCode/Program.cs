namespace LeetCode
{
    public class Program
    {
        public static int Main(string[] args)
        {
            ListNode head = new ListNode(3);
            Solution141 solution = new Solution141();
            bool result = solution.HasCycle(head);

            return 0;
        }
    }
}