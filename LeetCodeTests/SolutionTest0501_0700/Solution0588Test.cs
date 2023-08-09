using FluentAssertions;
using LeetCode.Solution0501_0700;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0501_0700;

[TestFixture]
[Category("SolutionTest0501_0700")]
public class Solution0588Test
{
    [Test]
    public void FileSystem_Ver1Test()
    {
        var solution = new Solution0588.FileSystem_Ver1();

        solution.Ls("/");
        solution.Mkdir("/a/b/c");
        solution.AddContentToFile("/a/b/c/d", "hello");
        solution.Ls("/");
        solution.ReadContentFromFile("/a/b/c/d").Should().Be("hello");
    }
}