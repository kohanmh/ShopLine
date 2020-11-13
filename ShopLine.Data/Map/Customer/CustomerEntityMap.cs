using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopLine.Domain.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ShopLine.Data.Map.Customer
{
    public class CustomerEntityMap : IEntityTypeConfiguration<CustomerEntity>
    {
        public void Configure(EntityTypeBuilder<CustomerEntity> builder)
        {
            builder.hasde
            builder.Property("CST1_Customer", "CST");
            // Primary Key
            builder.HasKey(t => t.ID);
            builder.Property(t => t.ID).ValueGeneratedOnAdd();
            // Table & Column Mappings
            builder.Property(t => t.ID).HasField("CST1_Customer_ID");
            builder.Property(t => t.FirstName).HasField("CST1_Customer_FirstName");
            builder.Property(t => t.LastName).HasField("CST1_Customer_LastName");
            builder.Property(t => t.Age).HasField("CST1_Customer_Age");
            builder.Property(t => t.BirthDay).HasField("CST1_Customer_BirthDay");
        }
    }
}
