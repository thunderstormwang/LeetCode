namespace LeetCodeTests.SolutionTest0151_0200;

public class Solution0155
{
    public class MinStack
    {
        private Stack<int> _stack;
        private Stack<int> _minStack;

        public MinStack()
        {
            _stack = new Stack<int>();
            _minStack = new Stack<int>();
        }

        public void Push(int val)
        {
            _stack.Push(val);

            if (_minStack.Count == 0 || val <= _minStack.Peek())
            {
                _minStack.Push(val);
            }
        }

        public void Pop()
        {
            var temp = _stack.Pop();

            if (temp == _minStack.Peek())
            {
                _minStack.Pop();
            }
        }

        public int Top()
        {
            return _stack.Peek();
        }

        public int GetMin()
        {
            return _minStack.Peek();
        }
    }
}