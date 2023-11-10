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

namespace Pharmacy_City.Pharmacist
{
    /// <summary>
    /// Логика взаимодействия для PharmacyEditingExample.xaml
    /// </summary>
    public partial class PharmacyEditingExample : Page
    {
        public PharmacyEditingExample()
        {
            InitializeComponent();

            ListPharmacy.ItemsSource = OdbConnectHelper.entOdj.Pharmacy.ToList();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.GoBack();
        }

        private void BtnEditPharmacy_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PharmacyEdit((sender as Button).DataContext as Pharmacy));
        }
    }
}
