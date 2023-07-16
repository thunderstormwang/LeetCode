using LeetCode.Models;

namespace LeetCode.Solution0101_0150;

public class Solution0146
{
    public class LRUCache_Version1
    {
        private readonly int _capacity;
            
        private readonly DoublyListNode dummyHead;
        private readonly DoublyListNode dummyTail;
        private readonly Dictionary<int, DoublyListNode> _dict;
        private readonly Dictionary<DoublyListNode, int> _dictReverse;

        public LRUCache_Version1(int capacity)
        {
            _capacity = capacity;
            dummyHead = new DoublyListNode(0);
            dummyTail = new DoublyListNode(0);
            dummyHead.next = dummyTail;
            dummyTail.pre = dummyHead;
            _dict = new Dictionary<int, DoublyListNode>();
            _dictReverse = new Dictionary<DoublyListNode, int>();
        }

        public int Get(int key)
        {
            if (!_dict.ContainsKey(key))
            {
                return -1;
            }

            var target = _dict[key];
            RemoveFromList(target);
            InsertAtHead(target);

            return target.val;
        }

        public void Put(int key, int value)
        {
            if (Get(key) != -1)
            {
                _dict[key].val = value;
                return;
            }

            var target = new DoublyListNode(value);
            _dict.Add(key, target);
            _dictReverse.Add(target, key);

            InsertAtHead(target);
            RemoveLeastRecentlyUsed();
        }

        private void RemoveLeastRecentlyUsed()
        {
            if (_dict.Count <= _capacity)
            {
                return;
            }

            var target = dummyTail.pre;
            RemoveFromList(target);
            var key = _dictReverse[target];
            _dictReverse.Remove(target);
            _dict.Remove(key);
        }

        private void InsertAtHead(DoublyListNode target)
        {
            var temp = dummyHead.next;
            temp.pre = target;
            target.next = temp;
            dummyHead.next = target;
            target.pre = dummyHead;
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
        private int _capacity;
        private LinkedList<(int Key, int Value)> linkedList;
        private Dictionary<int, LinkedListNode<(int Key, int Value)>> _dict;

        public LRUCache_Version2(int capacity)
        {
            _capacity = capacity;
            linkedList = new LinkedList<(int Key, int Value)>();
            _dict = new Dictionary<int, LinkedListNode<(int Key, int Value)>>();
        }

        public int Get(int key)
        {
            if (!_dict.ContainsKey(key))
            {
                return -1;
            }

            var target = _dict[key];
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
            _dict.Add(key, linkedList.First);

            if (linkedList.Count <= _capacity)
            {
                return;
            }

            _dict.Remove(linkedList.Last.Value.Key);
            linkedList.RemoveLast();
        }
    }
}