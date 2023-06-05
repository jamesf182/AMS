using AMS.Domain.Entities.PointsEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AMS.Infra.Data.EntitiesConfiguration
{
    public class PointsConfiguration : IEntityTypeConfiguration<Points>
    {
        public void Configure(EntityTypeBuilder<Points> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).HasConversion(
                points => points.Value,
                value => new PointsId(value));


        }
    }
}
