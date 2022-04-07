using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetLibrary.Store
{
    public class Medicine
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public int HealthPoints { get; set; }
        public string Image { get; set; }

        public Medicine(string name, float price, int healthPoints, string image)
        {
            Name = name;
            Price = price;
            HealthPoints = healthPoints;
            Image = image;
        }
    }
}
