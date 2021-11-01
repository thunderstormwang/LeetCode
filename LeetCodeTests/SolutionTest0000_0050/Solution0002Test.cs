using LeetCode.Solution0000_0050;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0000_0050
{
    [TestFixture]
    public class Solution0002Test
    {
        [TestCase(new int[] { 2, 4, 3 },
            new int[] { 5, 6, 4 },
            new int[] { 7, 0, 8 })]
        [TestCase(new int[] { 0 },
            new int[] { 0 },
            new int[] { 0 })]
        [TestCase(new int[] { 9, 9, 9, 9, 9, 9, 9 },
            new int[] { 9, 9, 9, 9 },
            new int[] { 8, 9, 9, 9, 0, 0, 0, 1 })]
        public void AddTwoNumbersTest(int[] array1,
            int[] array2,
            int[] expectedArray)
        {
            var solution = new Solution0002();
            var list1 = Utility.BuildListNode(array1);
            var list2 = Utility.BuildListNode(array2);

            var actual = solution.AddTwoNumbers(list1,
                list2);
            var expected = Utility.BuildListNode(expectedArray);

            Assert.AreEqual(Utility.CheckListNode(actual,
                    expected),
                true);
        }
    }
}