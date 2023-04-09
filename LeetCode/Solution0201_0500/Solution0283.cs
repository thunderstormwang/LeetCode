namespace LeetCode.Solution0201_0500;

public class Solution0283
{
     public void MoveZeroes(int[] nums) {
         var low = 0;
         var fast = 0;
 
         while(low < nums.Length && nums[low] != 0)
         {
             low++;
         }
         fast = low + 1;
 
         while(fast < nums.Length)
         {
             if(nums[fast] != 0)
             {
                 (nums[low], nums[fast]) = (nums[fast], nums[low]);
                 low++;
             }
 
             fast++;
         }
     }   
}