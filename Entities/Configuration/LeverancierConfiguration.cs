﻿using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Configuration
{
    class LeverancierConfiguration : IEntityTypeConfiguration<Leverancier>
    {
        public void Configure(EntityTypeBuilder<Leverancier> builder)
        {
            builder.HasData(
                new Leverancier
                {
                    //ContactNr FK van autogenerated Contact
                    NaamBedrijf = "HR-Rail"
                },
                 new Leverancier
                 {
                     NaamBedrijf = "Proximus"
                 },

                  new Leverancier
                  {
                      NaamBedrijf = "KBC"
                  },

                  new Leverancier
                  {
                      NaamBedrijf = "Standaard Boekhandel"
                  }
                );           
        }
    }
}