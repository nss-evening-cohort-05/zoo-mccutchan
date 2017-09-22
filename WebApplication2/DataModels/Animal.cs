using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ZooMccutchan.Web.DataModels
{
    public class Animal
    {
        public int Id { get; set; }
        public string AnimalOfficialName { get; set; }
        public AnimalClass Type { get; set; }
        public string AnimalDescription { get; set; }
        public string AnimalPetName { get; set; }
        public AnimalFood List { get; set; }
    }
    public enum AnimalClass
    {
        Reptile,
        Mammal,
        Fish,
        Bird
    }
    public enum AnimalFood
    {
        Meat,
        Fruit,
        Vegetables,
        Mix
    }
}
