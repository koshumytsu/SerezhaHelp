using Ali_Diplom.View.Pages;
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

namespace Ali_Diplom
{
    /// <summary>
    /// Логика взаимодействия для My_AppMain.xaml
    /// </summary>
    public partial class My_AppMain : Window
    {
        public My_AppMain()
        {
            InitializeComponent();
        }

        private void Catalog_Click(object sender, RoutedEventArgs e)
        {
            MainFrm.Navigate(new PromoPage());
        }

        private void Profile_Click(object sender, RoutedEventArgs e)
        {
            MainFrm.Navigate(new ProfilePage());
        }

        private void MainCatalog_Click(object sender, RoutedEventArgs e)
        {
            MainFrm.Navigate(new StorePage());
        }

        private void Shops_Click(object sender, RoutedEventArgs e)
        {
            MainFrm.Navigate(new ShopListPage());
        }

        private void My_Orders_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
