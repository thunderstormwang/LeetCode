using System.Collections.Generic;

namespace LeetCode.Solution0201_0500
{
    public class Solution0239
    {
        public int[] MaxSlidingWindow_Version1(int[] nums,
            int k)
        {
            var result = new int[nums.Length - k + 1];
            IMonotonicQueue queue = new ImpWithQueue();
            for (var i = 0; i < k; i++)
            {
                queue.Push(nums[i]);
            }

            result[0] = queue.Peek();
            for (var i = k; i < nums.Length; i++)
            {
                queue.Pop(nums[i - k]);
                queue.Push(nums[i]);
                result[i - k + 1] = queue.Peek();
            }

            return result;
        }

        public int[] MaxSlidingWindow_Version2(int[] nums,
            int k)
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

        public int[] MaxSlidingWindow_Version3(int[] nums,
            int k)
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

        private class ImpWithQueue : IMonotonicQueue
        {
            private readonly Queue<int> queue;

            public ImpWithQueue()
            {
                queue = new Queue<int>();
            }

            /// <inheritdoc />
            public int Peek()
            {
                return queue.Peek();
            }

            /// <inheritdoc />
            public void Pop(int input)
            {
                if (queue.Peek() == input)
                {
                    queue.Dequeue();
                }
            }

            /// <inheritdoc />
            public void Push(int input)
            {
                var count = queue.Count;
                while (count > 0)
                {
                    if (queue.Peek() >= input)
                    {
                        queue.Enqueue(queue.Dequeue());
                    }
                    else
                    {
                        queue.Dequeue();
                    }

                    count--;
                }

                queue.Enqueue(input);
            }
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
                    _top = MoveBackward(_top);
                }
            }

            /// <inheritdoc />
            public void Push(int input)
            {
                while (!IsEmpty() && _array[MoveForward(_bottom)] < input)
                {
                    _bottom = MoveForward(_bottom);
                }

                _array[_bottom] = input;
                _bottom = MoveBackward(_bottom);
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
                return MoveForward(_top) == _bottom;
            }
        }

        // 用暴力法
        // 每移動一個位置, 即比較 k 個元素的最大值
        // Time: O(N*K)
        // Space: O(N-K)
        
        //=======
        
        // 用 Monotonic Queue
        // Time: O(N)
        // Space: O(N)
    }
}