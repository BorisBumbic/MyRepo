using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloggy.Domain
{
    public class BlogPost
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
    }

    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int BlogPostId { get; set; }
    }

    public class Tags
    {
        public int Id { get; set; }
        public string name { get; set; }
    }
}
