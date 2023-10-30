
using Microsoft.EntityFrameworkCore;
using OA_DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA_Repository
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<UserInfo> UserInfo { get; set; }
        public DbSet<UserPost> UserPost { get; set; }
        public DbSet<UserPostContent> UserPostContent { get; set; }
        public DbSet<UserFollowers> UserFollowers { get; set; }
    }
}
