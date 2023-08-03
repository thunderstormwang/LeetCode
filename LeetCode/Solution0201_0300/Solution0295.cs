namespace LeetCode.Solution0201_0300;

public class Solution0295
{
    public class MedianFinder
    {
        private readonly PriorityQueue<int, int> _smallQueue = new PriorityQueue<int, int>();
        private readonly PriorityQueue<int, int> _largeQueue = new PriorityQueue<int, int>();

        public MedianFinder()
        {
        }

        public void AddNum(int num)
        {
            if (_largeQueue.Count == 0 || num > _largeQueue.Peek())
            {
                _largeQueue.Enqueue(num, num);
            }
            else
            {
                _smallQueue.Enqueue(-num, -num);
            }

            if (_largeQueue.Count - _smallQueue.Count > 1)
            {
                var temp = _largeQueue.Dequeue();
                _smallQueue.Enqueue(-temp, -temp);
            }

            if (_smallQueue.Count - _largeQueue.Count > 1)
            {
                var temp = _smallQueue.Dequeue();
                _largeQueue.Enqueue(-temp, -temp);
            }
        }

        public double FindMedian()
        {
            if (_smallQueue.Count != _largeQueue.Count)
            {
                return _largeQueue.Count > _smallQueue.Count
                    ? _largeQueue.Peek()
                    : _smallQueue.Peek() * -1;
            }

            return ((double)_smallQueue.Peek() * -1 + (double)_largeQueue.Peek()) / 2;
        }
    }
}