using LeetCode.Models;

namespace LeetCode.Solution0201_0300;

public class Solution0208
{
    public class Trie
    {
        private readonly TrieNode _root;

        public Trie()
        {
            _root = new TrieNode();
        }

        public void Insert(string word)
        {
            var curr = _root;

            for (var i = 0; i < word.Length; i++)
            {
                if (curr.Get(word[i]) == null)
                {
                    curr.Add(word[i], new TrieNode());
                }

                curr = curr.Get(word[i]);
            }

            curr.Word = word;
        }

        public bool Search(string word)
        {
            var curr = _root;

            for (var i = 0; i < word.Length; i++)
            {
                if (curr.Get(word[i]) == null)
                {
                    return false;
                }

                curr = curr.Get(word[i]);
            }

            return curr.Word == word;
        }

        public bool StartsWith(string prefix)
        {
            var curr = _root;

            for (var i = 0; i < prefix.Length; i++)
            {
                if (curr.Get(prefix[i]) == null)
                {
                    return false;
                }

                curr = curr.Get(prefix[i]);
            }

            return true;
        }
    }
}