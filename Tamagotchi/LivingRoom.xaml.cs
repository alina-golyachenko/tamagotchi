using Newtonsoft.Json;
using PetLibrary;
using PetLibrary.GameSettings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;
using WMPLib;

namespace Tamagotchi
{
    /// <summary>
    /// Interaction logic for LivingRoom.xaml
    /// </summary>
    public partial class LivingRoom : Window
    {
        public LivingRoom()
        {
            InitializeComponent();
        }

        public static Pet pet = new Pet();

        private DispatcherTimer gameTimer = new DispatcherTimer();
        //текущие временные параметры игры
        private StateTimer gameState = new StateTimer();
        //для анимации персонажа
        private DispatcherTimer spriteTimer = new DispatcherTimer();
        //для инициализации спрайтов
        private Animation animation = new Animation();
        //для удобного обновления текущего спрайта
        private BitmapImage currentSprite = Animation.RegularSprites[0];
        private StoreWindow storeWindow = new StoreWindow();
        //Для игровой музычки


        public void Media_Ended(object sender, EventArgs e)
        {
            Music.CurrentSong.Stop();
            Music.CurrentSong.Play();
        }

        private void ToDayWindow()
        {

            SolidColorBrush whiteBrush = new SolidColorBrush();
            whiteBrush.Color = Color.FromArgb(255, 255, 255, 255);
            this.Background = whiteBrush;

            SolidColorBrush blackBrush = new SolidColorBrush();
            blackBrush.Color = Color.FromArgb(255, 0, 0, 0);

            progressBarSatiety.BorderBrush = blackBrush;
            progressBarEnergy.BorderBrush = blackBrush;
            progressBarEmotions.BorderBrush = blackBrush;
            progressBarHealth.BorderBrush = blackBrush;

            ImageBrush imageBrush = new ImageBrush();
            imageBrush.ImageSource = Animation.DayMenu[0];
            progressBarSatiety.Background = imageBrush;

            imageBrush = new ImageBrush();
            imageBrush.ImageSource = Animation.DayMenu[1];
            progressBarEnergy.Background = imageBrush;

            imageBrush = new ImageBrush();
            imageBrush.ImageSource = Animation.DayMenu[2];
            progressBarEmotions.Background = imageBrush;

            imageBrush = new ImageBrush();
            imageBrush.ImageSource = Animation.DayMenu[3];
            progressBarHealth.Background = imageBrush;

            buttonPlay.Foreground = blackBrush;
            buttonSleep.Foreground = blackBrush;
            buttonWork.Foreground = blackBrush;
            buttonStore.Foreground = blackBrush;

            buttonPlay.BorderBrush = blackBrush;
            buttonSleep.BorderBrush = blackBrush;
            buttonWork.BorderBrush = blackBrush;
            buttonStore.BorderBrush = blackBrush;

            labelTotalMoney.Foreground = blackBrush;

            imageBrush = new ImageBrush();
            imageBrush.ImageSource = Animation.DayMenu[4];
            buttonMenu.Background = imageBrush;

            SolidColorBrush transparentBrush = new SolidColorBrush();
            transparentBrush.Color = Color.FromArgb(0, 0, 0, 0);
            textBoxName.Background = transparentBrush;
            textBoxName.Foreground = blackBrush;
            if (new FileInfo(SaveAndLoad.PathToPetFile).Length == 0)
            {
                textBoxName.BorderBrush = blackBrush;
            }

            SolidColorBrush lightGreyBrush = new SolidColorBrush();
            lightGreyBrush.Color = Color.FromArgb(26, 0, 0, 0);

            progressBarEmotions.Foreground = lightGreyBrush;
            progressBarSatiety.Foreground = lightGreyBrush;
            progressBarHealth.Foreground = lightGreyBrush;
            progressBarEnergy.Foreground = lightGreyBrush;

            buttonGiveName.Foreground = blackBrush;
            buttonGiveName.Background = transparentBrush;


        }
        private void ToNightWindow()
        {
            ImageBrush windowImageBrush = new ImageBrush();
            windowImageBrush.ImageSource = new BitmapImage(new Uri(@"Images\Backgrounds\nightSky.png", UriKind.Relative));
            windowImageBrush.Stretch = Stretch.Uniform;
            this.Background = windowImageBrush;

            SolidColorBrush whiteBrush = new SolidColorBrush();
            whiteBrush.Color = Color.FromArgb(255, 255, 255, 255);

            progressBarSatiety.BorderBrush = whiteBrush;
            progressBarEnergy.BorderBrush = whiteBrush;
            progressBarEmotions.BorderBrush = whiteBrush;
            progressBarHealth.BorderBrush = whiteBrush;

            ImageBrush imageBrush = new ImageBrush();
            imageBrush.ImageSource = Animation.NightMenu[0];
            progressBarSatiety.Background = imageBrush;

            imageBrush = new ImageBrush();
            imageBrush.ImageSource = Animation.NightMenu[1];
            progressBarEnergy.Background = imageBrush;

            imageBrush = new ImageBrush();
            imageBrush.ImageSource = Animation.NightMenu[2];
            progressBarEmotions.Background = imageBrush;

            imageBrush = new ImageBrush();
            imageBrush.ImageSource = Animation.NightMenu[3];
            progressBarHealth.Background = imageBrush;


            buttonPlay.BorderBrush = whiteBrush;
            buttonSleep.BorderBrush = whiteBrush;
            buttonWork.BorderBrush = whiteBrush;
            buttonStore.BorderBrush = whiteBrush;

            buttonPlay.Foreground = whiteBrush;
            buttonSleep.Foreground = whiteBrush;
            buttonWork.Foreground = whiteBrush;
            buttonStore.Foreground = whiteBrush;

            labelTotalMoney.Foreground = whiteBrush;

            imageBrush = new ImageBrush();
            imageBrush.ImageSource = Animation.NightMenu[4];
            buttonMenu.Background = imageBrush;

            SolidColorBrush transparentBrush = new SolidColorBrush();
            transparentBrush.Color = Color.FromArgb(0, 0, 0, 0);
            textBoxName.Background = transparentBrush;
            textBoxName.Foreground = whiteBrush;

            buttonGiveName.Foreground = whiteBrush;
            buttonGiveName.Background = transparentBrush;

            if (new FileInfo(SaveAndLoad.PathToPetFile).Length == 0)
            {
                textBoxName.BorderBrush = whiteBrush;
            }

            SolidColorBrush lightGreyBrush = new SolidColorBrush();
            lightGreyBrush.Color = Color.FromArgb(100, 0, 0, 0);

            progressBarEmotions.Foreground = lightGreyBrush;
            progressBarSatiety.Foreground = lightGreyBrush;
            progressBarHealth.Foreground = lightGreyBrush;
            progressBarEnergy.Foreground = lightGreyBrush;


        }
        private void SpriteTimerStart()
        {
            pictureBoxPet.Source = currentSprite;
            spriteTimer = new DispatcherTimer();
            spriteTimer.Tick += spriteTimer_tick;
            spriteTimer.Interval = TimeSpan.FromMilliseconds(550);
            spriteTimer.Start();
            timeOfAnimationStart = DateTime.Now;
        }
        private void RefreshProgressBars()
        {
            progressBarSatiety.Value = pet.State.Satiety;
            progressBarEnergy.Value = pet.State.Energy;
            progressBarEmotions.Value = pet.State.EmotionalState;
            progressBarHealth.Value = pet.State.Health;
        }
        private void ToRegularState()
        {
            Music.CurrentSong.Stop();
            Music.CurrentSong = Music.InGameMusic[0];
            Music.CurrentSong.Play();

            currentSprite = Animation.RegularSprites[0];
            pictureBoxPet.Source = currentSprite;

            pet.State.IsSleeping = false;
            pet.State.IsWorking = false;
            pet.State.IsPlaying = false;

            timeOfAnimationStart = DateTime.MaxValue;

            spriteTimer.Stop();
            spriteTimer = null;
        }

