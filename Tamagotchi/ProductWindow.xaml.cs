using PetLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace Tamagotchi
{
    /// <summary>
    /// Interaction logic for ProductWindow.xaml
    /// </summary>
    public partial class ProductWindow : Window
    {
        public ProductWindow()
        {
            InitializeComponent();
        }

        private void buttonFeed_click(object sender, RoutedEventArgs e)
        {
            if (LivingRoom.pet.Money - (float)Convert.ToDouble(labelProductPrice.Content) >= 0)
            {
                if (LivingRoom.pet.State.IsSleeping)
                {
                    MessageBox.Show("Zzzz...", "", MessageBoxButton.OK);
                }
                else if(LivingRoom.pet.State.IsPlaying)
                {
                    MessageBox.Show("Зараз, я дограю, і буду їсти", "", MessageBoxButton.OK);

                }
                else
                {
                    
                    LivingRoom.pet.Money -= (float)Convert.ToDouble(labelProductPrice.Content);
                    if (labelNamePoints.Content.ToString().ToLower().Contains("енерг"))
                    {
                        if (LivingRoom.pet.State.IsWorking)
                        {
                            MessageBox.Show("Мені як раз хотілося їсти. Дякую <3", "", MessageBoxButton.OK);
                        }
                        LivingRoom.pet.State.Energy += Convert.ToInt32(labelProductPoints.Content);
                        LivingRoom.pet.State.Satiety += Convert.ToInt32(labelProductSatiety.Content);
                        if (Convert.ToInt32(labelProductTastiness.Content) >= 5)
                        {
                            LivingRoom.pet.State.EmotionalState += Convert.ToInt32(labelProductTastiness.Content);
                        }
                        else
                        {
                            LivingRoom.pet.State.EmotionalState -= 15;
                        }
                    }
                    else if (labelNamePoints.Content.ToString().ToLower().Contains("здоров"))
                    {
                        if (LivingRoom.pet.State.IsWorking)
                        {
                            MessageBox.Show("Відчуваю себе краще. Дякую <3", "", MessageBoxButton.OK);
                        }
                        LivingRoom.pet.State.Health += Convert.ToInt32(labelProductPoints.Content);
                    }
                }

            }
            else
            {
                MessageBox.Show("У вас мене немає стільки грошей(", "Помилка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            this.Close();

        }

        private void buttonCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void productWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
