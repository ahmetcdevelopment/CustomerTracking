using CustomerTracking.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerTracking.Data.Concrete.EntityFramework.Mappings
{
    public class PlateMap : IEntityTypeConfiguration<Plate>
    {
        public void Configure(EntityTypeBuilder<Plate> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p=>p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.PlateCode).IsRequired();
            builder.Property(p => p.PlateCode).HasMaxLength(8);
            builder.Property(p=>p.BrandName).IsRequired();
            builder.Property(p => p.BrandName).HasMaxLength(25);
            builder.Property(p=>p.Color).HasMaxLength(15);

            //EntityBase Properties Mapping

            builder.Property(c => c.CreatedByName).IsRequired();
            builder.Property(c => c.CreatedByName).HasMaxLength(50);
            builder.Property(c => c.ModifiedByName).IsRequired();
            builder.Property(c => c.ModifiedByName).HasMaxLength(50);
            builder.Property(c => c.CreatedDate).IsRequired();
            builder.Property(c => c.ModifiedDate).IsRequired();
            builder.Property(c => c.IsActive).IsRequired();
            builder.Property(c => c.IsDeleted).IsRequired();
            builder.Property(c => c.Note).HasMaxLength(500);
            builder.HasOne<Customer>().WithOne().HasForeignKey(c=>c.PlateId).IsRequired();//bire bir ilişki kurulacak
            builder.ToTable("Plates");
            builder.HasData(new Plate
            {
                Id = 1,
                PlateCode = "42dsy81",
                BrandName = "Honda Civic",
                Color = "Beyaz",
                CreatedByName = "InitialCreate",
                CreatedDate = DateTime.Now,
                ModifiedByName = "InitialCreate",
                ModifiedDate = DateTime.Now,
                IsActive = true,
                IsDeleted = false,
                Note = "Ömer Çiftçi'ye ait araç."
            });
        }
    }
}
