﻿using Ali_Diplom.AppData;
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
    /// Логика взаимодействия для ProfilePage.xaml
    /// </summary>
    public partial class ProfilePage : Page
    {
        private NavigationHelper _navigationHelper;
        public ProfilePage()
        {
            InitializeComponent();
        }
       

        private void Edit_Profile_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                var hex = AppConnect.ali_DiplomEntities.User.Find(AppConnect.IDUser_DBC);
                IDTB.Text = hex.ID.ToString();
                LogTB.Text = hex.Login.ToString();
                Full_NameTB.Text = hex.Full_Name.ToString();
            }
        }
    }
}
