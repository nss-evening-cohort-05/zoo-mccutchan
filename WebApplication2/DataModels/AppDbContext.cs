using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ZooMccutchan.Web.DataModels
{
    public class AppDbContext : DbContext
    {
        public class AppDbContext() : base("ZooMccutchan")
        {}
        public DbSet<ZooKeeper> ID { get; set; }
        public DbSet<Animal> animalID { get; set; }
        public AppDbContext<Enclosure> enclosureID { get; set; }
    }
}