namespace LeetCode.Solution0201_0500
{
    public class Solution0383
    {
        public bool CanConstruct(string ransomNote,
            string magazine)
        {
            var array = new int[26];
            foreach (var item in magazine)
            {
                array[item - 'a']++;
            }

            foreach (var item in ransomNote)
            {
                array[item - 'a']--;
            }

            foreach (var item in array)
            {
                if (item < 0)
                {
                    return false;
                }
            }

            return true;
        }
        
        // Time: O(N)
        // Space: O(1)
    }
}