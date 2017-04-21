﻿using System.Data.Entity;
using Model;

namespace DataLayerForFluent
{
    public class BreakAwayContext : DbContext
    {
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Lodging> Lodgings { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Destination>()
                .Property(d => d.Name).IsRequired();
            modelBuilder.Entity<Destination>()
                .Property(d => d.Description).HasMaxLength(500);
            modelBuilder.Entity<Destination>()
                .Property(d => d.Photo).HasColumnType("image");

            modelBuilder.Entity<Lodging>()
                .Property(l => l.Name).IsRequired().HasMaxLength(200);
        }
    }

}
