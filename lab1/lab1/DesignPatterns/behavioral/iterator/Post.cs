using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.iterator
{
    public class Post
    {
        public string Title { get; set; } = "";
        public string Content { get; set; } = "";
        public DateTime CreatedAt { get; set; }
        public bool IsAd { get; set; }

        public Post(string title, string content, DateTime createdAt, bool isAd)
        {
            Title = title;
            Content = content;
            CreatedAt = createdAt;
            IsAd = isAd;
        }

        public void Show()
        {
            string type = IsAd ? "[AD]" : "[POST]";
            Console.WriteLine($"{type} {Title} - {CreatedAt}");
        }
    }
}
