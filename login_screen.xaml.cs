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
using System.Data.SqlClient;
using NLog;
using Panel_Lidera_Linii.Helper;

namespace Panel_Lidera_Linii
{
    /// <summary>
    /// Logika interakcji dla klasy login_screen.xaml
    /// </summary>
    public partial class login_screen : Window
    {
        protected readonly Logger Logger = LogManager.GetCurrentClassLogger();
        private static string _connectionString = Configuration.ConnectionString;
        public login_screen()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            // LOKALNA BAZA ZMIENIC NA POŁĄCZNIE NP Z BAZA BW
            SqlConnection sqlCon = new SqlConnection(_connectionString); // localdb lub localhost
            try
            {
                if (sqlCon.State == System.Data.ConnectionState.Closed)
                    sqlCon.Open();
                String query = "SELECT COUNT(1) FROM tblUser WHERE Username=@Username AND Password=@Password";
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                sqlCmd.CommandType = System.Data.CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                sqlCmd.Parameters.AddWithValue("@Password", txtPassword.Password);
                int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
                if (count == 1)
                {
                    MainWindow dashboard = new MainWindow();
                    dashboard.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Hasło lub login są niepoprawne!");
                }
            }
            catch (Exception ex)
            {
                Logger.Fatal(ex);
            }
            finally
            {

            }
        }
    }
}
