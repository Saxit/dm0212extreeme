using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ModelXP.Models.Mapping
{
    public class AuctionMap : EntityTypeConfiguration<Auction>
    {
        public AuctionMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.itemText)
                .HasMaxLength(2000);

            // Table & Column Mappings
            this.ToTable("Auction");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.startingBid).HasColumnName("startingBid");
            this.Property(t => t.startDate).HasColumnName("startDate");
            this.Property(t => t.endDate).HasColumnName("endDate");
            this.Property(t => t.itemText).HasColumnName("itemText");
            this.Property(t => t.artID).HasColumnName("artID");

            // Relationships
            this.HasOptional(t => t.Artwork)
                .WithMany(t => t.Auctions)
                .HasForeignKey(d => d.artID);

        }
    }
}
