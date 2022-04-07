using PetLibrary;
using PetLibrary.GameSettings;
using System;
using System.IO;
using System.Threading;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Tamagotchi
{
    /// <summary>
    /// Interaction logic for TitleWindow.xaml
    /// </summary>
    public partial class TitleWindow : Window
    {
        public TitleWindow()
        {
            InitializeComponent();

            if (File.Exists(SaveAndLoad.PathToPetFile) && File.Exists(SaveAndLoad.PathToSettingsFile))
            {
                buttonLoadGame.Visibility = Visibility.Visible;
            }
            else
            {
                buttonLoadGame.Visibility = Visibility.Collapsed;
            }

            imageLoading.Visibility = Visibility.Collapsed;
            labelLoading.Visibility = Visibility.Collapsed;

            gameTitleImage.Source = new BitmapImage(new Uri(new DirectoryInfo(Directory.GetCurrentDirectory()).FullName.ToString() + @"\Images\Title\title.png"));   
        }

        public LivingRoom livingRoom = new LivingRoom();
        public Music music = new Music();

        private void buttonQuitGame_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void buttonNewGame_Click(object sender, RoutedEventArgs e)
        {
            if (File.Exists(SaveAndLoad.PathToPetFile) && File.Exists(SaveAndLoad.PathToSettingsFile))
            {
                File.Delete((SaveAndLoad.PathToPetFile));
                File.Delete((SaveAndLoad.PathToSettingsFile));
            }

            FileStream fileStream = new FileStream(SaveAndLoad.PathToPetFile, FileMode.Create);
            fileStream.Close();

            fileStream = new FileStream(SaveAndLoad.PathToSettingsFile, FileMode.Create);
            fileStream.Close();


            Music.CurrentSong.Stop();

            LivingRoom.pet = new Pet();
            livingRoom.LoadInfo();
            livingRoom.Show();
            Hide();

        }
        private void buttonLoadGame_Click(object sender, RoutedEventArgs e)
        {
            buttonLoadGame.Visibility = Visibility.Collapsed;
            buttonNewGame.Visibility = Visibility.Collapsed;
            livingRoom.buttonGiveName.Visibility = Visibility.Collapsed;
            imageLoading.Visibility = Visibility.Visible;
            labelLoading.Visibility = Visibility.Visible;

            livingRoom.LoadInfo();

            livingRoom.Show();
            Hide();

        }

        private void titleWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void titleWindow_Loaded(object sender, RoutedEventArgs e)
        {
            Music.CurrentSong.Stop();
            Music.CurrentSong = Music.MainWindowMusic[0];
            Music.CurrentSong.Play();

            
        }
    }
}
