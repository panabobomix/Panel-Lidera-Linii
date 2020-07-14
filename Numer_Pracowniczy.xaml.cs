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

namespace Panel_Lidera_Linii
{
    /// <summary>
    /// Logika interakcji dla klasy Numer_Pracowniczy.xaml
    /// </summary>
    public partial class Numer_Pracowniczy : Window
    {
        public Numer_Pracowniczy()
        {
            InitializeComponent();
        }

        private void zatwierdz(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Numer został zatwierdzony");
        }
    }
}