        public void Death()
        {
            pet.State.IsAlive = false;
            gameTimer.Stop();
            Music.CurrentSong.Stop();
            currentSprite = Animation.GraveSprites[0];
            pictureBoxPet.Source = currentSprite;

            if (File.Exists(SaveAndLoad.PathToPetFile) && File.Exists(SaveAndLoad.PathToSettingsFile))
            {
                File.Delete(SaveAndLoad.PathToPetFile);
                File.Delete(SaveAndLoad.PathToSettingsFile);
            }
            
            MessageBoxResult dialogResult = MessageBox.Show("Вашої тваринки більше немає... Наступного разу піклуйтеся про неї краще", "Game over...", MessageBoxButton.OK);
            this.Hide();
            TitleWindow titleWindow = new TitleWindow();
            titleWindow.Show();

        }

        private void buttonGiveName_Click(object sender, RoutedEventArgs e)
        {
            textBoxName.IsReadOnly = true;
            textBoxName.BorderBrush = Brushes.Transparent;
            textBoxName.TextAlignment = TextAlignment.Center;
            buttonGiveName.Visibility = Visibility.Collapsed;

            pet.Name = textBoxName.Text;
        }

        public void LoadInfo()
        {
            if (new FileInfo(SaveAndLoad.PathToPetFile).Length != 0 && new FileInfo(SaveAndLoad.PathToSettingsFile).Length != 0)
            {

                pet = SaveAndLoad.LoadPet();
                gameState = SaveAndLoad.LoadSettings();
                textBoxName.Text = pet.Name;
                       textBoxName.IsReadOnly = true;
                       textBoxName.BorderBrush = Brushes.Transparent;
                       textBoxName.TextAlignment = TextAlignment.Center;
                       labelTotalMoney.Content = pet.Money.ToString();

                //Добавляем ко времени, прошедшему с начала новой игры, время, которые было упущено,
                //пока приложение было закрыто
                TimeSpan missedTime = DateTime.Now - gameState.TimeOfLastGameEnd;
                gameState.TotalGameTime += missedTime;

                //считаем, как изменилось состояние персонажа за время нашего отсутствия
                //проверяем сытость и сразу считаем, сколько здоровья теряется, т.к. это полностью зависимый показатель
                //и мы не сможем получить его путём измерения времени

                int missedHealthPoints = 0;

                //смотрим, сколько сытости надо отнять
                int missedPoints = Convert.ToInt32(missedTime.TotalSeconds);
                //если отнять надо больше 100, то персонаж стал полностью голодным раньше, чем мы зашли в игру
                if (missedPoints > 100)
                {
                    //находим сколько секунд назад персонаж полностью проголодался и отнимаем от текущего времени
                    //получаем время начала голодания
                    gameState.TimeOfStarvingBeginning = DateTime.Now - TimeSpan.FromSeconds(missedPoints - 100);
                    //проверяем как голодание повлияло на дургие показатели
                    if (DateTime.Now - gameState.TimeOfStarvingBeginning > TimeSpan.FromSeconds(20))
                    {
                        //каждые 5 секунд уменьшелись показатели. Всего прошло ... секунд:
                        missedTime = DateTime.Now - gameState.TimeOfStarvingBeginning - TimeSpan.FromSeconds(20);

                        missedHealthPoints += (Convert.ToInt32(Math.Round((missedTime.TotalSeconds / 5), 0))) * 10;
                        pet.State.Health -= missedHealthPoints;
                        pet.State.EmotionalState -= (Convert.ToInt32(Math.Round((missedTime.TotalSeconds / 5), 0))) * 5;
                        pet.State.Energy -= (Convert.ToInt32(Math.Round((missedTime.TotalSeconds / 5), 0))) * 2;
                    }
                }
                pet.State.Satiety -= missedPoints;


                //смотрим, сколько энергии надо отнять
                missedPoints = Convert.ToInt32(Math.Round((missedTime.TotalSeconds / 2), 0));
                if (missedPoints > 100)
                {

                    gameState.TimeOfZeroEnergy = DateTime.Now - TimeSpan.FromSeconds((missedPoints - 100)) * 3;
                    if (DateTime.Now - gameState.TimeOfZeroEnergy > TimeSpan.FromSeconds(20))
                    {
                        //каждые 5 секунд уменьшались показатели. Всего прошло ... секунд:
                        missedTime = DateTime.Now - gameState.TimeOfZeroEnergy - TimeSpan.FromSeconds(20);
                        missedHealthPoints += (Convert.ToInt32(Math.Round((missedTime.TotalSeconds / 5), 0))) * 10;
                        pet.State.Health -= missedHealthPoints;
                        pet.State.EmotionalState -= (Convert.ToInt32(Math.Round((missedTime.TotalSeconds / 5), 0))) * 7;
                    }
                }
                pet.State.Energy -= missedPoints;


                if (gameState.TimeOfLastPleasantAction != DateTime.MinValue)
                {
                    //смотрим, сколько настроения надо отнять
                    if (DateTime.Now - gameState.TimeOfLastPleasantAction > TimeSpan.FromSeconds(20))
                    {
                        //каждые 5 секунд уменьшелись показатели. Всего прошло ... секунд:
                        missedTime = DateTime.Now - gameState.TimeOfLastPleasantAction - TimeSpan.FromSeconds(20);

                        pet.State.EmotionalState -= (Convert.ToInt32(Math.Round((missedTime.TotalSeconds / 5), 0)));
                    }
                }
                else
                {
                    missedTime = DateTime.Now - gameState.TimeOfLastGameEnd - TimeSpan.FromSeconds(20);
                    pet.State.EmotionalState -= (Convert.ToInt32(Math.Round((missedTime.TotalSeconds / 5), 0)));
                }


                //Проверяем, закончил ли персонаж спать
                if (pet.State.IsSleeping &&
                        gameState.StartOfThisGame - gameState.TimeOfSleepingBeginning > TimeSpan.FromSeconds(40))
                {
                    pet.State.IsSleeping = false;
                    pet.State.Energy = 100;
                    pet.State.EmotionalState += 10;

                    gameState.TimeOfSleepingBeginning = DateTime.MaxValue;

                     
                    ToRegularState();
                    ToDayWindow();

                }
                else if (pet.State.IsSleeping &&
                    gameState.StartOfThisGame - gameState.TimeOfSleepingBeginning < TimeSpan.FromSeconds(40))
                {
                    ToNightWindow();

                    currentSprite = Animation.SleepingSprites[1];
                    SpriteTimerStart();
                    Music.CurrentSong.Stop();
                    Music.CurrentSong = Music.LullabyMusic[0];
                    Music.CurrentSong.Play();
                }// проверяем, закончил ли персонаж работать
                else if (pet.State.IsWorking &&
                    gameState.StartOfThisGame - gameState.TimeOfWorkingBeginning > TimeSpan.FromSeconds(20))
                {
                    gameState.TimeOfWorkingBeginning = DateTime.MaxValue;
                    pet.Money += 200;
                    pet.State.Energy -= 10;

                    ToRegularState();
                    ToDayWindow();
                }
                else if (pet.State.IsWorking &&
                    gameState.StartOfThisGame - gameState.TimeOfWorkingBeginning < TimeSpan.FromSeconds(20))
                {
                    ToDayWindow();
                    currentSprite = Animation.WorkingSprites[0];
                    pictureBoxPet.Source = currentSprite;
                    Music.CurrentSong.Stop();
                    Music.CurrentSong = Music.WorkingMusic[0];
                    Music.CurrentSong.Play();
                }
                else
                {
                    ToRegularState();
                    ToDayWindow();
                }
            }
            else
            {
                ToRegularState();
                ToDayWindow();
            }

            RefreshProgressBars();
        }

