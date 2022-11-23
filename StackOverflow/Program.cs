namespace StackOverflow
{
    internal partial class Program
    {    
        static void Main(string[] args)
        {
            var post = new Post("Hej","Goddag",DateTime.Now);

            Console.WriteLine(post._title + " " + post._description + " " + post._time);

            
            post.upVote();
            post.upVote();
            post.upVote();
            post.downVote();

            post.getVote();
   
        }
    }
}