using Pharmacy_City.DataFilesApp;
using Pharmacy_City.Apteka;
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
using Pharmacy_City.Pharmacist;

namespace Pharmacy_City.PageMain
{
    /// <summary>
    /// Логика взаимодействия для PageApteka.xaml
    /// </summary>
    public partial class PageApteka : Page
    {
        public PageApteka()
        {
            InitializeComponent();
        }
        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageLogin());
        }

        private void btnMedicines_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new Medicines());
        }

        private void btnProcedure_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new Procedure());
        }

        private void btnPharmacies_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new Pharmacies());
        }
    }
}
