using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Studio9Fitnes_Clud.Domain.Entities;

namespace Jasmin.Infrastructure.Ef.Configurations;

public class FitnesCategoryConfiguration:IEntityTypeConfiguration<FitnesCategory>
{
    public void Configure(EntityTypeBuilder<FitnesCategory> builder)
    {
        builder.ToTable("FitnesCategory");
    }

    
}