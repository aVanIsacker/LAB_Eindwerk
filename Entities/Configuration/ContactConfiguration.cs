﻿using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Configuration
{
    public class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.HasData(
          //klant
                new Contact
                {
                    ContactNr = 1,//ContactNr autogenerated PK       //maria de smet
                    Btwnr = "",
                    Straat = "Nijvelsesteenweg 346",
                    Postcode = 1500,
                    Gemeente = "Halle"
                },

                new Contact
                {
                    ContactNr = 2,//ContactNr autogenerated        //arthur peeters
                    Btwnr = "0123456472",
                    Straat = "Biesputstraat 24",
                    Postcode = 1040,
                    Gemeente = "Etterbeek"
                },

                new Contact
                {
                    ContactNr = 3,//ContactNr autogenerated        //lucas goossens
                    Btwnr = "1234564890",
                    Straat = "Prins Boudewijnlaan 95",
                    Postcode = 2550,
                    Gemeente = "Kontich"
                },

                new Contact
                {
                    ContactNr = 4, //ContactNr autogenerated       //Elena Mertens
                    Btwnr = "",
                    Straat = "Roeselaarsestraat 282",
                    Postcode = 8870,
                    Gemeente = "Izegem"
                },

      //leverancier
                new Contact
                {
                    ContactNr = 5,//ContactNr autogenerated            //hr rail
                    Btwnr = "00014578441",
                    Straat = "Frankrijkstraat 85",
                    Postcode = 1060,
                    Gemeente = "Brussel"
                },

                new Contact
                {
                    ContactNr = 6,//ContactNr autogenerated            //proximus
                    Btwnr = "0008965321",
                    Straat = "Koning Albert II-laan 27.B",
                    Postcode = 1030,
                    Gemeente = "Brussel"
                },

                new Contact
                {
                    ContactNr = 7,//ContactNr autogenerated            //kbc
                    Btwnr = "00077638903",
                    Straat = "Ter Reigerie 1",
                    Postcode = 8800,
                    Gemeente = "Roeselare"
                    },

                new Contact
                {
                    ContactNr = 8,//ContactNr autogenerated         //standaard boekhandel
                    Btwnr = "0008965321",
                    Straat = "Industriepark-Noord 28.A 2",
                    Postcode = 9100,
                    Gemeente = "Sint-Niklaas"
                }
                );
        }
    }
}
