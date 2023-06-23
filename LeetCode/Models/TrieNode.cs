namespace LeetCode.Models;

public class TrieNode 
{
    public string Word;
    
    private readonly TrieNode[] children;
    
    public TrieNode() 
    {
        children = new TrieNode[26];
    }
    
    public TrieNode Get(char ch) 
    {
        return children[ch - 'a'];
    }
    
    public void Add(char ch, TrieNode node) 
    {
        children[ch - 'a'] = node;
    }
}