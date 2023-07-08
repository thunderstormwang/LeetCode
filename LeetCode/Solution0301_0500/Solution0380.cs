namespace LeetCodeTests.SolutionTest0301_0500;

public class Solution0380
{
    public class RandomizedSet
    {
        private readonly List<int> _list = new List<int>();
        private readonly Dictionary<int, int> _dict = new Dictionary<int, int>();

        public RandomizedSet()
        {
        }

        public bool Insert(int val)
        {
            if (_dict.ContainsKey(val))
            {
                return false;
            }

            _list.Add(val);
            _dict.Add(val, _list.Count - 1);
            return true;
        }

        public bool Remove(int val)
        {
            if (!_dict.ContainsKey(val))
            {
                return false;
            }

            var index = _dict[val];
            var lastVal = _list[_list.Count - 1];
            _list[index] = lastVal;
            _dict[lastVal] = index;
            _list.RemoveAt(_list.Count - 1);
            _dict.Remove(val);
            return true;
        }

        public int GetRandom()
        {
            var rand = new Random();
            var index = rand.Next(0, _list.Count);

            return _list[index];
        }
    }
}