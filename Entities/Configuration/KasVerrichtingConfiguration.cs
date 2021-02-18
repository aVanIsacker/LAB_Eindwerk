﻿using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Configuration
{
    class KasVerrichtingConfiguration : IEntityTypeConfiguration<KasVerrichting>
    {
        public void Configure(EntityTypeBuilder<KasVerrichting> builder)
        {
            builder.HasData(
                new KasVerrichting
                {
                    //KasNrId = autogenerated PK
                    FactuurNr =  2,               //FK van factuur
                    TypeBetaling = 1,
                    BedragExcl = 450,
                    BtwTarief = 21
                },

                new KasVerrichting
                {
                    //KasNrId = autogenerated PK
                    FactuurNr = 3,               //FK van factuur
                    TypeBetaling = 2,
                    BedragExcl = 120,
                    BtwTarief = 6
                }
                );
        }
    }
}
