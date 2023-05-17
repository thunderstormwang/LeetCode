namespace LeetCode.Solution0501_9999;

public class Solution0981
{
    public class TimeMap_Ver1
    {
        private readonly Dictionary<string, List<(int Timestamp, string Value)>> _dict = new();

        public TimeMap_Ver1()
        {
        }

        public void Set(string key, string value, int timestamp)
        {
            if (!_dict.ContainsKey(key))
            {
                _dict.Add(key, new List<(int, string)>());
            }

            _dict[key].Add((timestamp, value));
        }

        public string Get(string key, int timestamp)
        {
            if (!_dict.ContainsKey(key))
            {
                return "";
            }

            var list = _dict[key];

            if (list[list.Count - 1].Timestamp <= timestamp)
            {
                return list[list.Count - 1].Value;
            }

            var left = 0;
            var right = list.Count - 1;

            while (left <= right)
            {
                var middle = left + (right - left) / 2;
                if (list[middle].Timestamp == timestamp)
                {
                    return list[middle].Value;
                }

                if (list[middle].Timestamp < timestamp)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            }

            if (left == 0)
            {
                return "";
            }

            return list[left].Timestamp <= timestamp ? list[left].Value : list[left - 1].Value;
        }
    }
}