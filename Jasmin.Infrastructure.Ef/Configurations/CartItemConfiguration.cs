using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Studio9Fitnes_Clud.Domain.Entities;

namespace Jasmin.Infrastructure.Ef.Configurations;

public class CartItemConfiguration:IEntityTypeConfiguration<CartItem>
{
  


    public void Configure(EntityTypeBuilder<CartItem> builder)
    {
        builder.ToTable("CartItem");
    }
}