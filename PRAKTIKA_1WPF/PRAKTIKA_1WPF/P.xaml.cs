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
    /// Логика взаимодействия для P.xaml
    /// </summary>
    public partial class P : Window
    {
        public string clos;
        ProdyktTableAdapter prodykt = new ProdyktTableAdapter();
        public P()
        {
            InitializeComponent();
            GridProd.ItemsSource = prodykt.GetData();

        }

        private void Creat_p_k_Click(object sender, RoutedEventArgs e)
        {
            int p_id = Convert.ToInt32(P_id.Text);
            int klient_id_= Convert.ToInt32(Klient_id.Text);
            prodykt.InsertQueryProd(p_id,klient_id_);
            GridProd.ItemsSource = prodykt.GetData();
        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            clos = "Закрыть";
            DialogResult = true;
        }
    }
}
