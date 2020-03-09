using InlibrisVeritas.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InlibrisVeritas.Data
{
    public class BloggDbContext : DbContext
    {
        public BloggDbContext(DbContextOptions<BloggDbContext> options) : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; }
    }
}
