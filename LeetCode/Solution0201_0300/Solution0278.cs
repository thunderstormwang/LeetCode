namespace LeetCode.Solution0201_0300;

public class Solution0278 : VersionControl
{
    /// <inheritdoc />
    public Solution0278(int firstBadVersion) : base(firstBadVersion)
    {
    }

    public int FirstBadVersion(int n)
    {
        var left = 0;
        var right = n;

        while (left <= right)
        {
            var index = left + (right - left) / 2;

            if (IsBadVersion(index))
            {
                right = index - 1;
            }
            else
            {
                left = index + 1;
            }
        }

        return left;
    }
}

public class VersionControl
{
    private int _firstBadVersion;

    public VersionControl(int firstBadVersion)
    {
        _firstBadVersion = firstBadVersion;
    }

    public bool IsBadVersion(int version)
    {
        return version >= _firstBadVersion;
    }
}