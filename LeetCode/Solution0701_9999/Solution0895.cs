namespace LeetCode.Solution0701_9999;

public class Solution0895
{
    public class FreqStack
    {
        private readonly Dictionary<int, int> _numberFreqMapping = new Dictionary<int, int>();
        private readonly Dictionary<int, List<int>> _freqNumberMapping = new Dictionary<int, List<int>>();
        private int _maxFreq = 0;

        public FreqStack()
        {
        }

        public void Push(int val)
        {
            if (!_numberFreqMapping.ContainsKey(val))
            {
                _numberFreqMapping.Add(val, 0);
            }

            _numberFreqMapping[val]++;
            var freq = _numberFreqMapping[val];
            _maxFreq = Math.Max(_maxFreq, freq);

            if (!_freqNumberMapping.ContainsKey(freq))
            {
                _freqNumberMapping.Add(freq, new List<int>());
            }

            _freqNumberMapping[freq].Add(val);
        }

        public int Pop()
        {
            var list = _freqNumberMapping[_maxFreq];
            var result = list.Last();

            list.RemoveAt(list.Count - 1);
            if (list.Count == 0)
            {
                _freqNumberMapping.Remove(_maxFreq);
                _maxFreq--;
            }

            _numberFreqMapping[result]--;

            return result;
        }
    }
}