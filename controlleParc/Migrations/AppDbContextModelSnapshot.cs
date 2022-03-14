﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using controlleParc;

namespace controlleParc.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("controlleParc.Models.Conducteur", b =>
                {
                    b.Property<int>("ConducteurID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateNaissance")
                        .HasColumnType("datetime2");

                    b.Property<string>("MotDePasse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumPermis")
                        .HasColumnType("int");

                    b.Property<string>("Prenom")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ConducteurID");

                    b.ToTable("Conducteurs");
                });

            modelBuilder.Entity("controlleParc.Models.Entretien", b =>
                {
                    b.Property<int>("EntretienId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Frequence")
                        .HasColumnType("int");

                    b.Property<int>("Kilometrage")
                        .HasColumnType("int");

                    b.Property<int>("Montant")
                        .HasColumnType("int");

                    b.Property<string>("NomEntretien")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Periode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EntretienId");

                    b.ToTable("Entretiens");
                });

            modelBuilder.Entity("controlleParc.Models.EntretienVehicule", b =>
                {
                    b.Property<int>("EntretienVehiculeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateEntretien")
                        .HasColumnType("datetime2");

                    b.Property<int>("EntretienId")
                        .HasColumnType("int");

                    b.Property<int>("ImmatriculationId")
                        .HasColumnType("int");

                    b.Property<int>("KilometreVehicule")
                        .HasColumnType("int");

                    b.HasKey("EntretienVehiculeId");

                    b.HasIndex("EntretienId");

                    b.HasIndex("ImmatriculationId");

                    b.ToTable("EntretienVehicules");
                });

            modelBuilder.Entity("controlleParc.Models.Vehicule", b =>
                {
                    b.Property<int>("ImmatriculeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Carburant")
                        .HasColumnType("int");

                    b.Property<int?>("ConducteurID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateAchat")
                        .HasColumnType("datetime2");

                    b.Property<string>("Marque")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modele")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Puissance")
                        .HasColumnType("int");

                    b.HasKey("ImmatriculeId");

                    b.HasIndex("ConducteurID");

                    b.ToTable("Vehicules");
                });

            modelBuilder.Entity("controlleParc.Models.EntretienVehicule", b =>
                {
                    b.HasOne("controlleParc.Models.Entretien", "Entretien")
                        .WithMany()
                        .HasForeignKey("EntretienId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("controlleParc.Models.Vehicule", "Vehicule")
                        .WithMany()
                        .HasForeignKey("ImmatriculationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Entretien");

                    b.Navigation("Vehicule");
                });

            modelBuilder.Entity("controlleParc.Models.Vehicule", b =>
                {
                    b.HasOne("controlleParc.Models.Conducteur", "Conducteur")
                        .WithMany()
                        .HasForeignKey("ConducteurID");

                    b.Navigation("Conducteur");
                });
#pragma warning restore 612, 618
        }
    }
}
