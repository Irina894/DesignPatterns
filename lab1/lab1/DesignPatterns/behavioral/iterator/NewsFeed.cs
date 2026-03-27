using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.iterator
{
    public class NewsFeed : INewsFeedCollection
    {
        private List<Post> posts = new List<Post>();

        public void AddPost(Post post)
        {
            posts.Add(post);
        }

        public List<Post> GetPosts()
        {
            return posts;
        }

        public IPostIterator CreateNewestFirstIterator()
        {
            return new NewestFirstIterator(this);
        }

        public IPostIterator CreateRelevantAdsIterator()
        {
            return new RelevantAdsIterator(this);
        }
    }
}
