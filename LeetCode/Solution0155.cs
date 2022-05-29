namespace LeetCode
{
    public class Solution0155
    {
        public class MinStack
        {
            private readonly Stack<int> stack = null;
            private readonly Stack<int> minStack = null;

            /** initialize your data structure here. */
            public MinStack()
            {
                stack = new Stack<int>();
                minStack = new Stack<int>();
                minStack.Push(int.MaxValue);
            }

            public void Push(int x)
            {
                stack.Push(x);
                if (x <= minStack.Peek())
                {
                    minStack.Push(x);
                }
            }

            public void Pop()
            {
                int result = stack.Pop();

                if (result == minStack.Peek())
                {
                    minStack.Pop();
                }
            }

            public int Top()
            {
                return stack.Peek();
            }

            public int GetMin()
            {
                return minStack.Peek();
            }
        }
    }
}