using System.Reflection;

namespace StackOverflow
{
    internal partial class Program
    {
        public class Post
    {
            public string _title { get; set; }
            public string _description { get; set; }
            public DateTime _time { get; set; }

            private int vote = 0;

            private int sum = 0;

           
            public DateTime DateTime()
            {
                return _time;
            }

            public Post(string title, string description, DateTime time) 
            {
                _title = title;
                _description = description;
                _time = time;
                
            }
            public void upVote()
            {
                vote++;

            }

            public void downVote()
            {
                vote--;
            }

            public void getVote()
            {
                sum += vote;
                Console.WriteLine("Your post has " + sum + " votes");
            }




        }
    }
}