using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Configuration
{
    class FactuurTypeConfiguration : IEntityTypeConfiguration<FactuurType>
    {
        public void Configure(EntityTypeBuilder<FactuurType> builder)
        {
            builder.HasData(
                new FactuurType
                {                
                    Id = 1,
                    FactuurType1 = "Verkoop"
                },
                new FactuurType
                {
                    Id = 2,
                    FactuurType1 = "Aankoop"
                }

                );
        }
    }
}
