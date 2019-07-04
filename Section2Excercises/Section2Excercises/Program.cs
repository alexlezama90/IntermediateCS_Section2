using System;
using System.Threading;

namespace Section2Excercises
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Stopwatch Exercise
            //var stopwatch = new Stopwatch();

            //stopwatch.Start(DateTime.Now);
            //Thread.Sleep(5000);
            ////stopwatch.Stop(DateTime.Now);
            //Console.WriteLine("Te stopwatch worked: " + stopwatch.Stop(DateTime.Now));

            //Thread.Sleep(1000);
            //stopwatch.Start(DateTime.Now);
            //Thread.Sleep(3000);
            ////stopwatch.Stop(DateTime.Now);
            //Console.WriteLine("Te stopwatch worked: " + stopwatch.Stop(DateTime.Now));
            #endregion

            #region Post Exercise
            var post = new Post("Test Post", DateTime.Now);
            for (int i = 0; i < 5; i++)
            {
                post.Vote(true);
            }

            post.Vote(false);

            Console.WriteLine("Title: {0}", post.Title);
            Console.WriteLine("Created: {0}", post.CreationDateTime);
            Console.WriteLine("Votes: {0}", post.Votes);

            #endregion
        }
    }
}
