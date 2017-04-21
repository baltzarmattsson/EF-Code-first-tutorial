﻿using System.Data.Entity;
using Model;

namespace DataLayerForFluent
{
    public class BreakAwayContext : DbContext
    {
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Lodging> Lodgings { get; set; }
    }
}
