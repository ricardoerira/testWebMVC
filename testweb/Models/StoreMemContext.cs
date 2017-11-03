using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace testweb.Models
{
    public class StoreMemContext : DbContext
    {

        public StoreMemContext(DbContextOptions<StoreMemContext> options)
            : base(options)
        {
            // TODO: #639
            //ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }
        public DbSet<Category> categories { get; set; }
        public DbSet<Product> products { get; set; }
    
    }
}
