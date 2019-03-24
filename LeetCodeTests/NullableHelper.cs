namespace LeetCode.Tests
{
    public static class NullableHelper
    {
        public static int? TryParse(this string val)
        {
            int i;
            return int.TryParse(val, out i) ? (int?)i : null;
        }
    }
}