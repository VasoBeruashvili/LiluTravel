using LiluTravel.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LiluTravel.DataLayer
{
    public class DataContext : DbContext
    {
        public DataContext() : base("LiluTravelConnection")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ValidateOnSaveEnabled = false;
            Configuration.AutoDetectChangesEnabled = false;
        }

        public DbSet<Tour> Tours { get; set; }
        public DbSet<SubTour> SubTours { get; set; }
        public DbSet<TourImage> TourImages { get; set; }
        public DbSet<SubTourImage> SubTourImages { get; set; }
    }
}