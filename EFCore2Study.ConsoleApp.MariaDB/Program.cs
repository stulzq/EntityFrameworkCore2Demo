using System;
using EFCore2Study.Model;
using Microsoft.EntityFrameworkCore;

namespace EFCore2Study.ConsoleApp.SqlServer
{
    class Program
    {
static void Main(string[] args)
{
	using (var db = new BloggingContext())
	{
		db.Blogs.Add(new Blog { Url = "http://blogs.msdn.com/adonet" });
		var count = db.SaveChanges();
		Console.WriteLine("{0} records saved to database", count);

		Console.WriteLine();
		Console.WriteLine("All blogs in database:");
		foreach (var blog in db.Blogs)
		{
			Console.WriteLine(" - {0}", blog.Url);
		}
	}
	Console.ReadKey();
}
    }

	public class BloggingContext : DbContext
	{
		public DbSet<Blog> Blogs { get; set; }
		public DbSet<Post> Posts { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			//配置mysql 连接字符串
			optionsBuilder.UseMySql("Server=localhost;Port=3306;Database=BloggingDB; User=root;Password=;");
		}
	}
}
