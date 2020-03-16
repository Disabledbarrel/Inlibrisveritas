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

    }
}
