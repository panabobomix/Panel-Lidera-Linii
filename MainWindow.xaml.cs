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
using System.Data.SqlClient;
using System.Data;
namespace Panel_Lidera_Linii
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            current_production dashboard = new current_production();
            dashboard.Show();
            loading dashboard2 = new loading();
            dashboard2.Show();

        }

        private void Button_person(object sender, RoutedEventArgs e)
        {
            zalogowani_operatorzy dashboard = new zalogowani_operatorzy ();
            dashboard.Show();
        }

        private void connect_test(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString =
                  "Data Source=10.217.240.26;" +
                  "Initial Catalog=turboPCSProduction;" +
                  "Integrated Security=SSPI;";
            {
                try
                {
                    con.Open();
                    MessageBox.Show("Połączenie nawiazane :)");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Połączenie nie nawiązane :(");
                }
            }
        }

        

        private void download_raport(object sender, RoutedEventArgs e)
        {
            raport dashboard3 = new raport();
            dashboard3.Show();
        }
    }
}
