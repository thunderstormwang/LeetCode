namespace LeetCode.Solution0201_0300
{
    public class Solution0225
    {
        public class MyStack_Version1
        {
            private Queue<int> queue;
            private Queue<int> tempQueue;
            private int front;

            public MyStack_Version1()
            {
                queue = new Queue<int>();
                tempQueue = new Queue<int>();
            }

            /// <summary>
            /// Time: O(1)
            /// Space: O(1)
            /// </summary>
            /// <param name="x"></param>
            public void Push(int x)
            {
                queue.Enqueue(x);
                front = x;
            }

            /// <summary>
            /// Time: O(N)
            /// Space: O(N)
            /// </summary>
            /// <returns></returns>
            public int Pop()
            {
                var count = queue.Count;

                if (count < 2)
                {
                    return queue.Dequeue();
                }

                while (count > 2)
                {
                    tempQueue.Enqueue(queue.Dequeue());
                    count--;
                }

                front = queue.Peek();
                tempQueue.Enqueue(queue.Dequeue());

                var result = queue.Dequeue();

                (queue, tempQueue) = (tempQueue, queue);

                return result;
            }

            /// <summary>
            /// Time: O(1)
            /// Space: O(1)
            /// </summary>
            /// <returns></returns>
            public int Top()
            {
                return front;
            }

            /// <summary>
            /// Time: O(1)
            /// Space: O(1)
            /// </summary>
            /// <returns></returns>
            public bool Empty()
            {
                return queue.Count == 0;
            }
        }

        public class MyStack_Version2
        {
            private readonly Queue<int> queue;
            private int front;

            public MyStack_Version2()
            {
                queue = new Queue<int>();
            }

            /// <summary>
            /// Time: O(1)
            /// Space: O(1)
            /// </summary>
            /// <param name="x"></param>
            public void Push(int x)
            {
                queue.Enqueue(x);
                front = x;
            }

            /// <summary>
            /// Time: O(N)
            /// Space: O(N)
            /// </summary>
            /// <returns></returns>
            public int Pop()
            {
                var count = queue.Count;

                if (count < 2)
                {
                    return queue.Dequeue();
                }

                while (count > 2)
                {
                    queue.Enqueue(queue.Dequeue());
                    count--;
                }

                front = queue.Peek();
                queue.Enqueue(queue.Dequeue());

                return queue.Dequeue();
            }

            /// <summary>
            /// Time: O(1)
            /// Space: O(1)
            /// </summary>
            /// <returns></returns>
            public int Top()
            {
                return front;
            }

            /// <summary>
            /// Time: O(1)
            /// Space: O(1)
            /// </summary>
            /// <returns></returns>
            public bool Empty()
            {
                return queue.Count == 0;
            }
        }
    }
}