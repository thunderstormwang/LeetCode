using LeetCode.Models;

namespace LeetCode.Solution0201_0300;

public class Solution0212
{
    public IList<string> FindWords(char[][] board, string[] words)
    {
        var directions = new int[][]
        {
            new int[] { -1, 0 },
            new int[] { 1, 0 },
            new int[] { 0, -1 },
            new int[] { 0, 1 }
        };
        var result = new List<string>();

        // 建立字典樹
        var root = BuildTrie(words);

        // 輪詢二維字串陣列
        for (var i = 0; i < board.Length; i++)
        {
            for (var j = 0; j < board[0].Length; j++)
            {
                DepthFirstSearch(board, new int[] { i, j }, root, directions, result);
            }
        }

        return result;
    }

    private void DepthFirstSearch(char[][] board, int[] curr, TrieNode node, int[][] directions, List<string> result)
    {
        // 邊界判斷和當前字母是否已被訪問過
        if (curr[0] < 0 || curr[0] >= board.Length || curr[1] < 0 || curr[1] >= board[curr[0]].Length || board[curr[0]][curr[1]] == '#')
            return;

        // 取得當前字母的節點
        var ch = board[curr[0]][curr[1]];
        var nextNode = node.Get(ch);

        // 當前字母的節點，則此路徑不會匹配任何單詞，不用再走下去
        if (nextNode == null)
            return;

        // 判斷是否找到單詞
        if (!string.IsNullOrEmpty(nextNode.word))
        {
            result.Add(nextNode.word);
            // 避免重覆增加同樣單詞
            nextNode.word = null;
        }

        // 將當前字母標記已被訪問過
        board[curr[0]][curr[1]] = '#';

        // 遞迴訪問相鄰節點
        for (var i = 0; i < directions.Length; i++)
        {
            var next = new int[] { curr[0] + directions[i][0], curr[1] + directions[i][1] };
            DepthFirstSearch(board, next, nextNode, directions, result);
        }

        // 將當前字母標記未被訪問過
        board[curr[0]][curr[1]] = ch;
    }

    private TrieNode BuildTrie(string[] words)
    {
        var root = new TrieNode();

        foreach (var word in words)
        {
            var node = root;

            foreach (var ch in word)
            {
                var child = node.Get(ch);
                if (child == null)
                {
                    child = new TrieNode();
                    node.Add(ch, child);
                }

                node = child;
            }

            // 最後一個節點保存完整的單詞
            node.word = word;
        }

        return root;
    }
}