namespace LeetCode.Solution0201_0300
{
    public class Solution0239
    {
        public int[] MaxSlidingWindow_Ver1(int[] nums, int k)
        {
            var result = new int[nums.Length - k + 1];
            IMonotonicQueue list = new ImpWithLinkedList();

            for (var i = 0; i < k; i++)
            {
                list.Push(nums[i]);
            }

            result[0] = list.Peek();
            for (var i = k; i < nums.Length; i++)
            {
                list.Pop(nums[i - k]);
                list.Push(nums[i]);
                result[i - k + 1] = list.Peek();
            }

            return result;
        }

        public int[] MaxSlidingWindow_Ve2(int[] nums, int k)
        {
            var result = new int[nums.Length - k + 1];
            IMonotonicQueue array = new ImpWithArray(k);

            for (var i = 0; i < k; i++)
            {
                array.Push(nums[i]);
            }

            result[0] = array.Peek();
            for (var i = k; i < nums.Length; i++)
            {
                array.Pop(nums[i - k]);
                array.Push(nums[i]);
                result[i - k + 1] = array.Peek();
            }

            return result;
        }

        /// <summary>
        /// a data structure the elements from the front to the end is strictly either increasing or decreasing
        /// </summary>
        private interface IMonotonicQueue
        {
            /// <summary>
            /// 查看隊伍首個元素
            /// </summary>
            /// <returns></returns>
            int Peek();

            /// <summary>
            /// 刪掉隊伍首個元素, 讓次大者上位
            /// </summary>
            /// <param name="input"></param>
            void Pop(int input);

            /// <summary>
            /// 在隊伍尾端加入元素, 將尾端元素比新元素小的皆刪除, 確保隊伍中的元素都是由大到小(或是由小到大)
            /// </summary>
            /// <param name="input"></param>
            void Push(int input);
        }

        private class ImpWithLinkedList : IMonotonicQueue
        {
            private readonly LinkedList<int> _list;

            public ImpWithLinkedList()
            {
                _list = new LinkedList<int>();
            }

            /// <inheritdoc />
            public int Peek()
            {
                return _list.First.Value;
            }

            /// <inheritdoc />
            public void Pop(int input)
            {
                if (_list.First.Value == input)
                {
                    _list.RemoveFirst();
                }
            }

            /// <inheritdoc />
            public void Push(int input)
            {
                while (_list.Count > 0 && _list.Last.Value < input)
                {
                    _list.RemoveLast();
                }

                _list.AddLast(input);
            }
        }

        private class ImpWithArray : IMonotonicQueue
        {
            private readonly int[] _array;
            private readonly int _capacity;

            private int _top;
            private int _bottom;

            public ImpWithArray(int capacity)
            {
                _capacity = capacity;
                _array = new int [capacity + 1];
                _top = 0;
                _bottom = 0;
            }

            /// <inheritdoc />
            public int Peek()
            {
                return _array[_top];
            }

            /// <inheritdoc />
            public void Pop(int input)
            {
                if (_array[_top] == input)
                {
                    _top = MoveForward(_top);
                }
            }

            /// <inheritdoc />
            public void Push(int input)
            {
                while (!IsEmpty() && _array[MoveBackward(_bottom)] < input)
                {
                    _bottom = MoveBackward(_bottom);
                }

                _array[_bottom] = input;
                _bottom = MoveForward(_bottom);
            }

            private int MoveForward(int pointer)
            {
                return (pointer + 1) % _capacity;
            }

            private int MoveBackward(int pointer)
            {
                return (pointer - 1 + _capacity) % _capacity;
            }

            private bool IsEmpty()
            {
                return _top == _bottom;
            }

            private bool IsFull()
            {
                return _top == MoveBackward(_bottom);
            }
        }
    }
}