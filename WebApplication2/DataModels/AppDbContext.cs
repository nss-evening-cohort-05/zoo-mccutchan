using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ZooMccutchan.Web.DataModels
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("ZooMccutchan")
        {}
        public DbSet<ZooKeeper> ZooKeepers { get; set; }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Enclosure> Enclosures { get; set; }
    }
}