namespace LeetCode
{
    public class Solution66
    {
        public int[] PlusOne(int[] digits)
        {
            // 在每個位數字計算結果
            // 從個位數( digits[digits.Length-1] 開始計算新數字, 如果進位就加到下一個位數內
            // 如果在 digits[0] 計算出須進位, 宣告新 array[舊長度+1], array[0] = 新進位, array[1] 之後則複製舊陣列

            int addNumber = 1;
            digits[digits.Length - 1] += addNumber;

            int addToNextPlace = 0;
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                digits[i] += addToNextPlace;
                addToNextPlace = (digits[i] - digits[i] % 10) / 10;
                digits[i] = digits[i] % 10;
            }

            if (addToNextPlace > 0)
            {
                int[] result = new int[digits.Length + 1];
                result[0] = addToNextPlace;
                for (int i = 0; i < digits.Length; i++)
                {
                    result[i + 1] = digits[i];
                }
                return result;
            }
            else
            {
                return digits;
            }
        }
    }
}