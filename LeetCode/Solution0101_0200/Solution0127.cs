namespace LeetCode.Solution0101_0200;

public class Solution0127
{
    public int LadderLength_Ver1(string beginWord, string endWord, IList<string> wordList)
    {
        var result = 0;
        var wordSet = new HashSet<string>();
        var queue = new Queue<string>();

        for (var i = 0; i < wordList.Count; i++)
        {
            wordSet.Add(wordList[i]);
        }
        
        if (!wordSet.Contains(endWord))
        {
            return 0;
        }

        queue.Enqueue(beginWord);

        while (queue.Count != 0)
        {
            var queueCnt = queue.Count;

            for (var cnt = 0; cnt < queueCnt; cnt++)
            {
                var word = queue.Dequeue();
                
                if (word == endWord)
                {
                    return result + 1;
                }
                
                for (var i = 0; i < word.Length; i++)
                {
                    for (var c = 0; c < 26; c++)
                    {
                        var temp = word.ToCharArray();
                        temp[i] = (char)('a' + c);
                        var newWord = new string(temp);

                        if (wordSet.Contains(newWord) && newWord != word)
                        {
                            queue.Enqueue(newWord);
                            wordSet.Remove(newWord);
                        }
                    }
                }
            }

            result++;
        }

        return 0;
    }

    public int LadderLength_Ver2(string beginWord, string endWord, IList<string> wordList)
    {
        var result = 0;
        var wordSet = new HashSet<string>();
        var set1 = new HashSet<string>();
        var set2 = new HashSet<string>();

        for (var i = 0; i < wordList.Count; i++)
        {
            wordSet.Add(wordList[i]);
        }
        
        if (!wordSet.Contains(endWord))
        {
            return 0;
        }
        
        set1.Add(beginWord);
        set2.Add(endWord);
        wordSet.Remove(endWord);
        
        while(set1.Count != 0 && set2.Count != 0)
        {
            if (set1.Count > set2.Count)
            {
                (set1, set2) = (set2, set1);
            }

            var tempSet = new HashSet<string>();
            var words = set1.ToArray();

            for (var cnt = 0; cnt < words.Length; cnt++)
            {
                var word = words[cnt];
                
                if (set2.Contains(word))
                {
                    return result + 1;
                }

                for (var i = 0; i < word.Length; i++)
                {
                    for (var c = 0; c < 26; c++)
                    {
                        var temp = word.ToCharArray();
                        temp[i] = (char)('a' + c);
                        var newWord = new string(temp);

                        if (wordSet.Contains(newWord) || set2.Contains(newWord))
                        {
                            tempSet.Add(newWord);
                            wordSet.Remove(newWord);
                        }
                    }
                }
            }
            
            set1 = tempSet;
            result++;
        }

        return 0;
    }
}