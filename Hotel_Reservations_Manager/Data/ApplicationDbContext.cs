using System;
using Hotel_Reservations_Manager.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Hotel_Reservations_Manager.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<ClientReservation> ClientReservations { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Room> Rooms { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ClientReservation>()
                .HasKey(cr => new { cr.ClientId, cr.ReservationId });
            builder.Entity<ClientReservation>()
                .HasOne(cr => cr.Client)
                .WithMany(c => c.ClientReservations)
                .HasForeignKey(cr => cr.ClientId);
            builder.Entity<ClientReservation>()
                .HasOne(cr => cr.Reservation)
                .WithMany(r => r.ClientReservations)
                .HasForeignKey(cr => cr.ReservationId);
        }
    }
}

