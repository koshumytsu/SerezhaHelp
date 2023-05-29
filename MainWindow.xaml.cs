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
        public MainWindow()
        {
            InitializeComponent();
            AppConnect.ali_DiplomEntities = new AppData.Ali_DiplomEntities();
        }

        

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (LoginUserTextBox.Text == "" && (PasswordPasswordBox.Password == ""))
            {
                MessageBox.Show("Поля пустые", "Ошибка авторизации", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                AuthPols();
            }
        }
        private void AuthPols()
        {
            try
            {
                // Переменная, которая содержит в себе информацию о пользователе
                var logInUser = AppConnect.ali_DiplomEntities.User.FirstOrDefault(DataUser =>
                        DataUser.Login == LoginUserTextBox.Text && (DataUser.Password == PasswordPasswordBox.Password));

                // Если данные которые ввел пользователь, существуют в базе данных
                if (logInUser != null)
                {
                    AppConnect.IDUser_DBC = logInUser.ID;

                    My_AppMain my_AppMain = new My_AppMain();
                    my_AppMain.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Проверьте личные данные!", "Ошибка авторизации", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception ex)
            {


                MessageBox.Show(
            ex.Message.ToString(), "Неизвестная ошибка",
            MessageBoxButton.OKCancel, MessageBoxImage.Error);
            }
        }
    }
}
