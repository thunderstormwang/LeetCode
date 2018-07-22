namespace WebRequest
{
    // 此專案用來測試 Nsubstitube 如何偽造 HttpWebReqeust, 沒想到還挺難的....
    public class Program
    {
        static void Main(string[] args)
        {
            Post post = new Post();
            post.POSTExample();
        }
    }
}
