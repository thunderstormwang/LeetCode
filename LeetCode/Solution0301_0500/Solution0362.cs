namespace LeetCode.Solution0301_0500;

public class Solution0362
{
    public class HitCounter_Ver1
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

    public class HitCounter_Ver2
    {
        private const int Length = 300;

        private int[] timestamps = new int [Length];
        private int[] counter = new int [Length];
        
        public void Hit(int timestamp)
        {
            var temp = timestamp % Length;
            if (timestamps[temp] == timestamp)
            {
                counter[temp]++;
                return;
            }

            timestamps[temp] = timestamp;
            counter[temp] = 1;
        }

        public int GetHits(int timestamp)
        {
            var result = 0;
            for (var i = 0; i < Length; i++)
            {
                if (timestamp -  timestamps[i] >= 300 )
                {
                    continue;
                }

                result += counter[i];
            }

            return result;
        }
    }
}