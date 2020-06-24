using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows;
using NLog;
using NLog.Web;
using Panel_Lidera_Linii.Helper;
using Panel_Lidera_Linii.Views;
using Configuration = Panel_Lidera_Linii.Helper.Configuration;
using System.Windows.Data;
using System.Windows.Threading;

namespace Panel_Lidera_Linii
{
    /// <summary>
    ///     Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
//tutaj zmieniasz nazwę tej sekcji w App.config - ja nazywam name="ConnectionString", ty na przykład name="ConnectionString-borg" wiec zmieniasz na ConnectionString-borg
        private static readonly string _connectionString = Configuration.ConnectionString;
        private static readonly Logger Logger =  NLogBuilder.ConfigureNLog("NLog.config").GetCurrentClassLogger();

        public MainWindow()
        {
            InitializeComponent();
            startclock();
        }

        private void startclock()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += tickevent;
            timer.Start();
        }
        private void tickevent(object sender, EventArgs e)
        {
            datelbl.Text = DateTime.Now.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var dashboard = new current_production();
            dashboard.Show();

            //iiri - po co ten loagind?
            // var dashboard2 = new loading();
            // dashboard2.Show();
        }

        private void Button_person(object sender, RoutedEventArgs e)
        {
            var dashboard = new zalogowani_operatorzy();
            dashboard.Show();
        }

        private void connect_test(object sender, RoutedEventArgs e)
        {
            var con = new SqlConnection();
            con.ConnectionString = _connectionString;
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
                catch (Exception ex)
                {
                    Logger.Fatal(ex);
                    MessageBox.Show(string.Format("[connect_test] Error: {0}", ex.Message));
                }
            }
        }


        private void download_raport(object sender, RoutedEventArgs e)
        {
            var dashboard3 = new raport();
            dashboard3.Show();
        }

        private void check_status(object sender, RoutedEventArgs e)
        {
            var status_dmc = new status_dmc();
            status_dmc.Show();
        }
    }
}
