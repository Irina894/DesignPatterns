using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.iterator
{
    public class NewestFirstIterator : IPostIterator
    {
        private List<Post> posts;
        private int position = 0;
        private int pageSize = 2;

        public NewestFirstIterator(NewsFeed feed)
        {
            posts = feed.GetPosts()
                .OrderByDescending(p => p.CreatedAt)
                .ToList();
        }

        public bool HasNext()
        {
            return position < posts.Count;
        }

        public Post Next()
        {
            if (position % pageSize == 0)
            {
                Console.WriteLine("Loading next portion of newest posts...");
            }

            return posts[position++];
        }
    }
}
