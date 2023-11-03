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
    public class SellerConfiguration : IEntityTypeConfiguration<Seller>
    {
        public void Configure(EntityTypeBuilder<Seller> builder)
        {
            builder.HasData
            (
            new Seller
            {
                Id = new Guid("284aa8c3-ebd0-40c3-b6d6-cb60072e7b66"),
                Name = "Руслан",
                Address = "Саранск, Ленина, 9",
                PhoneNumber = "91829819289",
                Number = "1"
            },
            new Seller
            {
                Id = new Guid("117d9794-e69c-4366-af14-7899cd34e349"),
                Name = "Алексей",
                Address = "Саранск, Ленина, 8 ",
                PhoneNumber = "8291892189",
                Number = "2"
            }
            );
        }
    }
}
