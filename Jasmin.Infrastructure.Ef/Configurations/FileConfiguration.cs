using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using File = Studio9Fitnes_Clud.Domain.Entities.File;

namespace Jasmin.Infrastructure.Ef.Configurations;

public class FileConfiguration:IEntityTypeConfiguration<File>
{
    public void Configure(EntityTypeBuilder<File> builder)
    {
        builder.ToTable("File");
    }
}