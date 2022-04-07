using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace PetLibrary
{
    public class State
    {
        protected int health;
        public int Health
        {
            get
            {
                return health;
            }
            set
            {
                if (value >= 100)
                {
                    health = 100;
                }
                else if (value < 100 && value >= 0)
                {
                    health = value;
                }
                else
                {
                    health = 0;
                }
            }
        }
        protected int satiety;
        public int Satiety
        {
            get
            {
                return satiety;
            }
            set
            {
                if (value >= 100)
                {
                    satiety = 100;
                }
                else if (value < 100 && value >= 0)
                {
                    satiety = value;
                }
                else
                {
                    satiety = 0;
                }
            }
        }
        protected int energy;

        public int Energy
        {
            get
            {
                return energy;
            }
            set
            {
                if (value >= 100)
                {
                    energy = 100;
                }
                else if (value < 100 && value >= 0)
                {
                    energy = value;
                }
                else
                {
                    energy = 0;
                }
            }
        }

        private int emotionalState;
        public int EmotionalState
        {
            get
            {
                return emotionalState;
            }
            set
            {
                if (value >= 100)
                {
                    emotionalState = 100;
                }
                else if (value < 100 && value >= 0)
                {
                    emotionalState = value;
                }
                else
                {
                    emotionalState = 0;
                }
            }
        }

        public bool IsSleeping { get; set; }
        public bool IsWorking { get; set; }
        public bool IsPlaying { get; set; }
        public bool IsAlive { get; set; }

        public State()
        {
            Health = 100;
            Satiety = 100;
            Energy = 100;
            EmotionalState = 100;
            IsSleeping = false;
            IsWorking = false;
            IsPlaying = false;
            IsAlive = true;
        }

    }
}
