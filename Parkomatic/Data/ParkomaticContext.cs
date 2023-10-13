using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Parkomatic.Models;

namespace Parkomatic.Data
{
    public class ParkomaticContext : DbContext
    {
        public ParkomaticContext (DbContextOptions<ParkomaticContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Vehicle> Vehicles { get; set; }

        public virtual DbSet<Pass> Passes { get; set; }

        public virtual DbSet<ParkingSpot> ParkingSpots { get; set; }

        public virtual DbSet<Reservation> Reservations { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Reservation>()
                .HasOne(r => r.ParkingSpot)
                .WithMany(ps => ps.Reservations)
                .HasForeignKey(r => r.ParkingSpotID);

            modelBuilder.Entity<Reservation>()
                .HasOne(r => r.Vehicle)
                .WithMany(v => v.Reservations)
                .HasForeignKey(r => r.VehicleID);

            modelBuilder.Entity<Vehicle>()
                .HasOne(v => v.Pass)
                .WithMany(p => p.Vehicles)
                .HasForeignKey(v => v.PassID);
        }
    }
}
