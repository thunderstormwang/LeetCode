namespace LeetCode.Solution0201_0300;

public class Solution0232
{
    public class MyQueue
    {
        private readonly Stack<int> _input;
        private readonly Stack<int> _output;
        private int front = 0;

        public MyQueue()
        {
            _output = new Stack<int>();
            _input = new Stack<int>();
        }

        public void Push(int x)
        {
            _input.Push(x);
        }

        public int Pop()
        {
            if (_output.Count == 0)
            {
                while (_input.Count != 0)
                {
                    var temp = _input.Pop();
                    _output.Push(temp);
                }
            }

            return _output.Pop();
        }

        public int Peek()
        {
            if (_output.Count == 0)
            {
                while (_input.Count != 0)
                {
                    var temp = _input.Pop();
                    _output.Push(temp);
                }
            }

            return _output.Peek();
        }

        public bool Empty()
        {
            return _input.Count == 0 && _output.Count == 0;
        }
    }
}