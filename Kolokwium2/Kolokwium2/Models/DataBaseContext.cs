using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Kolokwium2.Models {

    public class DataBaseContext : DbContext{
        public DbSet<Artist> Artist { get; set; }
        public DbSet<Artist_Event> Artist_Event { get; set; }
        public DbSet<Event> Event { get; set; }
        public DbSet<Event_Organiser> Event_Organiser { get; set; }
        public DbSet<Organiser> Organiser { get; set; }

        public DataBaseContext() {
        }

        public DataBaseContext(DbContextOptions options) : base(options) {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Artist>()
                        .HasKey(e => e.IdArtist);
            modelBuilder.Entity<Artist>()
                        .Property(e => e.IdArtist)
                        .IsRequired();
            modelBuilder.Entity<Artist>()
                        .Property(e => e.Nickname)
                        .HasMaxLength(30)
                        .IsRequired();
            var artistList = new List<Artist>();
            artistList.Add(new Models.Artist { IdArtist = 1, Nickname = "Skala" });
            artistList.Add(new Models.Artist { IdArtist = 2, Nickname = "Orka" });
            artistList.Add(new Models.Artist { IdArtist = 3, Nickname = "Flet" });
            artistList.Add(new Models.Artist { IdArtist = 4, Nickname = "Brak" });
            artistList.Add(new Models.Artist { IdArtist = 5, Nickname = "Trabka" });
            modelBuilder.Entity<Artist>().HasData(artistList);



            modelBuilder.Entity<Artist_Event>()
                        .HasKey(e => e.IdEvent);
            modelBuilder.Entity<Artist_Event>()
                        .Property(e => e.IdEvent)
                        .ValueGeneratedNever()
                        .IsRequired();
            modelBuilder.Entity<Artist_Event>()
                        .HasKey(e => e.IdArtist);
            modelBuilder.Entity<Artist_Event>()
                        .Property(e => e.IdArtist)
                        .ValueGeneratedNever()
                        .IsRequired();
            modelBuilder.Entity<Artist_Event>()
                        .HasOne(z => z.ArtistNav)
                        .WithMany(z => z.Artist_Events)
                        .HasForeignKey(k => k.IdArtist).IsRequired();
            modelBuilder.Entity<Artist_Event>()
                        .HasOne(p => p.EventNav)
                        .WithMany(z => z.Artist_Events)
                        .HasForeignKey(p => p.IdEvent).IsRequired();
            modelBuilder.Entity<Artist_Event>()
                        .Property(e => e.PerformanceDate)
                        .IsRequired();
            var artist_eventList = new List<Artist_Event>();
            artist_eventList.Add(new Models.Artist_Event { IdEvent = 1, IdArtist = 1, PerformanceDate = System.DateTime.Now });
            artist_eventList.Add(new Models.Artist_Event { IdEvent = 2, IdArtist = 2, PerformanceDate = System.DateTime.Now });
            artist_eventList.Add(new Models.Artist_Event { IdEvent = 3, IdArtist = 3, PerformanceDate = System.DateTime.Now });
            artist_eventList.Add(new Models.Artist_Event { IdEvent = 4, IdArtist = 4, PerformanceDate = System.DateTime.Now });
            artist_eventList.Add(new Models.Artist_Event { IdEvent = 5, IdArtist = 5, PerformanceDate = System.DateTime.Now });
            modelBuilder.Entity<Artist_Event>().HasData(artist_eventList);



            modelBuilder.Entity<Event>()
                        .HasKey(e => e.IdEvent);
            modelBuilder.Entity<Event>()
                        .Property(e => e.IdEvent)
                        .IsRequired();
            modelBuilder.Entity<Event>()
                        .Property(e => e.Name)
                        .HasMaxLength(100)
                        .IsRequired();
            modelBuilder.Entity<Event>()
                        .Property(e => e.StartDate)
                        .IsRequired();
            modelBuilder.Entity<Event>()
                        .Property(e => e.EndDate)
                        .IsRequired();
            var eventList = new List<Event>();
            eventList.Add(new Models.Event { IdEvent = 1, Name = "Juwenalia", StartDate = System.DateTime.Now, EndDate = System.DateTime.Now });
            eventList.Add(new Models.Event { IdEvent = 2, Name = "Dni robotyka", StartDate = System.DateTime.Now, EndDate = System.DateTime.Now });
            eventList.Add(new Models.Event { IdEvent = 3, Name = "Dni Warszawy", StartDate = System.DateTime.Now, EndDate = System.DateTime.Now });
            eventList.Add(new Models.Event { IdEvent = 4, Name = "Dni Lublina", StartDate = System.DateTime.Now, EndDate = System.DateTime.Now });
            eventList.Add(new Models.Event { IdEvent = 5, Name = "Dni Wolowa", StartDate = System.DateTime.Now, EndDate = System.DateTime.Now });
            modelBuilder.Entity<Event>().HasData(eventList);



            modelBuilder.Entity<Organiser>()
                        .HasKey(e => e.IdOrganiser);
            modelBuilder.Entity<Organiser>()
                        .Property(e => e.IdOrganiser)
                        .IsRequired();
            modelBuilder.Entity<Organiser>()
                        .Property(e => e.Name)
                        .HasMaxLength(30)
                        .IsRequired();
            var organiserList = new List<Organiser>();
            organiserList.Add(new Models.Organiser { IdOrganiser = 1, Name = "Urzad miasta" });
            organiserList.Add(new Models.Organiser { IdOrganiser = 2, Name = "Gmina" });
            organiserList.Add(new Models.Organiser { IdOrganiser = 3, Name = "Urzad miasta" });
            organiserList.Add(new Models.Organiser { IdOrganiser = 4, Name = "Urzad miasta" });
            organiserList.Add(new Models.Organiser { IdOrganiser = 5, Name = "Gmina" });
            modelBuilder.Entity<Organiser>().HasData(organiserList);




            modelBuilder.Entity<Event_Organiser>()
                        .HasKey(e => e.IdEvent);
            modelBuilder.Entity<Event_Organiser>()
                        .Property(e => e.IdEvent)
                        .ValueGeneratedNever()
                        .IsRequired();
            modelBuilder.Entity<Event_Organiser>()
                        .HasKey(e => e.IdOrganiser);
            modelBuilder.Entity<Event_Organiser>()
                        .Property(e => e.IdOrganiser)
                        .ValueGeneratedNever()
                        .IsRequired();
            modelBuilder.Entity<Event_Organiser>()
                        .HasOne(z => z.OrganiserNav)
                        .WithMany(z => z.Event_Organisers)
                        .HasForeignKey(k => k.IdOrganiser).IsRequired();
            modelBuilder.Entity<Event_Organiser>()
                        .HasOne(p => p.EventNav)
                        .WithMany(z => z.Event_Organisers)
                        .HasForeignKey(p => p.IdEvent).IsRequired();
            var event_organiser_List = new List<Event_Organiser>();
            event_organiser_List.Add(new Models.Event_Organiser { IdEvent = 1, IdOrganiser = 1 });
            event_organiser_List.Add(new Models.Event_Organiser { IdEvent = 2, IdOrganiser = 2 });
            event_organiser_List.Add(new Models.Event_Organiser { IdEvent = 3, IdOrganiser = 3 });
            event_organiser_List.Add(new Models.Event_Organiser { IdEvent = 4, IdOrganiser = 4 });
            event_organiser_List.Add(new Models.Event_Organiser { IdEvent = 5, IdOrganiser = 5 });
            modelBuilder.Entity<Event_Organiser>().HasData(event_organiser_List);
        }
    }
}
