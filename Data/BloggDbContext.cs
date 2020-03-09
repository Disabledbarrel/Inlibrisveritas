using InlibrisVeritas.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InlibrisVeritas.Data
{
    public class BloggDbContext : IdentityDbContext<IdentityUser>
    {
        public BloggDbContext(DbContextOptions<BloggDbContext> options) : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed blogposts
            modelBuilder.Entity<Post>().HasData(new Post
            {
                PostId = 1,
                Title = "Möss och människor",
                Content = "Här kommer lite innehåll i inlägget",
                ImageUrl = "http://studenter.miun.se/~ella1800/dt102g/img/brazil.jpg",
                Created = DateTime.UtcNow
            });
            modelBuilder.Entity<Post>().HasData(new Post
            {
                PostId = 2,
                Title = "Aniara",
                Content = "Här kommer lite innehåll i inlägget",
                ImageUrl = "http://studenter.miun.se/~ella1800/dt102g/img/brazil.jpg",
                Created = DateTime.UtcNow
            });
        }
    }
}
