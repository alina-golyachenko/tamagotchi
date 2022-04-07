using PetLibrary.Store;
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

namespace Tamagotchi
{
    /// <summary>
    /// Interaction logic for StoreWindow.xaml
    /// </summary>
    public partial class StoreWindow : Window
    {
        public StoreWindow()
        {
            InitializeComponent();

        }

        public static Store storeList = new Store();
        public static ScrollViewer gridScroll = new ScrollViewer();
        public static Grid storeGrid = new Grid();
        public static Grid scrollViewerGrid = new Grid();

        private void InitializeStoreGrid()
        {
            storeWindow.Content = null;
            storeWindow.Content = new UserControl();
            gridScroll.VerticalScrollBarVisibility = ScrollBarVisibility.Visible;
            gridScroll.HorizontalAlignment = HorizontalAlignment.Center;
            gridScroll.VerticalAlignment = VerticalAlignment.Center;
            gridScroll.Height = 300;
            gridScroll.Width = 350;

            storeGrid.HorizontalAlignment = HorizontalAlignment.Center;
            storeGrid.VerticalAlignment = VerticalAlignment.Center;
            storeGrid.Height = 350;
            storeGrid.Width = 350;

            //У нас всегда будет минимум одна строка и три колонки
            storeGrid.RowDefinitions.Add(new RowDefinition());
            storeGrid.ColumnDefinitions.Add(new ColumnDefinition());
            storeGrid.ColumnDefinitions.Add(new ColumnDefinition());
            storeGrid.ColumnDefinitions.Add(new ColumnDefinition());
            storeGrid.ColumnDefinitions.Add(new ColumnDefinition());
        }
        private void FillFoodWindow(int cpImage, ProductWindow productWindow)
        {
            productWindow.labelProductName.Content = storeList.Foods[cpImage].Name;
            productWindow.labelNamePoints.Content = "Кількість енергії:";
            productWindow.labelProductPrice.Content = storeList.Foods[cpImage].Price.ToString();
            productWindow.labelNameSatiety.Visibility = Visibility.Visible;
            productWindow.labelProductSatiety.Visibility = Visibility.Visible;
            productWindow.labelNameTaste.Visibility = Visibility.Visible;
            productWindow.labelProductTastiness.Visibility = Visibility.Visible;
            productWindow.labelProductSatiety.Content = storeList.Foods[cpImage].SatietyPoints.ToString();
            productWindow.labelProductPoints.Content = storeList.Foods[cpImage].Energy.ToString();
            productWindow.labelProductTastiness.Content = storeList.Foods[cpImage].Tastiness.ToString();
            productWindow.buttonFeed.Content = "нагодувати";
        }
        private void FillMedicineWindow(int cpImage, ProductWindow productWindow)
        {
            productWindow.labelProductName.Content = storeList.Medicines[cpImage].Name;
            productWindow.labelNamePoints.Content = "Бали здоров'я:";
            productWindow.labelProductPrice.Content = storeList.Medicines[cpImage].Price.ToString();
            productWindow.labelProductPoints.Content = storeList.Medicines[cpImage].HealthPoints.ToString();
            productWindow.labelNameSatiety.Visibility = Visibility.Collapsed;
            productWindow.labelProductSatiety.Visibility = Visibility.Collapsed;
            productWindow.labelNameTaste.Visibility = Visibility.Collapsed;
            productWindow.labelProductTastiness.Visibility = Visibility.Collapsed;
            productWindow.buttonFeed.Content = "дати ліки";
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            InitializeStoreGrid();
            //index of current product image
            int cpImage = 0;
            //index of current product info
            int cpInfo = 0;
            for (int i = 0; i < storeGrid.RowDefinitions.Count; i++)
            {
                for (int j = 0; j < storeGrid.ColumnDefinitions.Count; j++)
                {
                    Image image = new Image();
                    image.Width = 40;
                    image.Height = 40;
                    image.Source = new BitmapImage(new Uri(storeList.Foods[cpImage].Image, UriKind.Relative));
                    Grid.SetColumn(image, j);
                    Grid.SetRow(image, i);
                    image.HorizontalAlignment = HorizontalAlignment.Center;
                    image.VerticalAlignment = VerticalAlignment.Bottom;

                    ProductWindow productWindow = new ProductWindow();
                    FillFoodWindow(cpImage, productWindow);

                    image.MouseDown += (object sender, MouseButtonEventArgs e) =>
                    {
                        productWindow.ShowDialog();
                    };
                    storeGrid.Children.Add(image);

                    cpImage++;
                    if (cpImage >= storeList.Foods.Count)
                    {
                        break;
                    }

                    //если мы на последней колонке,
                    //и у нас ещё есть товары,
                    //переносимся на первый столбик
                    //и добавляем новую строку
                }
                storeGrid.RowDefinitions.Add(new RowDefinition());
                cpInfo = cpImage - 1;

                while (cpInfo % storeGrid.ColumnDefinitions.Count != 0)
                {
                    cpInfo--;
                }
                i++;
                for (int k = 0; k < storeGrid.ColumnDefinitions.Count && cpInfo < storeList.Foods.Count; k++)
                {
                    TextBlock textBlock = new TextBlock();
                    textBlock.Width = 50;
                    textBlock.Height = 25;
                    textBlock.TextWrapping = TextWrapping.Wrap;
                    textBlock.Text = storeList.Foods[cpInfo].Name.ToString();
                    textBlock.TextAlignment = TextAlignment.Center;
                    textBlock.FontSize = 11;
                    Grid.SetColumn(textBlock, k);
                    Grid.SetRow(textBlock, i);
                    storeGrid.Children.Add(textBlock);
                    cpInfo++;
                }
                if (cpImage < storeList.Foods.Count && storeList.Foods[cpImage] != null)
                {
                    storeGrid.RowDefinitions.Add(new RowDefinition());
                }
                else if (cpImage >= storeList.Foods.Count)
                {
                    break;
                }

            }

            storeGrid.RowDefinitions.Add(new RowDefinition());

            //index of current product image
            cpImage = 0;
            //index of current product info
            cpInfo = 0;
            for (int i = storeGrid.RowDefinitions.Count - 1; i < storeGrid.RowDefinitions.Count; i++)
            {
                for (int j = 0; j < storeGrid.ColumnDefinitions.Count; j++)
                {
                    Image image = new Image();
                    image.Width = 40;
                    image.Height = 40;
                    image.Source = new BitmapImage(new Uri(storeList.Medicines[cpImage].Image, UriKind.Relative));
                    Grid.SetColumn(image, j);
                    Grid.SetRow(image, i);
                    image.HorizontalAlignment = HorizontalAlignment.Center;
                    image.VerticalAlignment = VerticalAlignment.Bottom;
                    ProductWindow productWindow = new ProductWindow();

                    FillMedicineWindow(cpImage, productWindow);

                    image.MouseDown += (object sender, MouseButtonEventArgs e) =>
                    {
                        productWindow.ShowDialog();
                    };
                    storeGrid.Children.Add(image);

                    cpImage++;
                    if (cpImage >= storeList.Medicines.Count)
                    {
                        break;
                    }

                    //если мы на последней колонке,
                    //и у нас ещё есть товары,
                    //переносимся на первый столбик
                    //и добавляем новую строку
                }
                storeGrid.RowDefinitions.Add(new RowDefinition());
                cpInfo = cpImage - 1;

                while (cpInfo % storeGrid.ColumnDefinitions.Count != 0)
                {
                    cpInfo--;
                }
                i++;
                for (int k = 0; k < storeGrid.ColumnDefinitions.Count && cpInfo < storeList.Medicines.Count; k++)
                {
                    TextBlock textBlock = new TextBlock();
                    textBlock.Width = 50;
                    textBlock.Height = 30;
                    textBlock.TextWrapping = TextWrapping.Wrap;
                    textBlock.Text = storeList.Medicines[cpInfo].Name.ToString();
                    textBlock.TextAlignment = TextAlignment.Center;
                    textBlock.FontSize = 11;
                    Grid.SetColumn(textBlock, k);
                    Grid.SetRow(textBlock, i);
                    storeGrid.Children.Add(textBlock);
                    cpInfo++;
                }
                if (cpImage < storeList.Medicines.Count && storeList.Medicines[cpImage] != null)
                {
                    storeGrid.RowDefinitions.Add(new RowDefinition());
                }
                else if (cpImage >= storeList.Medicines.Count)
                {
                    break;
                }

            }

            gridScroll.CanContentScroll = true;
            gridScroll.Content = storeGrid;
            Content = gridScroll;

        }
         
        private void storeWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }


}
