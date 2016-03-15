using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMaze
{
    class Context: DbContext
    {
        public Context() : base("PlayersDb")
        {

        }

        public DbSet<Player> Players { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>().Property(p => p.Name).IsRequired();
            modelBuilder.Entity<Player>().Property(p => p.Score).IsRequired();
            base.OnModelCreating(modelBuilder);
        }
    }
}
