using LeetCode.Models;

namespace LeetCode.Solution0101_0200
{
    public class Solution0142
    {
        public ListNode DetectCycle(ListNode head)
        {
            // Floyd Cycle Detection Algorithm

            var dummyNode = new ListNode(0);
            dummyNode.next = head;
            var fast = dummyNode;
            var slow = dummyNode;

            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;

                if (slow == fast)
                {
                    break;
                }
            }

            if (slow != fast || fast == dummyNode || slow == dummyNode)
            {
                return null;
            }

            fast = dummyNode;
            while (fast != slow)
            {
                fast = fast.next;
                slow = slow.next;
            }

            return slow;
        }
        
        // 這題得用數學來解
        // 用 Floyd Cycle Detection Algorithm 可以確認是否有 circular list
        // slow 跟 fast 會合後, slow 保持在原點, 讓另一個指標(我用 fast)回到 head
        // 這次 slow, fast 同時各走一個節點, 最終會在入口處會合
        // 數學根據就不寫在這裡了
        
        // Time: O(N), N = 兩個 linked list 的長度
        // Space: O(1)
    }
}