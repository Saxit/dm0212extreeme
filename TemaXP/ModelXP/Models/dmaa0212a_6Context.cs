using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using ModelXP.Models.Mapping;

namespace ModelXP.Models
{
    public partial class dmaa0212a_6Context : DbContext
    {
        static dmaa0212a_6Context()
        {
            Database.SetInitializer<dmaa0212a_6Context>(null);
        }

        public dmaa0212a_6Context()
            : base("Name=dmaa0212a_6Context")
        {
        }

        public DbSet<Artwork> Artworks { get; set; }
        public DbSet<Auction> Auctions { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ArtworkMap());
            modelBuilder.Configurations.Add(new AuctionMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
        }
    }
}