        private void livingRoomWindow_Loaded(object sender, RoutedEventArgs e)
        {
            gameTimer.Tick += gameTimer_tick;
            gameTimer.Interval = TimeSpan.FromSeconds(1);

            gameTimer.Start();

            gameState.StartOfThisGame = DateTime.Now;

        }

        public void gameTimer_tick(object sender, EventArgs e)
        {
            Music.CurrentSong.MediaEnded += new EventHandler(Media_Ended);

            gameState.ThisGameTime = DateTime.Now - gameState.StartOfThisGame;

            //Обновляем надпись с балансом денег
            labelTotalMoney.Content = pet.Money.ToString();

            //Каждые 2 секунды отнимаем сытость
            pet.State.Satiety--;

            //если голодание слишком долгое, то эмоциональное состояние,
            //энергия и здоровье будут ухудшаться сильнее
            if (DateTime.Now - gameState.TimeOfStarvingBeginning > TimeSpan.FromSeconds(20) &&
                Math.Round(gameState.ThisGameTime.TotalSeconds % 5, 0) == 0)
            {
                pet.State.Health -= 10;
                pet.State.EmotionalState -= 5;
                pet.State.Energy -= 2;
            }

            //Когда проходит 2 секунды, отнимается 1% энергии
            if (Math.Round(gameState.ThisGameTime.TotalSeconds % 2, 0) == 0)
            {
                pet.State.Energy--;
            }
            //если быть слишком долго без сна, -- эмоциональное состояние
            //и здоровье будут ухудшаться быстрее
            if (DateTime.Now - gameState.TimeOfZeroEnergy > TimeSpan.FromSeconds(20) &&
                Math.Round(gameState.ThisGameTime.TotalSeconds % 5, 0) == 0)
            {
                pet.State.Health -= 10;
                pet.State.EmotionalState -= 7;
            }

            //Когда с момента последней игры проходит 40 секунд
            //мы можем отнимать по 1% настроения каждые
            if (DateTime.Now - gameState.TimeOfLastPleasantAction > TimeSpan.FromSeconds(20)
                && Math.Round(gameState.ThisGameTime.TotalSeconds % 5, 0) == 0)
            {
                pet.State.EmotionalState--;
            }



            RefreshProgressBars();
        }


