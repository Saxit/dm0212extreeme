using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ModelXP.Models.Mapping
{
    public class ArtworkMap : EntityTypeConfiguration<Artwork>
    {
        public ArtworkMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.artName)
                .HasMaxLength(255);

            this.Property(t => t.location)
                .HasMaxLength(255);

            this.Property(t => t.imagePath)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("Artwork");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.artName).HasColumnName("artName");
            this.Property(t => t.yearCreated).HasColumnName("yearCreated");
            this.Property(t => t.height).HasColumnName("height");
            this.Property(t => t.width).HasColumnName("width");
            this.Property(t => t.location).HasColumnName("location");
            this.Property(t => t.imagePath).HasColumnName("imagePath");
        }
    }
}
