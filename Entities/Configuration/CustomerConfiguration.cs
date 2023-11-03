using Entities.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entities.Configuration
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasData
            (
            new Customer
            {
                Id = new Guid("d3f99b26-c7f7-44c8-a49c-ac2f32883d94"),
                Name = "Иван",
                Address = "Тюмень",
                Country = "Россия",
                PhoneNumber = "89873787778"
            },
            new Customer
            {
                Id = new Guid("bdf081e9-6798-44f2-bd9a-5e148dbf1814"),
                Name = "Аркалий",
                Address = "Минск",
                Country = "Беларусь",
                PhoneNumber = "89898898988"
            }
            ); ;
        }
    }
}
