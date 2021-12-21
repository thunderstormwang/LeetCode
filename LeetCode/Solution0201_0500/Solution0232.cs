using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;

namespace LeetCode.Solution0201_0500
{
    public class Solution0232
    {
        public class MyQueue_Version1
        {
            private readonly Stack<int> simulateQueue;
            private readonly Stack<int> stack;

            public MyQueue_Version1()
            {
                simulateQueue = new Stack<int>();
                stack = new Stack<int>();
            }

            /// <summary>
            /// Time: O(N)
            /// Space: O(N)
            /// </summary>
            /// <param name="x"></param>
            public void Push(int x)
            {
                stack.Clear();
                while (simulateQueue.Count > 0)
                {
                    stack.Push(simulateQueue.Pop());
                }

                simulateQueue.Push(x);
                while (stack.Count > 0)
                {
                    simulateQueue.Push(stack.Pop());
                }
            }

            /// <summary>
            /// Time: O(1)
            /// Space: O(1)
            /// </summary>
            /// <returns></returns>
            public int Pop()
            {
                return simulateQueue.Pop();
            }

            /// <summary>
            /// Time: O(1)
            /// Space: O(1)
            /// </summary>
            /// <returns></returns>
            public int Peek()
            {
                return simulateQueue.Peek();
            }

            /// <summary>
            /// Time: O(1)
            /// Space: O(1)
            /// </summary>
            /// <returns></returns>
            public bool Empty()
            {
                return simulateQueue.Count == 0;
            }
        }

        public class MyQueue_Version2
        {
            private readonly Stack<int> inputStack;
            private readonly Stack<int> outputStack;
            private int front = 0;

            public MyQueue_Version2()
            {
                outputStack = new Stack<int>();
                inputStack = new Stack<int>();
            }

            /// <summary>
            /// Time: O(1)
            /// Space: O(N)
            /// </summary>
            /// <returns></returns>
            public void Push(int x)
            {
                if (inputStack.Count == 0)
                {
                    front = x;
                }

                inputStack.Push(x);
            }

            /// <summary>
            /// Time: Amortized O(1), Worst-case O(N)
            /// Space: O(1)
            ///
            /// 這邊時間複雜度不直接用最壞情況 O(N) 的原因是：
            /// 假設一個情況 push, push, push, .... 連續 N 個 push 後再接 N 個 pop
            /// 第一次的 pop 會是 O(N), 之後的 pop 都會是 O(1)
            /// 這就是 Amortized 的基本原理, 因為最壞情況不會一直發生, 那每次計算成本都用最壞情況去計算就顯得不合理
            /// </summary>
            /// <returns></returns>
            public int Pop()
            {
                if (outputStack.Count > 0)
                {
                    return outputStack.Pop();
                }

                while (inputStack.Count > 0)
                {
                    outputStack.Push(inputStack.Pop());
                }

                return outputStack.Pop();
            }

            /// <summary>
            /// Time: O(1)
            /// Space: O(1)
            /// </summary>
            /// <returns></returns>
            public int Peek()
            {
                return outputStack.Count == 0 ? front : outputStack.Peek();
            }

            /// <summary>
            /// Time: O(1)
            /// Space: O(1)
            /// </summary>
            /// <returns></returns>
            public bool Empty()
            {
                return inputStack.Count == 0 && outputStack.Count == 0;
            }
        }
    }
}