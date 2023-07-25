namespace LeetCode.Solution0301_0500;

public class Solution0362
{
    public class HitCounter
    {
        private readonly Queue<int> _queue = new Queue<int>();

        public void Hit(int timestamp)
        {
            _queue.Enqueue(timestamp);
        }

        public int GetHits(int timestamp)
        {
            while (_queue.Count > 0 && timestamp - _queue.Peek() >= 300)
            {
                _queue.Dequeue();
            }

            return _queue.Count;
        }
    }
}