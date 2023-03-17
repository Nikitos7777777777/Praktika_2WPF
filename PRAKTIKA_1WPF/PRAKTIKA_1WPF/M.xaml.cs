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
using System.Windows.Shapes;
using PRAKTIKA_1WPF.megezDataSet1TableAdapters;

namespace PRAKTIKA_1WPF
{
    /// <summary>
    /// Логика взаимодействия для M.xaml
    /// </summary>
    public partial class M : Window
    {
        public string close;
        ProizvoditeTableAdapter Proizvodit = new ProizvoditeTableAdapter();

        public M()
        {
            InitializeComponent();
            GridP.ItemsSource = Proizvodit.GetData();

        }
        private void Close_Click(object sender, RoutedEventArgs e)
        {
            close = "Закрыть";
            DialogResult = true;
        }

        private void CreatP_Click(object sender, RoutedEventArgs e)
        {
            Proizvodit.InsertQueryP(Adres.Text, Munifaktyr.Text);
            GridP.ItemsSource = Proizvodit.GetData();
        }
    }
}
