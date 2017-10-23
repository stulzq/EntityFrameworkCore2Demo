using System;
using System.Collections.Generic;

namespace EFCore2Study.ConsoleApp.DBFirst.Models
{
    public partial class Post
    {
        public int PostId { get; set; }
        public int BlogId { get; set; }
        public string Content { get; set; }
        public string Title { get; set; }

        public Blog Blog { get; set; }
    }
}
