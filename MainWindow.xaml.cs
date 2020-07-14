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

        private static readonly string _connectionString = Configuration.ConnectionString;
        private static readonly Logger Logger =  NLogBuilder.ConfigureNLog("NLog.config").GetCurrentClassLogger();
        /// <summary>
        /// Krótka notatka
        /// </summary>
        /// <remarks>
        /// Dłuższe opisanie 
        /// </remarks>
        public MainWindow()
        {
            InitializeComponent();
            startclock();
            MessageBox.Show(Application.Current.MainWindow, "Aplikacja, którą będzisz używał/używała jest w wersji testowej. Wszelkie informacje oraz uwagi proszę zgłaszać do:       Grzegorz Lib   email: glib@borgwarner.com", "Informacja", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.Cancel);
            
        }
        /// <summary>
        /// 
        /// </summary>
        private void startclock()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += tickevent;
            timer.Start();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tickevent(object sender, EventArgs e)
        {
            datelbl.Text = DateTime.Now.ToString();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender">
        /// Sender - określa obiekt który wywołał dany event 
        /// </param>
        /// <param name="e">
        /// Zawiera informacje o stanie i dane zdarzenia powiazane ze zdarzeniem kierowanym.
        /// </param>
        /// 
        /// <remarks>
        /// Przycisk pobierający dane o aktualnej produkcji
        /// </remarks>

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var dashboard = new current_production();
            dashboard.Show();

           
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender">
        /// Sender - określa obiekt który wywołał dany event 
        /// </param>
        /// <param name="e">
        /// Zawiera informacje o stanie i dane zdarzenia powiazane ze zdarzeniem kierowanym.
        /// </param>
        /// 
        /// <remarks>
        /// DPrzycisk pobierające dane o zalogowanych operatorach
        /// </remarks>
        private void Button_person(object sender, RoutedEventArgs e)
        {
            var dashboard = new zalogowani_operatorzy();
            dashboard.Show();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender">
        /// Sender - określa obiekt który wywołał dany event 
        /// </param>
        /// <param name="e">
        /// Zawiera informacje o stanie i dane zdarzenia powiazane ze zdarzeniem kierowanym.
        /// </param>
        /// 
        /// <remarks>
        /// Przycisk testu połączenia 
        /// </remarks>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender">
        /// Sender - określa obiekt który wywołał dany event 
        /// </param>
        /// <param name="e">
        /// Zawiera informacje o stanie i dane zdarzenia powiazane ze zdarzeniem kierowanym.
        /// </param>
        /// 
        /// <remarks>
        /// Przycisk pobrania raportu zmianowego
        /// </remarks>
        private void download_raport(object sender, RoutedEventArgs e)
        {
            var dashboard3 = new raport();
            dashboard3.Show();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender">
        /// Sender - określa obiekt który wywołał dany event 
        /// </param>
        /// <param name="e">
        /// Zawiera informacje o stanie i dane zdarzenia powiazane ze zdarzeniem kierowanym.
        /// </param>
        /// 
        /// <remarks>
        /// Przycisk pobrania statusu o rdzeniu/turbosprężarce 
        /// </remarks>
        private void check_status(object sender, RoutedEventArgs e)
        {
            var status_dmc = new status_dmc();
            status_dmc.Show();
        }

        private void login_nr(object sender, RoutedEventArgs e)
        {
            var Numer_Pracowniczy = new Numer_Pracowniczy();
            Numer_Pracowniczy.Show();
        }
    }
}
