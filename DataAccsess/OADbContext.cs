using DataAccsess.DbEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccsess
{
    public class OADbContext : DbContext
    {
        public OADbContext(DbContextOptions<OADbContext> options) : base(options)
        {
        }

        public DbSet<Post> Post { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
