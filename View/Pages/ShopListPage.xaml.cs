using Ali_Diplom.AppData;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ali_Diplom.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для ShopListPage.xaml
    /// </summary>
    public partial class ShopListPage : Page
    {
        public ShopListPage()
        {
            InitializeComponent();
        }

        private void ShopsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var catal = (Product)ShopsList.SelectedItem;
            if (catal != null)
            {
                var hexc = AppConnect.ali.Products.Where(IDProd => IDProd.Name_Product == IDProd.Name_Product).ToList();
                ShopsList.ItemsSource = hexc;
            }
        }
    }
}
