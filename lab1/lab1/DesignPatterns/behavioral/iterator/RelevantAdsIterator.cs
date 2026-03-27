using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.iterator
{
    public class RelevantAdsIterator : IPostIterator
    {
        private List<Post> ads;
        private int position = 0;
        private int pageSize = 1;

        public RelevantAdsIterator(NewsFeed feed)
        {
            ads = feed.GetPosts()
                .Where(p => p.IsAd)
                .OrderByDescending(p => p.CreatedAt)
                .ToList();
        }

        public bool HasNext()
        {
            return position < ads.Count;
        }

        public Post Next()
        {
            if (position % pageSize == 0)
            {
                Console.WriteLine("Loading next portion of ads...");
            }

            return ads[position++];
        }
    }
}
