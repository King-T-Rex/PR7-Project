using Pharmacy_City.Apteka;
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

namespace Pharmacy_City.PageApteka
{
    /// <summary>
    /// Логика взаимодействия для AddPharmacies.xaml
    /// </summary>
    public partial class AddPharmacies : Page
    {
        public AddPharmacies()
        {
            InitializeComponent();
        }

        private void BtnAddApteka_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Pharmacy phaObj = new Pharmacy()
                {
                    Title = TxbTitleApteka.Text,
                    AddressPhar = TxbAddress.Text,
                    StartWork = Int32.Parse(TxbStartWork.Text),
                    EndWork = Int32.Parse(TxbEndWork.Text)
                };


                OdbConnectHelper.entOdj.Pharmacy.Add(phaObj);
                OdbConnectHelper.entOdj.SaveChanges();

                MessageBox.Show(
                    "Аптека " + phaObj.Title + " успешно добавлена!",
                    "Уведомление",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information
                    );
                FrameApp.frmObj.Navigate(new Pharmacies());

            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Кристическая работа с приложением: " + ex.Message.ToString(),
                    "Уведомление",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning
                    );
            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.GoBack();
        }
    }
}
