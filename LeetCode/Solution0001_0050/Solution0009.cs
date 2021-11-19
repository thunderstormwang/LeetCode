namespace LeetCode.Solution0001_0050
{
    public class Solution0009
    {
        public bool IsPalindrome(int x)
        {
            // 負數不給過
            // 12210, 122100 也不行
            if (x < 0 || ((x % 10) == 0) && x >= 10)
            {
                return false;
            }
            
            var reverse = 0;

            while (x > reverse)
            {
                reverse *= 10;
                reverse += x % 10;
                x /= 10;
            }

            return x == reverse || x == reverse / 10;
        }
        
        // 轉成字串再比較是較簡單的做法
        // 如果要照題目限制的不轉成字串, 會出現一些 special case 要處理
        // 不論哪一種, 複雜度都是
        // Time: O(log(n)), 底數為 10
        // Space: O(1)
    }
}