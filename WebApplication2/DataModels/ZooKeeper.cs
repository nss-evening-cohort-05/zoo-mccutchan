using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ZooMccutchan.Web.DataModels
{
    public class ZooKeeper
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public bool CPR { get; set; }
        public KeeperTitle List { get; set; }
    }
    public enum KeeperTitle
    {
        Warden,
        Vetrenarian,
        Feeder,
        Cleaner
    }
}
