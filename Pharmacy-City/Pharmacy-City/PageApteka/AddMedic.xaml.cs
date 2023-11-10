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
    /// Логика взаимодействия для AddMedic.xaml
    /// </summary>
    public partial class AddMedic : Page
    {
        public AddMedic()
        {
            InitializeComponent();
        }

        private void BtnAddMedic_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Medication MedObj = new Medication()
                {
                    NameMedic = TxbTitleMedic.Text,
                    GroupMedic = TxbGroup.Text,
                    Dosage = TxbDos.Text,
                    ExpirationDate = Int32.Parse(TxbSrok.Text)
                };


                OdbConnectHelper.entOdj.Medication.Add(MedObj);
                OdbConnectHelper.entOdj.SaveChanges();

                MessageBox.Show(
                    "Препарат " + MedObj.NameMedic + " успешно добавлена!",
                    "Уведомление",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information
                    );
                FrameApp.frmObj.Navigate(new Medicines());

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
