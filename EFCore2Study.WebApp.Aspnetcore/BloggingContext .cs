using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCore2Study.Model;
using Microsoft.EntityFrameworkCore;

namespace EFCore2Study.WebApp.Aspnetcore
{
	public class BloggingContext : DbContext
	{
		public BloggingContext(DbContextOptions<BloggingContext> options)
			: base(options)
		{ }

		public DbSet<Blog> Blogs { get; set; }
		public DbSet<Post> Posts { get; set; }
	}
}
