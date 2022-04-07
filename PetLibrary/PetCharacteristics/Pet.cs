using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows;
using System.Windows.Media.Imaging;
using PetLibrary.GameSettings;

namespace PetLibrary
{
    public class Pet
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length >= 1)
                {
                    name = value;
                }
                else
                {
                    throw new SystemException("Ім'я не може бути пустим");
                }
            }
        }
        public State State { get; set; }

        private float money;
        public float Money
        {
            get
            {
                return money;
            }
            set
            {
                if (value >= 0)
                {
                    money = value;
                }
            }
        }

        public Pet()
        {
            Name = "Сіннабон";
            State = new State();
            Money = 10000;
        }
    }
}
