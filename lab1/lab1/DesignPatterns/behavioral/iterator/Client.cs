using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.iterator
{
    public class Client
    {
        public static void Run()
        {

            NewsFeed feed = new NewsFeed();

            feed.AddPost(new Post("Morning News", "Weather is great", new DateTime(2026, 3, 26, 8, 0, 0), false));
            feed.AddPost(new Post("Buy Sneakers", "Best sale today", new DateTime(2026, 3, 26, 9, 0, 0), true));
            feed.AddPost(new Post("Tech Update", "New phone released", new DateTime(2026, 3, 26, 10, 0, 0), false));
            feed.AddPost(new Post("Travel Ad", "Visit Italy this summer", new DateTime(2026, 3, 26, 11, 0, 0), true));
            feed.AddPost(new Post("Sports News", "Team won the match", new DateTime(2026, 3, 26, 12, 0, 0), false));

            Console.WriteLine("\nNewest posts:");
            IPostIterator newestIterator = feed.CreateNewestFirstIterator();

            while (newestIterator.HasNext())
            {
                Post post = newestIterator.Next();
                post.Show();
            }

            Console.WriteLine("\nRelevant ads:");
            IPostIterator adsIterator = feed.CreateRelevantAdsIterator();

            while (adsIterator.HasNext())
            {
                Post post = adsIterator.Next();
                post.Show();
            }

            Console.WriteLine();
        }
    }
}