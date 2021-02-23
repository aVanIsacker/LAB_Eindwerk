﻿// <auto-generated />
using System;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Web_API.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    partial class RepositoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.Models.Contact", b =>
                {
                    b.Property<int>("ContactNr")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Btwnr")
                        .HasColumnName("BTWnr")
                        .HasColumnType("varchar(12)")
                        .HasMaxLength(12)
                        .IsUnicode(false);

                    b.Property<string>("Gemeente")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<int>("Postcode")
                        .HasColumnType("int");

                    b.Property<string>("Straat")
                        .IsRequired()
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.HasKey("ContactNr");

                    b.ToTable("Contact");

                    b.HasData(
                        new
                        {
                            ContactNr = 1,
                            Btwnr = "",
                            Gemeente = "Halle",
                            Postcode = 1500,
                            Straat = "Nijvelsesteenweg 346"
                        },
                        new
                        {
                            ContactNr = 2,
                            Btwnr = "0123456472",
                            Gemeente = "Etterbeek",
                            Postcode = 1040,
                            Straat = "Biesputstraat 24"
                        },
                        new
                        {
                            ContactNr = 3,
                            Btwnr = "1234564890",
                            Gemeente = "Kontich",
                            Postcode = 2550,
                            Straat = "Prins Boudewijnlaan 95"
                        },
                        new
                        {
                            ContactNr = 4,
                            Btwnr = "",
                            Gemeente = "Izegem",
                            Postcode = 8870,
                            Straat = "Roeselaarsestraat 282"
                        },
                        new
                        {
                            ContactNr = 5,
                            Btwnr = "00014578441",
                            Gemeente = "Brussel",
                            Postcode = 1060,
                            Straat = "Frankrijkstraat 85"
                        },
                        new
                        {
                            ContactNr = 6,
                            Btwnr = "0008965321",
                            Gemeente = "Brussel",
                            Postcode = 1030,
                            Straat = "Koning Albert II-laan 27.B"
                        },
                        new
                        {
                            ContactNr = 7,
                            Btwnr = "00077638903",
                            Gemeente = "Roeselare",
                            Postcode = 8800,
                            Straat = "Ter Reigerie 1"
                        },
                        new
                        {
                            ContactNr = 8,
                            Btwnr = "0008965321",
                            Gemeente = "Sint-Niklaas",
                            Postcode = 9100,
                            Straat = "Industriepark-Noord 28.A 2"
                        });
                });

            modelBuilder.Entity("Entities.Models.Factuur", b =>
                {
                    b.Property<int>("FactuurNr")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal?>("Bedrag")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<DateTime?>("BetaalDatum")
                        .HasColumnType("datetime");

                    b.Property<decimal?>("Btwtarief")
                        .HasColumnName("BTWTarief")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("ContactId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FactuurDatum")
                        .HasColumnType("datetime");

                    b.Property<string>("Omschrijving")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("FactuurNr");

                    b.HasIndex("ContactId");

                    b.HasIndex("Type");

                    b.ToTable("Factuur");

                    b.HasData(
                        new
                        {
                            FactuurNr = 1,
                            Bedrag = 260m,
                            Btwtarief = 6m,
                            ContactId = 1,
                            FactuurDatum = new DateTime(2020, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Omschrijving = "Tafel",
                            Status = "Open",
                            Type = 1
                        },
                        new
                        {
                            FactuurNr = 2,
                            Bedrag = 450m,
                            BetaalDatum = new DateTime(2020, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Btwtarief = 21m,
                            ContactId = 3,
                            FactuurDatum = new DateTime(2020, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Omschrijving = "Herstoffering",
                            Status = "Betaald",
                            Type = 1
                        },
                        new
                        {
                            FactuurNr = 3,
                            Bedrag = 120m,
                            BetaalDatum = new DateTime(2020, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Btwtarief = 6m,
                            ContactId = 5,
                            FactuurDatum = new DateTime(2020, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Omschrijving = "Kast",
                            Status = "Betaald",
                            Type = 2
                        },
                        new
                        {
                            FactuurNr = 4,
                            Bedrag = 600m,
                            Btwtarief = 6m,
                            ContactId = 6,
                            FactuurDatum = new DateTime(2020, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Omschrijving = "Telecom installatie",
                            Status = "Open",
                            Type = 2
                        });
                });

            modelBuilder.Entity("Entities.Models.FactuurType", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("FactuurTypeNaam")
                        .IsRequired()
                        .HasColumnName("FactuurTypeName")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("FactuurType");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FactuurTypeNaam = "Verkoop"
                        },
                        new
                        {
                            Id = 2,
                            FactuurTypeNaam = "Aankoop"
                        });
                });

            modelBuilder.Entity("Entities.Models.KasVerrichting", b =>
                {
                    b.Property<int>("KasNr")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("BedragExcl")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("BtwTarief")
                        .HasColumnName("BTWTarief")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int?>("FactuurNr")
                        .HasColumnType("int");

                    b.Property<int>("TypeBetalingId")
                        .HasColumnType("int");

                    b.HasKey("KasNr");

                    b.HasIndex("FactuurNr");

                    b.HasIndex("TypeBetalingId");

                    b.ToTable("KasVerrichting");

                    b.HasData(
                        new
                        {
                            KasNr = 1,
                            BedragExcl = 450m,
                            BtwTarief = 21m,
                            FactuurNr = 2,
                            TypeBetalingId = 1
                        },
                        new
                        {
                            KasNr = 2,
                            BedragExcl = 120m,
                            BtwTarief = 6m,
                            FactuurNr = 3,
                            TypeBetalingId = 2
                        });
                });

            modelBuilder.Entity("Entities.Models.Klant", b =>
                {
                    b.Property<int>("KlantNr")
                        .HasColumnType("int");

                    b.Property<string>("Familienaam")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Voornaam")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("KlantNr");

                    b.ToTable("Klant");

                    b.HasData(
                        new
                        {
                            KlantNr = 1,
                            Familienaam = "De Smet",
                            Voornaam = "Maria"
                        },
                        new
                        {
                            KlantNr = 2,
                            Familienaam = "Peeters",
                            Voornaam = "Arthur"
                        },
                        new
                        {
                            KlantNr = 3,
                            Familienaam = "Goossens",
                            Voornaam = "Lucas"
                        },
                        new
                        {
                            KlantNr = 4,
                            Familienaam = "Mertens",
                            Voornaam = "Elena"
                        });
                });

            modelBuilder.Entity("Entities.Models.Leverancier", b =>
                {
                    b.Property<int>("LeverancierNr")
                        .HasColumnType("int");

                    b.Property<string>("NaamBedrijf")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("LeverancierNr");

                    b.ToTable("Leverancier");

                    b.HasData(
                        new
                        {
                            LeverancierNr = 1,
                            NaamBedrijf = "HR-Rail"
                        },
                        new
                        {
                            LeverancierNr = 2,
                            NaamBedrijf = "Proximus"
                        },
                        new
                        {
                            LeverancierNr = 3,
                            NaamBedrijf = "KBC"
                        },
                        new
                        {
                            LeverancierNr = 4,
                            NaamBedrijf = "Standaard Boekhandel"
                        });
                });

            modelBuilder.Entity("Entities.Models.TypeBetaling", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("BetalingsType")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("TypeBetaling");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BetalingsType = "Contant"
                        },
                        new
                        {
                            Id = 2,
                            BetalingsType = "Bancontact"
                        },
                        new
                        {
                            Id = 3,
                            BetalingsType = "Overschrijving"
                        });
                });

            modelBuilder.Entity("Entities.Models.Factuur", b =>
                {
                    b.HasOne("Entities.Models.Contact", "Contact")
                        .WithMany("Factuur")
                        .HasForeignKey("ContactId")
                        .IsRequired();

                    b.HasOne("Entities.Models.FactuurType", "TypeFactuur")
                        .WithMany("Factuur")
                        .HasForeignKey("Type")
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Models.KasVerrichting", b =>
                {
                    b.HasOne("Entities.Models.Factuur", "Factuur")
                        .WithMany("KasVerrichting")
                        .HasForeignKey("FactuurNr");

                    b.HasOne("Entities.Models.TypeBetaling", "TypeBetaling")
                        .WithMany("KasVerrichting")
                        .HasForeignKey("TypeBetalingId")
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Models.Klant", b =>
                {
                    b.HasOne("Entities.Models.Contact", "Contact")
                        .WithOne("Klant")
                        .HasForeignKey("Entities.Models.Klant", "KlantNr")
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Models.Leverancier", b =>
                {
                    b.HasOne("Entities.Models.Contact", "Contact")
                        .WithOne("Leverancier")
                        .HasForeignKey("Entities.Models.Leverancier", "LeverancierNr")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
