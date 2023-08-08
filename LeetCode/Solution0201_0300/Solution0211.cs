using LeetCode.Models;

namespace LeetCode.Solution0201_0300;

public class Solution0211
{
    public class WordDictionary_Ver1
    {
        private readonly TrieNode _root;

        public WordDictionary_Ver1()
        {
            _root = new TrieNode();
        }

        public void AddWord(string word)
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
            var currs = new List<TrieNode>() { _root };

            for (var i = 0; i < word.Length; i++)
            {
                var temp = new List<TrieNode>();

                if (word[i] == '.')
                {
                    for (var t = 0; t < currs.Count; t++)
                    {
                        for (var ch = 0; ch < 26; ch++)
                        {
                            var candidate = ((char)(ch + 'a'));
                            if (currs[t].Get(candidate) == null)
                            {
                                continue;
                            }

                            temp.Add(currs[t].Get(candidate));
                        }
                    }
                }
                else
                {
                    for (var t = 0; t < currs.Count; t++)
                    {
                        if (currs[t].Get(word[i]) == null)
                        {
                            continue;
                        }

                        temp.Add(currs[t].Get(word[i]));
                    }
                }

                currs = temp;
            }

            for (var i = 0; i < currs.Count; i++)
            {
                if (!string.IsNullOrEmpty(currs[i].Word))
                {
                    return true;
                }
            }

            return false;
        }
    }

    public class WordDictionary_Ver2
    {
        private readonly TrieNode _root;

        public WordDictionary_Ver2()
        {
            _root = new TrieNode();
        }

        public void AddWord(string word)
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
            return SearchWord(word, _root, 0);
        }

        private bool SearchWord(string word, TrieNode node, int i)
        {
            if (node == null)
            {
                return false;
            }

            if (i == word.Length)
            {
                return !string.IsNullOrEmpty(node.Word);
            }

            if (word[i] == '.')
            {
                for (var ch = 0; ch < 26; ch++)
                {
                    var candidate = ((char)(ch + 'a'));

                    if (SearchWord(word, node.Get(candidate), i + 1))
                    {
                        return true;
                    }
                }

                return false;
            }

            return SearchWord(word, node.Get(word[i]), i + 1);
        }
    }
}