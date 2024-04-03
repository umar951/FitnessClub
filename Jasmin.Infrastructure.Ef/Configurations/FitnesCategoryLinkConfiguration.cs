using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Studio9Fitnes_Clud.Domain.Entities;

namespace Jasmin.Infrastructure.Ef.Configurations;

public class FitnesCategoryLinkConfiguration:IEntityTypeConfiguration<FitnesCategoryLink>
{
    public void Configure(EntityTypeBuilder<FitnesCategoryLink> builder)
    {
        builder.ToTable("FitnesCategoryLink");
    }

    
}