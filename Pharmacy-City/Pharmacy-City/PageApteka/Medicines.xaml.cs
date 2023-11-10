using Pharmacy_City.DataFilesApp;
using Pharmacy_City.PageApteka;
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

namespace Pharmacy_City.Apteka
{
    /// <summary>
    /// Логика взаимодействия для Medicines.xaml
    /// </summary>
    public partial class Medicines : Page
    {
        public Medicines()
        {
            InitializeComponent();

            MedicGrid.ItemsSource = OdbConnectHelper.entOdj.Medication.ToList();

        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageMain.PageApteka());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new AddMedic());
        }
    }
}
