﻿// <auto-generated />
using System;
using Kolokwium2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Kolokwium2.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    partial class DataBaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Kolokwium2.Models.Artist", b =>
                {
                    b.Property<int>("IdArtist")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nickname")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("IdArtist");

                    b.ToTable("Artist");

                    b.HasData(
                        new
                        {
                            IdArtist = 1,
                            Nickname = "Skala"
                        },
                        new
                        {
                            IdArtist = 2,
                            Nickname = "Orka"
                        },
                        new
                        {
                            IdArtist = 3,
                            Nickname = "Flet"
                        },
                        new
                        {
                            IdArtist = 4,
                            Nickname = "Brak"
                        },
                        new
                        {
                            IdArtist = 5,
                            Nickname = "Trabka"
                        });
                });

            modelBuilder.Entity("Kolokwium2.Models.Artist_Event", b =>
                {
                    b.Property<int>("IdArtist")
                        .HasColumnType("int");

                    b.Property<int>("IdEvent")
                        .HasColumnType("int");

                    b.Property<DateTime>("PerformanceDate")
                        .HasColumnType("datetime2");

                    b.HasKey("IdArtist");

                    b.HasIndex("IdEvent");

                    b.ToTable("Artist_Event");

                    b.HasData(
                        new
                        {
                            IdArtist = 1,
                            IdEvent = 1,
                            PerformanceDate = new DateTime(2020, 6, 19, 13, 55, 51, 357, DateTimeKind.Local).AddTicks(6060)
                        },
                        new
                        {
                            IdArtist = 2,
                            IdEvent = 2,
                            PerformanceDate = new DateTime(2020, 6, 19, 13, 55, 51, 361, DateTimeKind.Local).AddTicks(1660)
                        },
                        new
                        {
                            IdArtist = 3,
                            IdEvent = 3,
                            PerformanceDate = new DateTime(2020, 6, 19, 13, 55, 51, 361, DateTimeKind.Local).AddTicks(1720)
                        },
                        new
                        {
                            IdArtist = 4,
                            IdEvent = 4,
                            PerformanceDate = new DateTime(2020, 6, 19, 13, 55, 51, 361, DateTimeKind.Local).AddTicks(1720)
                        },
                        new
                        {
                            IdArtist = 5,
                            IdEvent = 5,
                            PerformanceDate = new DateTime(2020, 6, 19, 13, 55, 51, 361, DateTimeKind.Local).AddTicks(1730)
                        });
                });

            modelBuilder.Entity("Kolokwium2.Models.Event", b =>
                {
                    b.Property<int>("IdEvent")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("IdEvent");

                    b.ToTable("Event");

                    b.HasData(
                        new
                        {
                            IdEvent = 1,
                            EndDate = new DateTime(2020, 6, 19, 13, 55, 51, 364, DateTimeKind.Local).AddTicks(8030),
                            Name = "Juwenalia",
                            StartDate = new DateTime(2020, 6, 19, 13, 55, 51, 364, DateTimeKind.Local).AddTicks(7470)
                        },
                        new
                        {
                            IdEvent = 2,
                            EndDate = new DateTime(2020, 6, 19, 13, 55, 51, 364, DateTimeKind.Local).AddTicks(8600),
                            Name = "Dni robotyka",
                            StartDate = new DateTime(2020, 6, 19, 13, 55, 51, 364, DateTimeKind.Local).AddTicks(8580)
                        },
                        new
                        {
                            IdEvent = 3,
                            EndDate = new DateTime(2020, 6, 19, 13, 55, 51, 364, DateTimeKind.Local).AddTicks(8620),
                            Name = "Dni Warszawy",
                            StartDate = new DateTime(2020, 6, 19, 13, 55, 51, 364, DateTimeKind.Local).AddTicks(8620)
                        },
                        new
                        {
                            IdEvent = 4,
                            EndDate = new DateTime(2020, 6, 19, 13, 55, 51, 364, DateTimeKind.Local).AddTicks(8630),
                            Name = "Dni Lublina",
                            StartDate = new DateTime(2020, 6, 19, 13, 55, 51, 364, DateTimeKind.Local).AddTicks(8620)
                        },
                        new
                        {
                            IdEvent = 5,
                            EndDate = new DateTime(2020, 6, 19, 13, 55, 51, 364, DateTimeKind.Local).AddTicks(8630),
                            Name = "Dni Wolowa",
                            StartDate = new DateTime(2020, 6, 19, 13, 55, 51, 364, DateTimeKind.Local).AddTicks(8630)
                        });
                });

            modelBuilder.Entity("Kolokwium2.Models.Event_Organiser", b =>
                {
                    b.Property<int>("IdOrganiser")
                        .HasColumnType("int");

                    b.Property<int>("IdEvent")
                        .HasColumnType("int");

                    b.HasKey("IdOrganiser");

                    b.HasIndex("IdEvent");

                    b.ToTable("Event_Organiser");

                    b.HasData(
                        new
                        {
                            IdOrganiser = 1,
                            IdEvent = 1
                        },
                        new
                        {
                            IdOrganiser = 2,
                            IdEvent = 2
                        },
                        new
                        {
                            IdOrganiser = 3,
                            IdEvent = 3
                        },
                        new
                        {
                            IdOrganiser = 4,
                            IdEvent = 4
                        },
                        new
                        {
                            IdOrganiser = 5,
                            IdEvent = 5
                        });
                });

            modelBuilder.Entity("Kolokwium2.Models.Organiser", b =>
                {
                    b.Property<int>("IdOrganiser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("IdOrganiser");

                    b.ToTable("Organiser");

                    b.HasData(
                        new
                        {
                            IdOrganiser = 1,
                            Name = "Urzad miasta"
                        },
                        new
                        {
                            IdOrganiser = 2,
                            Name = "Gmina"
                        },
                        new
                        {
                            IdOrganiser = 3,
                            Name = "Urzad miasta"
                        },
                        new
                        {
                            IdOrganiser = 4,
                            Name = "Urzad miasta"
                        },
                        new
                        {
                            IdOrganiser = 5,
                            Name = "Gmina"
                        });
                });

            modelBuilder.Entity("Kolokwium2.Models.Artist_Event", b =>
                {
                    b.HasOne("Kolokwium2.Models.Artist", "ArtistNav")
                        .WithMany("Artist_Events")
                        .HasForeignKey("IdArtist")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Kolokwium2.Models.Event", "EventNav")
                        .WithMany("Artist_Events")
                        .HasForeignKey("IdEvent")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Kolokwium2.Models.Event_Organiser", b =>
                {
                    b.HasOne("Kolokwium2.Models.Event", "EventNav")
                        .WithMany("Event_Organisers")
                        .HasForeignKey("IdEvent")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Kolokwium2.Models.Organiser", "OrganiserNav")
                        .WithMany("Event_Organisers")
                        .HasForeignKey("IdOrganiser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
