using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetLibrary.Store
{
    public class Food
    {
        private int satietyPoints;
        public int SatietyPoints
        {
            get
            {
                return satietyPoints;
            }
            set
            {
                satietyPoints = value;
            }
        }
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        private float price;
        public float Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        private int energy;
        public int Energy
        {
            get
            {
                return energy;
            }
            set
            {
                energy = value;
            }
        }
        private int tastiness;
        public int Tastiness
        {
            get
            {
                return tastiness;
            }
            set
            {
                if (value <= 10 && value >= 0)
                {
                    tastiness = value;
                }
                else
                {
                    throw new SystemException("Смачність їжі чи напоїв має бути по шкалі від 1 до 10");
                }
            }
        }
        private string image;
        public string Image
        {
            get
            {
                return image;
            }
            set
            {
                image = value;
            }
        }


        public Food(string name, int satietyPoints, float price, int energy, int tastiness, string image)
        {
            Name = name;
            SatietyPoints = satietyPoints;
            Price = price;
            Energy = energy;
            Tastiness = tastiness;
            Image = image;
        }
    }
}
