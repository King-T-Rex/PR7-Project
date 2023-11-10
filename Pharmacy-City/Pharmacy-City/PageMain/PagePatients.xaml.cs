using Pharmacy_City.DataFilesApp;
using Pharmacy_City.Patients;
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
using System.Xml.Linq;

namespace Pharmacy_City.PageMain
{
    /// <summary>
    /// Логика взаимодействия для PagePatients.xaml
    /// </summary>
    public partial class PagePatients : Page
    {
        public PagePatients()
        {
            InitializeComponent();
        }
        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageLogin());
        }

        private void btnViewPatient_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PatientDataExample());
        }
    }
}
