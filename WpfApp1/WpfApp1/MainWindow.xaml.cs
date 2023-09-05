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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


        }

        private void btnSzamol_Click(object sender, RoutedEventArgs e)
        {
            int kbps = 0;
            int bp =0;

            if (cmbKapacitas.SelectedItem.ToString() == "Mb")
            {
                kbps= int.Parse(txtKapacitas.Text)*1000;
            }

            else if (cmbKapacitas.SelectedItem.ToString() == "Gb") 
            {
                kbps = int.Parse(txtKapacitas.Text) * 1000000;
            }

            else if (cmbKapacitas.SelectedItem.ToString() == "Tb")
            {
                kbps = int.Parse(txtKapacitas.Text) * 1000000000;
            }
            MessageBox.Show(kbps.ToString());

            if (cmbAtviteli.SelectedItem.ToString() == "KBps")
            {
                bp = (int)(sliAtviteliseb.Value * 1000000);
            }

            else if (cmbAtviteli.SelectedItem.ToString() == "MBps")
            {
                bp = (int)(sliAtviteliseb.Value * 1000000000);
            }
            else if (cmbAtviteli.SelectedItem.ToString() == "GBps") 
            {
                bp = (int)(sliAtviteliseb.Value * 1000000000000);
            }

            eredmeny.Content = "Az átvitel sebessége" + (bp/kbps/10)+"másodperc" ;

        }
    }
}
