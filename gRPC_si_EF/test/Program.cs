using System;
using PostComment.APIStatic;
using PostComment;
namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Post p = new Post();
            p.Description = "test";
            bool a = API.AddPost(p);
            Console.WriteLine(a);
        }
    }
}
