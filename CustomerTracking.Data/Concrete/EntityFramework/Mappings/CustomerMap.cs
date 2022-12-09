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
    public class CustomerMap : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c=>c.Id).ValueGeneratedOnAdd();
            builder.Property(c=>c.Name).IsRequired();
            builder.Property(c => c.Name).HasMaxLength(50);
            builder.Property(c=>c.LastName).IsRequired();
            builder.Property(c=>c.LastName).HasMaxLength(50);
            builder.Property(c=>c.PhoneNumber).HasMaxLength(13);

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
            builder.ToTable("Customers");
            builder.HasData(new Customer
            {
                Id= 1,
                Name="Ahmet",
                LastName="Çiftçi",
                PhoneNumber="905380860645",
                IsActive=true,
                IsDeleted=false,
                CreatedByName="InitialCreate",
                CreatedDate=DateTime.Now,
                ModifiedByName="InitialCreate",
                ModifiedDate=DateTime.Now,
                Note="Yeğenim"
            });
        }
    }
}
