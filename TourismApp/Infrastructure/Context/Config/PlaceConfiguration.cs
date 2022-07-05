using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Context.Config
{
    public class PlaceConfiguration : IEntityTypeConfiguration<Place>
    {

        public void Configure(EntityTypeBuilder<Place> builder)
        {
            builder.Property(place => place.Name).HasMaxLength(50);
            builder.Property(place => place.Description).IsRequired();
            builder.Property(place => place.EstimatedCosts).IsRequired();

            /*RelationShips*/
            builder.HasOne(category => category.Category).WithMany()
                .HasForeignKey(place => place.CategoryId);

            builder.HasOne(country => country.Country).WithMany()
                .HasForeignKey(place => place.CountryId);
        }
    }
}