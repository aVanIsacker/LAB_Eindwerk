using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Configuration
{
    class TypeBetalingConfiguration : IEntityTypeConfiguration<TypeBetaling>
    {
        public void Configure(EntityTypeBuilder<TypeBetaling> builder)
        {
            builder.HasData(
                new TypeBetaling
                {
                    Id = 1,
                    BetalingsType = "Contant"
                },

                new TypeBetaling
                {
                    Id = 2,
                    BetalingsType = "Bancontact"
                },

                new TypeBetaling
                {
                    Id = 3,
                    BetalingsType = "Overschrijving"
                }
                );
        }
    }
}
