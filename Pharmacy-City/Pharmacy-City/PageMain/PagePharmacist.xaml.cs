using Pharmacy_City.DataFilesApp;
using Pharmacy_City.Pharmacist;
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
    /// Логика взаимодействия для PagePharmacist.xaml
    /// </summary>
    public partial class PagePharmacist : Page
    {
        public PagePharmacist()
        {
            InitializeComponent();
        }
        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageLogin());
        }

        private void btnViewMedicines_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new ViewMedicines());
        }

        private void btnEditPharmacies_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PharmacyEditingExample());
        }

        private void btnViewPharmacies_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new ViewPharmacy());
        }

        private void btnFullAccess_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new FullAccess());
        }
    }
}
