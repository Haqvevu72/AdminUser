using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Post
    {

        public static int ID { get; set; } = 0;
        public int id { get; set; } = 0;
        public string? Content { get; set; }
        public DateTime? CreationTime { get; set; }
        public int LikeCount { get; set; }
        public int ViewCount { get; set; }

        // => Constructor of `Post` class
        public Post(string? content, DateTime? creationTime, int likeCount, int viewCount)
        {
            id = ++ID;
            Content = content;
            CreationTime = creationTime;
            LikeCount = likeCount;
            ViewCount = viewCount;
        }

        // => Overriding `ToString()` method
        public override string ToString()
        {
            return $"ID: {id}\nContent: {Content}\nCreation Time: {CreationTime}\n" +
                $"Like Count: {LikeCount}\nView Count: {ViewCount}";
        }

    }
}
