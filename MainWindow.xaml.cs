using Ali_Diplom.AppData;
using Ali_Diplom.View.Windows;
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

namespace Ali_Diplom
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static User user;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var qwe = AppConnect.ali.User.Where(i => i.Login == UsernameBox.Text && i.Password == PasswordBox.Password).FirstOrDefault();
            if(qwe != null)
            {
                My_AppMain my_AppMain = new My_AppMain();
                MessageBox.Show("Добро пожаловать");
                my_AppMain.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Проверье введенные данные");
            }
        }
    }
}
