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
    /// Логика взаимодействия для PageLogin.xaml
    /// </summary>
    public partial class PageLogin : Page
    {
        public PageLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var userObj = OdbConnectHelper.entOdj.User.FirstOrDefault(
                    x => x.Login == TxbLogin.Text && x.Password == PsbPass.Password
                    );

                if (userObj == null)
                {
                    MessageBox.Show("Такой пользователь отсутствует!",
                                "Уведомление",
                                MessageBoxButton.OK,
                                MessageBoxImage.Information);
                    FrameApp.frmObj.Navigate(new PageRegistration());
                }
                else
                {
                    switch (userObj.IDRole)
                    {
                        case 1:
                            FrameApp.frmObj.Navigate(new PageApteka());
                            break;
                        case 2:
                            FrameApp.frmObj.Navigate(new PagePatients());
                            break;
                        case 3:
                            FrameApp.frmObj.Navigate(new PagePharmacist());
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Критический сбор в работе приложения:" + ex.Message.ToString(),
                                "Уведомление",
                                MessageBoxButton.OK,
                                MessageBoxImage.Warning);
            }
        }

        private void BthReg_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageRegistration());
        }
    }
}