        private DateTime timeOfAnimationStart = new DateTime();

        private void buttonMenu_Click(object sender, RoutedEventArgs e)
        {
            //Сохраняем текущее состояние персонажа
            pet.State.IsPlaying = false;
            SaveAndLoad.Save(pet);

            //Сохраняем текущие настройки игры
            gameState.TimeOfLastGameEnd = DateTime.Now;
            gameState.ThisGameTime = DateTime.Now - gameState.StartOfThisGame;
            gameState.TotalGameTime += gameState.ThisGameTime;
            SaveAndLoad.Save(gameState);

            Music.CurrentSong.Stop();
            TitleWindow titleWindow = new TitleWindow();
            titleWindow.Show();
            this.Hide();
        }
        private void buttonPlay_Click(object sender, RoutedEventArgs e)
        {
            if (pet.State.IsSleeping)
            {
                MessageBox.Show("Zzzz...", "", MessageBoxButton.OK);
            }
            else if (pet.State.IsWorking)
            {
                MessageBox.Show("Упс, зараз я на роботі, але коли повернуся, знову зможу гратися :3", "", MessageBoxButton.OK);
            }
            else if (pet.State.Energy < 30)
            {
                MessageBox.Show("В мене надто мало сил, щоб гратися. Коли посплю, знову зможу", "", MessageBoxButton.OK);
            }
            else
            {
                currentSprite = Animation.TubeSprites[0];
                pictureBoxPet.Source = currentSprite;

                Music.CurrentSong.Stop();
                Music.CurrentSong = Music.TubePlayingMusic[0];
                Music.CurrentSong.Play();

                pet.State.IsPlaying = true;
                pet.State.EmotionalState += 30;
                gameState.TimeOfLastPleasantAction = DateTime.Now;

                SpriteTimerStart();
            }

        }

