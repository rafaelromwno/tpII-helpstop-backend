using HelpApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpApp.Infra.Data.EntitiesConfiguration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(p => p.Name).HasMaxLength(100).IsRequired();
            builder.Property(p => p.Description).HasMaxLength(200).IsRequired();

            builder.Property(p => p.Price).HasPrecision(10, 2);

            builder.HasOne( e => e.Category).WithMany( e => e.Products)
                .HasForeignKey( e => e.CategoryId );

            builder.HasData(
                new Product(1, "Mouse Gamer", "Mouse óptico com iluminação RGB", 89.90m, 50, "mouse.jpg") { CategoryId = 1 },
                new Product(2, "Caixa de Som Bluetooth", "Caixa de som portátil com bateria recarregável", 199.90m, 40, "caixa_som.jpg") { CategoryId = 2 },
                new Product(3, "Caneca Personalizada", "Caneca de cerâmica com estampa personalizada", 29.90m, 150, "caneca.jpg") { CategoryId = 3 }
            );
        }
    }
}
