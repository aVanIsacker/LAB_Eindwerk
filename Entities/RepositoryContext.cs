﻿using Entities.Configuration;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options)
        { }

        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<Factuur> Factuur { get; set; }
        public virtual DbSet<FactuurType> FactuurType { get; set; }
        public virtual DbSet<KasVerrichting> KasVerrichting { get; set; }
        public virtual DbSet<Klant> Klant { get; set; }
        public virtual DbSet<Leverancier> Leverancier { get; set; }
        public virtual DbSet<TypeBetaling> TypeBetaling { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          

              modelBuilder.Entity<Contact>(entity =>
            {
                entity.HasKey(e => e.ContactNr);        //autogenerated


                //entity.Property(e => e.ContactNr).ValueGeneratedOnAdd();
                //entity.Property(e => e.ContactNr).ValueGeneratedOnAdd().UseIdentityColumn(1, 1);
                //entity.Property(e => e.ContactNr).ValueGeneratedOnAdd().UseIdentityColumn(-1, 1);
                //entity.Property(e => e.ContactNr).ValueGeneratedOnAdd().UseIdentityColumn(10, 1);
                //entity.Property(e => e.ContactNr).ValueGeneratedOnAdd().UseIdentityColumn(-10, 1);
                //entity.Property(e => e.ContactNr).ValueGeneratedOnAdd().UseIdentityColumn(-1, -1);
                //entity.Property(e => e.ContactNr).HasDefaultValue(1);


                entity.Property(e => e.Btwnr)
                    .HasColumnName("BTWnr")
                    .HasMaxLength(12)
                    .IsUnicode(false);           

                entity.Property(e => e.Straat)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Gemeente)
                   .IsRequired()
                   .HasMaxLength(50)
                   .IsUnicode(false);
                //geen probleem met postcode en geen FK's

            });
            
            modelBuilder.Entity<Factuur>(entity =>
            {
                entity.HasKey(e => e.FactuurNr);        //autogenerated

                //entity.Property(e => e.FactuurNr).ValueGeneratedNever();

                entity.Property(e => e.Bedrag).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Btwtarief).HasColumnType("decimal(18, 2)")
                                                  .HasColumnName("BTWTarief");   //naam enkel nodig als je het anders geschreven wilt

                entity.Property(e => e.FactuurDatum).HasColumnType("datetime");

                entity.Property(e => e.BetaalDatum).HasColumnType("datetime");

                entity.Property(e => e.Omschrijving)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.Contact)           //many facturen to 1 contact
                    .WithMany(p => p.Factuur)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Factuur_Contact");

                entity.HasOne(d => d.TypeNavigation)        //many facturen to 1 factuurtype
                    .WithMany(p => p.Factuur)
                    .HasForeignKey(d => d.Type)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Factuur_FactuurType");
            });
            
            
            modelBuilder.Entity<FactuurType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.FactuurType1)
                    .IsRequired()
                    .HasColumnName("FactuurType")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
            
            modelBuilder.Entity<KasVerrichting>(entity =>
            {
                entity.HasKey(e => e.KasNrId);          //autogenerated

                entity.Property(e => e.BedragExcl).HasColumnType("decimal(18, 2)");
               

                entity.Property(e => e.BtwTarief).HasColumnType("decimal(18, 2)")
                                                    .HasColumnName("BTWTarief");

                entity.HasOne(d => d.FactuurNrNavigation)       //komt van public virtual Factuur FactuurNrNavigation { get; set; } in models classe kasverrichting
                    .WithMany(p => p.KasVerrichting)
                    .HasForeignKey(d => d.FactuurNr)             //FK in tabel
                    .HasConstraintName("FK_KasVerrichting_Factuur");

                entity.HasOne(d => d.TypeBetalingNavigation)      //komt van public virtual TypeBetaling TypeBetalingNavigation { get; set; } in models classe kasverrichting
                    .WithMany(p => p.KasVerrichting)
                    .HasForeignKey(d => d.TypeBetaling)             //FK in tabel
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KasVerrichting_TypeBetaling");
            });

            modelBuilder.Entity<Klant>(entity =>
            {
                entity.HasKey(e => e.ContactNr);

                entity.Property(e => e.ContactNr).ValueGeneratedNever();        //deze zorgt ervoor dat het geen autoincrement is (want is al in contact)

                entity.Property(e => e.Familienaam)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Voornaam)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.ContactNrNavigation)               //komt van public virtual Contact ContactNrNavigation { get; set; } in models klasse klant
                    .WithOne(p => p.Klant)
                    .HasForeignKey<Klant>(d => d.ContactNr)             //FK maar 1 op 1
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Klant_Contact");
            });

            modelBuilder.Entity<Leverancier>(entity =>
            {
                entity.HasKey(e => e.ContactNr);

                entity.Property(e => e.ContactNr).ValueGeneratedNever();        //deze zorgt ervoor dat het geen autoincrement is (want is al in contact)

                entity.Property(e => e.NaamBedrijf)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.ContactNrNavigation)                   // komt van public virtual Contact ContactNrNavigation { get; set; } in models klasse leverancier
                    .WithOne(p => p.Leverancier)
                    .HasForeignKey<Leverancier>(d => d.ContactNr)           //FK maar 1 op 1
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Leverancier_Contact");
            });
            
            modelBuilder.Entity<TypeBetaling>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BetalingsType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });


            modelBuilder.ApplyConfiguration(new ContactConfiguration());
            modelBuilder.ApplyConfiguration(new FactuurConfiguration());
            modelBuilder.ApplyConfiguration(new FactuurTypeConfiguration());
            modelBuilder.ApplyConfiguration(new KasVerrichtingConfiguration());
            modelBuilder.ApplyConfiguration(new KlantConfiguration());
            modelBuilder.ApplyConfiguration(new LeverancierConfiguration());
            modelBuilder.ApplyConfiguration(new TypeBetalingConfiguration());

        }
    }
}

//now go to appsettings.json for connection string