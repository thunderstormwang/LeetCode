using LeetCode.Models;

namespace LeetCode.Solution0101_0200
{
    public class Solution0146
    {
        public class LRUCache_Version1
        {
            private readonly int capacity;
            
            private readonly DoublyListNode dummyHead;
            private readonly DoublyListNode dummyTail;
            private readonly Dictionary<int, DoublyListNode> dict;
            private readonly Dictionary<DoublyListNode, int> dictReverse;

            public LRUCache_Version1(int capacity)
            {
                this.capacity = capacity;
                dummyHead = new DoublyListNode(0);
                dummyTail = new DoublyListNode(0);
                dummyHead.next = dummyTail;
                dummyTail.pre = dummyHead;
                dict = new Dictionary<int, DoublyListNode>();
                dictReverse = new Dictionary<DoublyListNode, int>();
            }

            public int Get(int key)
            {
                if (!dict.ContainsKey(key))
                {
                    return -1;
                }

                var target = dict[key];
                RemoveFromList(target);
                InsertAtHead(target);

                return target.val;
            }

            public void Put(int key, int value)
            {
                if (Get(key) != -1)
                {
                    dict[key].val = value;
                    return;
                }

                var target = new DoublyListNode(value);
                dict.Add(key, target);
                dictReverse.Add(target, key);

                InsertAtHead(target);
                RemoveLeastRecentlyUsed();
            }

            private void RemoveLeastRecentlyUsed()
            {
                if (dict.Count <= capacity)
                {
                    return;
                }

                var target = dummyTail.pre;
                RemoveFromList(target);
                var key = dictReverse[target];
                dictReverse.Remove(target);
                dict.Remove(key);
            }

            private void InsertAtHead(DoublyListNode target)
            {
                var pre = dummyHead;
                var next = dummyHead.next;
                next.pre = target;
                target.next = next;
                pre.next = target;
                target.pre = pre;
            }

            private void RemoveFromList(DoublyListNode target)
            {
                var pre = target.pre;
                var next = target.next;
                next.pre = target.pre;
                pre.next = target.next;
            }
        }

        public class LRUCache_Version2
        {
            private int _Capacity;
            private LinkedList<(int Key, int Value)> linkedList;
            private Dictionary<int, LinkedListNode<(int Key, int Value)>> _Dict;

            public LRUCache_Version2(int capacity)
            {
                _Capacity = capacity;
                linkedList = new LinkedList<(int Key, int Value)>();
                _Dict = new Dictionary<int, LinkedListNode<(int Key, int Value)>>();
            }

            public int Get(int key)
            {
                if (!_Dict.ContainsKey(key))
                {
                    return -1;
                }

                var target = _Dict[key];
                linkedList.Remove(target);
                linkedList.AddFirst(target);

                return target.Value.Value;
            }

            public void Put(int key, int value)
            {
                if (Get(key) != -1)
                {
                    linkedList.First.Value = (Key: key, Value: value);
                    return;
                }

                linkedList.AddFirst((Key: key, Value: value));
                _Dict.Add(key, linkedList.First);

                if (linkedList.Count <= _Capacity)
                {
                    return;
                }

                _Dict.Remove(linkedList.Last.Value.Key);
                linkedList.RemoveLast();
            }
        }
        
        // version1: 自己做資料結構
        // version2: 第一次才知道原來 .Net 提供 LinkedList 是 doubly linked list ...
    }
}