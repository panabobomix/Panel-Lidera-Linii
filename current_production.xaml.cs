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
using System.Data;

namespace Panel_Lidera_Linii
{
    /// <summary>
    /// Logika interakcji dla klasy current_production.xaml
    /// </summary>
    public partial class current_production : Window


    {
        private static string connectionString =
                "Data Source=10.217.240.26;" +
                  "Initial Catalog=turboPCSProduction;" +
                  "Integrated Security=SSPI;";
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;

        public current_production()
        {
            InitializeComponent();
        }

        
        

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //ładowanie okna
            // deklaracja
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 1*  from tblHeaderData Where InventoryNo = '444444' Order by CreationDate DESC";
                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    C03.ItemsSource = dt.DefaultView;
                }
            }
        }

        private void Button_Click_C01(object sender, RoutedEventArgs e)
        {
            //ładowanie okna
            // deklaracja
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 1*  from tblHeaderData Where InventoryNo = '421050' Order by CreationDate DESC";
                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    C01.ItemsSource = dt.DefaultView;
                }
            }
        }

        private void Button_Click_c02(object sender, RoutedEventArgs e)
        {
            //ładowanie okna
            // deklaracja
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 1*  from tblHeaderData Where InventoryNo = '421913' Order by CreationDate DESC";
                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    C02.ItemsSource = dt.DefaultView;
                }
            }
        }

        private void Button_Click_c04(object sender, RoutedEventArgs e)
        {
            //ładowanie okna
            // deklaracja
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 1*  from tblHeaderData Where InventoryNo = '421008' Order by CreationDate DESC";
                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    C04.ItemsSource = dt.DefaultView;
                }
            }
        }

        private void Button_Click_T01(object sender, RoutedEventArgs e)
        {
            //ładowanie okna
            // deklaracja
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 1*  from tblHeaderData Where InventoryNo = '421052' Order by CreationDate DESC";
                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    T01.ItemsSource = dt.DefaultView;
                }
            }
        }

        private void Button_Click_T02(object sender, RoutedEventArgs e)
        {
            //ładowanie okna
            // deklaracja
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 1*  from tblHeaderData Where InventoryNo = '421975' Order by CreationDate DESC";
                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    T02.ItemsSource = dt.DefaultView;
                }
            }
        }

        private void Button_Click_T03(object sender, RoutedEventArgs e)
        {
            //ładowanie okna
            // deklaracja
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 1*  from tblHeaderData Where InventoryNo = '421022' Order by CreationDate DESC";
                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    T03.ItemsSource = dt.DefaultView;
                }
            }
        }

        private void Button_Click_T04(object sender, RoutedEventArgs e)
        {
            //ładowanie okna
            // deklaracja
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 1*  from tblHeaderData Where InventoryNo = '422261' Order by CreationDate DESC";
                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    T04.ItemsSource = dt.DefaultView;
                }
            }
        }

        private void Button_Click_T05(object sender, RoutedEventArgs e)
        {
            //ładowanie okna
            // deklaracja
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 1*  from tblHeaderData Where InventoryNo = '4211791' Order by CreationDate DESC";
                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    T05.ItemsSource = dt.DefaultView;
                }
            }
        }

        private void Button_Click_T06(object sender, RoutedEventArgs e)
        {
            //ładowanie okna
            // deklaracja
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 1*  from tblHeaderData Where InventoryNo = '421998' Order by CreationDate DESC";
                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    T06.ItemsSource = dt.DefaultView;
                }
            }
        }
    }
}
