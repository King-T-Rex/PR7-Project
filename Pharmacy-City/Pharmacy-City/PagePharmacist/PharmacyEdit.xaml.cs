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
    /// Логика взаимодействия для PharmacyEdit.xaml
    /// </summary>
    public partial class PharmacyEdit : Page
    {
        private string NameTitle;
        public PharmacyEdit(Pharmacy pharmacy)
        {
            InitializeComponent();

            TxtName.Text = pharmacy.Title;
            NameTitle = pharmacy.Title;

            ListPharmacy.ItemsSource = OdbConnectHelper.entOdj.Pharmacy.Where(x => x.IDPharmacy == pharmacy.IDPharmacy).ToList();
            ListPharmacy.SelectedIndex = 0;
            ListPharmacy.Columns[0].IsReadOnly = true;
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.GoBack();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            OdbConnectHelper.entOdj.SaveChanges();
            MessageBox.Show(
                "Данные успешно изменены у аптеки " + NameTitle + "!",
                "Уведомление",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
        }
    }
}
