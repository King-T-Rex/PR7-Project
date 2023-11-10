using Pharmacy_City.DataFilesApp;
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

namespace Pharmacy_City.PageMain
{
    /// <summary>
    /// Логика взаимодействия для PageRegistration.xaml
    /// </summary>
    public partial class PageRegistration : Page
    {
        public PageRegistration()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.GoBack();
        }

        private void BtnCreate_Click(object sender, RoutedEventArgs e)
        {
            if (OdbConnectHelper.entOdj.User.Count(x => x.Login == TxbLogin.Text) > 0)
            {
                MessageBox.Show("Такой пользователь уже есть!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            else
            {
                try
                {
                    User userObj = new User()
                    {
                        Login = TxbLogin.Text,
                        Password = PsbPass.Password,
                        Familia = TxbFamilia.Text,
                        IDRole = 0
                    };

                    if (Btn1.IsChecked == true)
                    {
                        userObj.IDRole = 1;
                    }
                    else if (Btn2.IsChecked == true)
                    {
                        userObj.IDRole = 2;
                    }
                    else if (Btn3.IsChecked == true)
                    {
                        userObj.IDRole = 3;
                    }

                    OdbConnectHelper.entOdj.User.Add(userObj);
                    OdbConnectHelper.entOdj.SaveChanges();
                    MessageBox.Show("Пользователь создан!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка работы приложения: " + ex.Message.ToString(), "Критический сбор работы", MessageBoxButton.OK, MessageBoxImage.Information);
                } 
            }
        }

        private void PsbPass_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (TxbPass.Text == PsbPass.Password)
            {
                BtnCreate.IsEnabled = true;
                PsbPass.Background = Brushes.LightGreen;
                PsbPass.BorderBrush = Brushes.Green;
            }
            else
            {
                BtnCreate.IsEnabled = false;
                PsbPass.Background = Brushes.LightCoral;
                PsbPass.BorderBrush = Brushes.Red;
            }
        }
    }
}
