using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Threading;

namespace PetLibrary.GameSettings
{
    public class Music
    {
        public static readonly string SoundPath = new DirectoryInfo(Directory.GetCurrentDirectory()).FullName.ToString() + @"\Music";

        private static MediaPlayer media;

        public static List<MediaPlayer> MainWindowMusic { get; private set; }
        public static List<MediaPlayer> InGameMusic { get; private set; }
        public static List<MediaPlayer> LullabyMusic { get; private set; }
        public static List<MediaPlayer> SelectSound { get; private set; }
        public static List<MediaPlayer> TubePlayingMusic { get; private set; }
        public static List<MediaPlayer> WorkingMusic { get; private set; }


        public static MediaPlayer CurrentSong { get; set; }

        private static MediaPlayer FindSound(string path)
        {
            media = new MediaPlayer();
            media.Open(new Uri(path));
            return media;
        }

        public Music()
        {
            MainWindowMusic = new List<MediaPlayer>();
            MainWindowMusic.Add(FindSound(SoundPath + @"\Ruins.mp3"));

            CurrentSong = MainWindowMusic[0];

            InGameMusic = new List<MediaPlayer>();
            InGameMusic.Add(FindSound(SoundPath + @"\Home.mp3"));

            LullabyMusic = new List<MediaPlayer>();
            LullabyMusic.Add(FindSound(SoundPath + @"\FallenDown.mp3"));

            TubePlayingMusic = new List<MediaPlayer>();
            TubePlayingMusic.Add(FindSound(SoundPath + @"\TakeMeToChurch.mp3"));

            WorkingMusic = new List<MediaPlayer>();
            WorkingMusic.Add(FindSound(SoundPath + @"\GameOfThrones.mp3"));

        }

    }
}
