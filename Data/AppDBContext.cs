using Microsoft.EntityFrameworkCore;

namespace MathGameCRUD.Data
{
    public class AppDBContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }

        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    Post[] postsToSeed = new Post[2];

        //    for (int i = 1; i <= 2; i++)
        //    {
        //        postsToSeed[i - 1] = new Post
        //        {
        //            Id = i,
        //            userName = $"Post {i}",
        //            score = i
        //        };
        //    }

        //    modelBuilder.Entity<Post>().HasData(postsToSeed);
        //}
    }
}