        private void buttonSleep_Click(object sender, RoutedEventArgs e)
        {
            if (pet.State.IsWorking)
            {
                MessageBox.Show("Зараз я на роботі, але коли повернуся, якраз захочеться спати :3", "Упс...", MessageBoxButton.OK);
            }
            else if (!pet.State.IsSleeping)
            {
                ToNightWindow();

                Music.CurrentSong.Stop();
                Music.CurrentSong = Music.LullabyMusic[0];
                Music.CurrentSong.Play();
                currentSprite = Animation.SleepingSprites[0];
                pictureBoxPet.Source = currentSprite;

                pet.State.IsSleeping = true;
                pet.State.Energy = 100;
                pet.State.EmotionalState += 10;

                gameState.TimeOfSleepingBeginning = DateTime.Now;
                gameState.TimeOfZeroEnergy = DateTime.MaxValue;
                SpriteTimerStart();
            }
        }
        private void buttonWork_Click(object sender, RoutedEventArgs e)
        {

            if (pet.State.IsSleeping)
            {
                MessageBox.Show("Zzzz...", "", MessageBoxButton.OK);
            }
            else if (!pet.State.IsWorking)
            {
                ToDayWindow();
                currentSprite = Animation.WorkingSprites[0];
                pictureBoxPet.Source = currentSprite;

                Music.CurrentSong.Stop();
                Music.CurrentSong = Music.WorkingMusic[0];
                Music.CurrentSong.Play();

                pet.State.IsWorking = true;

                gameState.TimeOfWorkingBeginning = DateTime.Now;
            }
        }
        private void buttonStore_Click(object sender, RoutedEventArgs e)
        {
            storeWindow.Show();
        }

