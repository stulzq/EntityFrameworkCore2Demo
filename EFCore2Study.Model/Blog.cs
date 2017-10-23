using System;
using System.Collections.Generic;

namespace EFCore2Study.Model
{
	public class Blog
	{
		public int BlogId { get; set; }
		public string Url { get; set; }

		public List<Post> Posts { get; set; }
	}
}
