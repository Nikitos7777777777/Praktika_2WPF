using System;
using System.Collections.Generic;
using System.Data;
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
using PRAKTIKA_1WPF.megezDataSet1TableAdapters;

namespace PRAKTIKA_1WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
     
        KlientTableAdapter Klient = new KlientTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
            KlientDataGrid.ItemsSource = Klient.GetData();
        }

        private void CreatButton_Click(object sender, RoutedEventArgs e)
        {
            Klient.InsertQuery(NameBox.Text, SurnameBox.Text);
            KlientDataGrid.ItemsSource = Klient.GetData();
        }

        private void Perexod_P_Click(object sender, RoutedEventArgs e)
        {
            M windoeP = new M();
            windoeP.ShowDialog();

        }

        private void Prodykt_Click(object sender, RoutedEventArgs e)
        {
            P wind = new P();
            wind.ShowDialog();
        }
    }
}