        private void spriteTimer_tick(object sender, EventArgs e)
        {
            TimeSpan timeOfAction = TimeSpan.Zero;
            if (pet.State.IsSleeping)
            {
                timeOfAction = TimeSpan.FromSeconds(40);
            }
            else if (pet.State.IsWorking)
            {
                timeOfAction = TimeSpan.FromSeconds(20);
            }
            else
            {
                timeOfAction = TimeSpan.FromSeconds(10);
            }

            if (DateTime.Now <= timeOfAnimationStart + timeOfAction)
            {
                currentSprite = animation.Animate(currentSprite);
                pictureBoxPet.Source = currentSprite;
            }
            else
            {
                ToRegularState();
                ToDayWindow();
            }
        }

        private void progressBarSatiety_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (pet.State.Satiety == 0)
            {
                gameState.TimeOfStarvingBeginning = DateTime.Now;
            }
            else
            {
                gameState.TimeOfStarvingBeginning = DateTime.MaxValue;
            }
        }
        private void progressBarEnergy_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //Чем дольше персонаж на нулевой энергии, тем хуже его настроение
            //Отмечаем, когда энергия достигла 0
            if (pet.State.Energy == 0)
            {
                gameState.TimeOfZeroEnergy = DateTime.Now;
            }
            else
            {
                gameState.TimeOfZeroEnergy = DateTime.MaxValue;
            }
        }
        private void progressBarHealth_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //Если персонаж сильно болеет, он умирает

            if (progressBarHealth.Value == 0)
            {
                gameTimer.Stop();
                pet.State.IsAlive = false;
                Death();
            }
        }

        private void livingRoomWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (pet.State.IsAlive)
            {
                //Сохраняем текущее состояние персонажа
                pet.State.IsPlaying = false;
                //Сохраняем текущие настройки игры
                gameState.TimeOfLastGameEnd = DateTime.Now;
                gameState.ThisGameTime = DateTime.Now - gameState.StartOfThisGame;
                gameState.TotalGameTime += gameState.ThisGameTime;
                SaveAndLoad.Save(pet);
                SaveAndLoad.Save(gameState);
            }
            Application.Current.Shutdown();
        }

        private void livingRoomWindow_Unloaded(object sender, RoutedEventArgs e)
        {
        }
    }
}
