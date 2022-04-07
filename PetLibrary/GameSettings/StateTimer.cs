using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Threading;


namespace PetLibrary.GameSettings
{
    public class StateTimer
    {
        //<summary>
        //время всей игры
        //</sгmmary>
        
        //game times
        public TimeSpan TotalGameTime { get; set; }
        public DateTime StartOfThisGame { get; set; }
        public TimeSpan ThisGameTime { get; set; }
        public DateTime TimeOfLastGameEnd { get; set; }

        //state times
        public DateTime TimeOfLastPleasantAction { get; set; }
        public DateTime TimeOfZeroEnergy { get; set; }
        public DateTime TimeOfStarvingBeginning { get; set; }
        public DateTime TimeOfSleepingBeginning { get; set; }
        public DateTime TimeOfWorkingBeginning { get; set; }


        public StateTimer()
        {
            TotalGameTime = TimeSpan.Zero;
            StartOfThisGame = DateTime.Now;
            ThisGameTime = TimeSpan.Zero;
            TimeOfLastGameEnd = DateTime.MaxValue;
            TimeOfSleepingBeginning = DateTime.MaxValue;
            TimeOfWorkingBeginning = DateTime.MaxValue;
            TimeOfZeroEnergy = DateTime.MaxValue;
            TimeOfStarvingBeginning = DateTime.MaxValue;
            TimeOfLastPleasantAction = DateTime.MinValue;
        }

    }
}
