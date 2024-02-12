using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using work_Relation_OneToOne.Model;

namespace work_Relation_OneToOne.Data
{
    internal class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options)
            : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<UserSettings> UserSettings { get; set; }

        protected override void OnModelCreating(ModelBuilder modBuilder)
        {
            modBuilder.Entity<User>().HasOne(e => e.UserSettings).WithOne(e => e.User).
                HasForeignKey<UserSettings>(e => e.UserId).
                OnDelete(DeleteBehavior.Cascade);
        }

        
    }
}
