﻿using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Configuration
{
    class KlantConfiguration : IEntityTypeConfiguration<Klant>
    {
        public void Configure(EntityTypeBuilder<Klant> builder)
        {
            builder.HasData(
                new Klant
                {
                    //ContactNr FK van autogenerated Contact
                    Voornaam = "Maria",
                    Familienaam = "De Smet"
                },

                 new Klant
                {
                    Voornaam = "Arthur",
                    Familienaam = "Peeters"
                },

                 new Klant
                {
                    Voornaam = "Lucas",
                    Familienaam = "Goossens"
                },

                 new Klant
                 {
                    Voornaam = "Elena",
                    Familienaam = "Mertens"
                }
                );       
        }
    }
}
