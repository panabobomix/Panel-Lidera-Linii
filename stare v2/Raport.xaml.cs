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
using System.Timers;
using System.Windows.Threading;


namespace Panel_Lidera_Linii
{
    /// <summary>
    /// Logika interakcji dla klasy raport.xaml
    /// </summary>
    public partial class raport : Window
    {


        private static string connectionString =
              "Data Source=10.217.240.26;" +
                "Initial Catalog=turboPCSProduction;" +
                "Integrated Security=SSPI;Connection Timeout=90";
        SqlCommand cmd, cmd2;
        SqlDataAdapter adpt, adpt2;
        DataTable dt;
        SqlDataReader reader, reader2;

        private void raport_3(object sender, RoutedEventArgs e)
        {

            //Test Szczelności
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 10 tblHeaderData.MaterialNo, Count (DISTINCT tblDMC.DMC) as'pcs'" +
                    "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
                    "WHERE CAST(tblDMC.CreationDate AS TIME) BETWEEN '23:00' and '07:00'and tblDMC.CreationDate > GETDATE()-1 and tblHeaderData.InventoryNo = '111114' and (tblDMC.DMC like '20200%' OR tblDMC.DMC like '800511')" +
                    "group by tblHeaderData.MaterialNo order by MAX(tblDMC.CreationDate) DESC";
                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    Tsz_raport.ItemsSource = dt.DefaultView;
                }
                con.Close();
            }
            //C01

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 10 tblHeaderData.MaterialNo, Count (DISTINCT tblDMC.DMC) as'pcs'" +
                    "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
                    "WHERE CAST(tblDMC.CreationDate AS TIME) BETWEEN '23:00' and '07:00'and tblDMC.CreationDate > GETDATE()-1 and tblHeaderData.InventoryNo = '421050' and (tblDMC.DMC like '20200%' OR tblDMC.DMC like '800511')" +
                    "group by tblHeaderData.MaterialNo order by MAX(tblDMC.CreationDate) DESC";
                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    C01_raport.ItemsSource = dt.DefaultView;
                }
                con.Close();
            }

            //C02

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 10 tblHeaderData.MaterialNo, Count (DISTINCT tblDMC.DMC) as'pcs'" +
                    "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
                    "WHERE CAST(tblDMC.CreationDate AS TIME) BETWEEN '23:00' and '07:00'and tblDMC.CreationDate > GETDATE()-1 and tblHeaderData.InventoryNo = '421913' and (tblDMC.DMC like '20200%' OR tblDMC.DMC like '800511')" +
                    "group by tblHeaderData.MaterialNo order by MAX(tblDMC.CreationDate) DESC";
                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    C02_raport.ItemsSource = dt.DefaultView;
                }
                con.Close();
            }

            //C03
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 10 tblHeaderData.MaterialNo, Count (DISTINCT tblDMC.DMC) as'pcs'" +
                    "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
                    "WHERE CAST(tblDMC.CreationDate AS TIME) BETWEEN '23:00' and '07:00'and tblDMC.CreationDate > GETDATE()-1 and tblHeaderData.InventoryNo = '444444' and (tblDMC.DMC like '20200%' OR tblDMC.DMC like '800511')" +
                    "group by tblHeaderData.MaterialNo order by MAX(tblDMC.CreationDate) DESC";
                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    C03_raport.ItemsSource = dt.DefaultView;
                }
                con.Close();
            }
            //C04
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 10 tblHeaderData.MaterialNo, Count (DISTINCT tblDMC.DMC) as'pcs'" +
                    "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
                    "WHERE CAST(tblDMC.CreationDate AS TIME) BETWEEN '23:00' and '07:00'and tblDMC.CreationDate > GETDATE()-1 and tblHeaderData.InventoryNo = '421008' and (tblDMC.DMC like '20200%' OR tblDMC.DMC like '800511')" +
                    "group by tblHeaderData.MaterialNo order by MAX(tblDMC.CreationDate) DESC";
                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    C04_raport.ItemsSource = dt.DefaultView;
                }
                con.Close();
            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 10 tblHeaderData.MaterialNo, Count (DISTINCT tblDMC.DMC) as'pcs'" +
                    "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
                    "WHERE CAST(tblDMC.CreationDate AS TIME) BETWEEN '23:00' and '07:00'and tblDMC.CreationDate > GETDATE()-1 and tblHeaderData.InventoryNo = '421914' and (tblDMC.DMC like '20200%' OR tblDMC.DMC like '800511')" +
                    "group by tblHeaderData.MaterialNo order by MAX(tblDMC.CreationDate) DESC";
                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    B02_raport.ItemsSource = dt.DefaultView;
                }
                con.Close();
            }

            //T01
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 10 tblHeaderData.MaterialNo, Count (DISTINCT tblDMC.DMC) as'pcs'" +
                    "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
                    "WHERE CAST(tblDMC.CreationDate AS TIME) BETWEEN '23:00' and '07:00'and tblDMC.CreationDate > GETDATE()-1 and tblHeaderData.InventoryNo = '421052' and tblDMC.CodeAnalysisText = 'BidiProcess'" +
                    "group by tblHeaderData.MaterialNo order by MAX(tblDMC.CreationDate) DESC";
                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    T01_raport.ItemsSource = dt.DefaultView;
                }
                con.Close();
            }

            //T02
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 10 tblHeaderData.MaterialNo, Count (DISTINCT tblDMC.DMC) as'pcs'" +
                    "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
                    "WHERE CAST(tblDMC.CreationDate AS TIME) BETWEEN '23:00' and '07:00'and tblDMC.CreationDate > GETDATE()-1 and tblHeaderData.InventoryNo = '421978' and tblDMC.CodeAnalysisText = 'BidiProcess'" +
                    "group by tblHeaderData.MaterialNo order by MAX(tblDMC.CreationDate) DESC";
                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    T02_raport.ItemsSource = dt.DefaultView;
                }
                con.Close();
            }
            //T03
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 10 tblHeaderData.MaterialNo, Count (DISTINCT tblDMC.DMC) as'pcs'" +
                    "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
                    "WHERE CAST(tblDMC.CreationDate AS TIME) BETWEEN '23:00' and '07:00'and tblDMC.CreationDate > GETDATE()-1 and tblHeaderData.InventoryNo = '421022' and tblDMC.CodeAnalysisText = 'BidiProcess'" +
                    "group by tblHeaderData.MaterialNo order by MAX(tblDMC.CreationDate) DESC";
                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    T03_raport.ItemsSource = dt.DefaultView;
                }
                con.Close();
            }
            //T04
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 10 tblHeaderData.MaterialNo, Count (DISTINCT tblDMC.DMC) as'pcs'" +
                    "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
                    "WHERE CAST(tblDMC.CreationDate AS TIME) BETWEEN '23:00' and '07:00'and tblDMC.CreationDate > GETDATE()-1 and tblHeaderData.InventoryNo = '422261' and tblDMC.CodeAnalysisText = 'BidiProcess'" +
                    "group by tblHeaderData.MaterialNo order by MAX(tblDMC.CreationDate) DESC";
                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    T04_raport.ItemsSource = dt.DefaultView;
                }
                con.Close();
            }
            //T05
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 10 tblHeaderData.MaterialNo, Count (DISTINCT tblDMC.DMC) as'pcs'" +
                    "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
                    "WHERE CAST(tblDMC.CreationDate AS TIME) BETWEEN '23:00' and '07:00'and tblDMC.CreationDate > GETDATE()-1 and tblHeaderData.InventoryNo = '4211791' and tblDMC.CodeAnalysisText = 'BidiProcess'" +
                    "group by tblHeaderData.MaterialNo order by MAX(tblDMC.CreationDate) DESC";
                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    T05_raport.ItemsSource = dt.DefaultView;
                }
                con.Close();
            }
            //T06
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 10 tblHeaderData.MaterialNo, Count (DISTINCT tblDMC.DMC) as'pcs'" +
                    "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
                    "WHERE CAST(tblDMC.CreationDate AS TIME) BETWEEN '23:00' and '07:00'and tblDMC.CreationDate > GETDATE()-1 and tblHeaderData.InventoryNo = '421998' and tblDMC.CodeAnalysisText = 'BidiProcess'" +
                    "group by tblHeaderData.MaterialNo order by MAX(tblDMC.CreationDate) DESC";
                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    T06_raport.ItemsSource = dt.DefaultView;
                }
                con.Close();
            }
        }

        private void raport_2(object sender, RoutedEventArgs e)
        {



            //Test Szczelności
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 10 tblHeaderData.MaterialNo, Count (DISTINCT tblDMC.DMC) as'pcs'" +
                    "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
                    "WHERE CAST(tblDMC.CreationDate AS TIME) BETWEEN '15:00' and '23:00'and tblDMC.CreationDate > GETDATE()-1 and tblHeaderData.InventoryNo = '111114' and (tblDMC.DMC like '20200%' OR tblDMC.DMC like '800511')" +
                    "group by tblHeaderData.MaterialNo order by MAX(tblDMC.CreationDate) DESC";
                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    Tsz_raport.ItemsSource = dt.DefaultView;
                }
                con.Close();
            }
            //C01

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 10 tblHeaderData.MaterialNo, Count (DISTINCT tblDMC.DMC) as'pcs'" +
                    "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
                    "WHERE CAST(tblDMC.CreationDate AS TIME) BETWEEN '15:00' and '23:00'and tblDMC.CreationDate > GETDATE()-1 and tblHeaderData.InventoryNo = '421050' and (tblDMC.DMC like '20200%' OR tblDMC.DMC like '800511')" +
                    "group by tblHeaderData.MaterialNo order by MAX(tblDMC.CreationDate) DESC";
                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    C01_raport.ItemsSource = dt.DefaultView;
                }
                con.Close();
            }

            //C02

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 10 tblHeaderData.MaterialNo, Count (DISTINCT tblDMC.DMC) as'pcs'" +
                    "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
                    "WHERE CAST(tblDMC.CreationDate AS TIME) BETWEEN '15:00' and '23:00'and tblDMC.CreationDate > GETDATE()-1 and tblHeaderData.InventoryNo = '421913' and (tblDMC.DMC like '20200%' OR tblDMC.DMC like '800511')" +
                    "group by tblHeaderData.MaterialNo order by MAX(tblDMC.CreationDate) DESC";
                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    C02_raport.ItemsSource = dt.DefaultView;
                }
                con.Close();
            }

            //C03
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 10 tblHeaderData.MaterialNo, Count (DISTINCT tblDMC.DMC) as'pcs'" +
                    "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
                    "WHERE CAST(tblDMC.CreationDate AS TIME) BETWEEN '15:00' and '23:00'and tblDMC.CreationDate > GETDATE()-1 and tblHeaderData.InventoryNo = '444444' and (tblDMC.DMC like '20200%' OR tblDMC.DMC like '800511')" +
                    "group by tblHeaderData.MaterialNo order by MAX(tblDMC.CreationDate) DESC";
                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    C03_raport.ItemsSource = dt.DefaultView;
                }
                con.Close();
            }
            //C04
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 10 tblHeaderData.MaterialNo, Count (DISTINCT tblDMC.DMC) as'pcs'" +
                    "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
                    "WHERE CAST(tblDMC.CreationDate AS TIME) BETWEEN '15:00' and '23:00'and tblDMC.CreationDate > GETDATE()-1 and tblHeaderData.InventoryNo = '421008' and (tblDMC.DMC like '20200%' OR tblDMC.DMC like '800511')" +
                    "group by tblHeaderData.MaterialNo order by MAX(tblDMC.CreationDate) DESC";
                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    C04_raport.ItemsSource = dt.DefaultView;
                }
                con.Close();
            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 10 tblHeaderData.MaterialNo, Count (DISTINCT tblDMC.DMC) as'pcs'" +
                    "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
                    "WHERE CAST(tblDMC.CreationDate AS TIME) BETWEEN '15:00' and '23:00'and tblDMC.CreationDate > GETDATE()-1 and tblHeaderData.InventoryNo = '421914' and (tblDMC.DMC like '20200%' OR tblDMC.DMC like '800511')" +
                    "group by tblHeaderData.MaterialNo order by MAX(tblDMC.CreationDate) DESC";
                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    B02_raport.ItemsSource = dt.DefaultView;
                }
                con.Close();
            }

            //T01
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 10 tblHeaderData.MaterialNo, Count (DISTINCT tblDMC.DMC) as'pcs'" +
                    "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
                    "WHERE CAST(tblDMC.CreationDate AS TIME) BETWEEN '15:00' and '23:00'and tblDMC.CreationDate > GETDATE()-1 and tblHeaderData.InventoryNo = '421052' and tblDMC.CodeAnalysisText = 'BidiProcess'" +
                    "group by tblHeaderData.MaterialNo order by MAX(tblDMC.CreationDate) DESC";
                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    T01_raport.ItemsSource = dt.DefaultView;
                }
                con.Close();
            }

            //T02
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 10 tblHeaderData.MaterialNo, Count (DISTINCT tblDMC.DMC) as'pcs'" +
                    "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
                    "WHERE CAST(tblDMC.CreationDate AS TIME) BETWEEN '15:00' and '23:00'and tblDMC.CreationDate > GETDATE()-1 and tblHeaderData.InventoryNo = '421978' and tblDMC.CodeAnalysisText = 'BidiProcess'" +
                    "group by tblHeaderData.MaterialNo order by MAX(tblDMC.CreationDate) DESC";
                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    T02_raport.ItemsSource = dt.DefaultView;
                }
                con.Close();
            }
            //T03
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 10 tblHeaderData.MaterialNo, Count (DISTINCT tblDMC.DMC) as'pcs'" +
                    "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
                    "WHERE CAST(tblDMC.CreationDate AS TIME) BETWEEN '15:00' and '23:00'and tblDMC.CreationDate > GETDATE()-1 and tblHeaderData.InventoryNo = '421022' and tblDMC.CodeAnalysisText = 'BidiProcess'" +
                    "group by tblHeaderData.MaterialNo order by MAX(tblDMC.CreationDate) DESC";
                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    T03_raport.ItemsSource = dt.DefaultView;
                }
                con.Close();
            }
            //T04
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 10 tblHeaderData.MaterialNo, Count (DISTINCT tblDMC.DMC) as'pcs'" +
                    "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
                    "WHERE CAST(tblDMC.CreationDate AS TIME) BETWEEN '15:00' and '23:00'and tblDMC.CreationDate > GETDATE()-1 and tblHeaderData.InventoryNo = '422261' and tblDMC.CodeAnalysisText = 'BidiProcess'" +
                    "group by tblHeaderData.MaterialNo order by MAX(tblDMC.CreationDate) DESC";
                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    T04_raport.ItemsSource = dt.DefaultView;
                }
                con.Close();
            }
            //T05
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 10 tblHeaderData.MaterialNo, Count (DISTINCT tblDMC.DMC) as'pcs'" +
                    "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
                    "WHERE CAST(tblDMC.CreationDate AS TIME) BETWEEN '15:00' and '23:00'and tblDMC.CreationDate > GETDATE()-1 and tblHeaderData.InventoryNo = '4211791' and tblDMC.CodeAnalysisText = 'BidiProcess'" +
                    "group by tblHeaderData.MaterialNo order by MAX(tblDMC.CreationDate) DESC";
                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    T05_raport.ItemsSource = dt.DefaultView;
                }
                con.Close();
            }
            //T06
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 10 tblHeaderData.MaterialNo, Count (DISTINCT tblDMC.DMC) as'pcs'" +
                    "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
                    "WHERE CAST(tblDMC.CreationDate AS TIME) BETWEEN '15:00' and '23:00'and tblDMC.CreationDate > GETDATE()-1 and tblHeaderData.InventoryNo = '421998' and tblDMC.CodeAnalysisText = 'BidiProcess'" +
                    "group by tblHeaderData.MaterialNo order by MAX(tblDMC.CreationDate) DESC";
                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    T06_raport.ItemsSource = dt.DefaultView;
                }
                con.Close();
            }
        }

        public raport()
        {
            InitializeComponent();
        }

        private void raport_1(object sender, RoutedEventArgs e)
        {
            //Test Szczelności
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 10 tblHeaderData.MaterialNo, Count (DISTINCT tblDMC.DMC) as'pcs'" +
                    "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
                    "WHERE CAST(tblDMC.CreationDate AS TIME) BETWEEN '07:00' and '15:00'and tblDMC.CreationDate > GETDATE()-1 and tblHeaderData.InventoryNo = '111114' and (tblDMC.DMC like '20200%' OR tblDMC.DMC like '800511')" +
                    "group by tblHeaderData.MaterialNo order by MAX(tblDMC.CreationDate) DESC";
                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    Tsz_raport.ItemsSource = dt.DefaultView;
                }
                con.Close();
            }


            //C01

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 10 tblHeaderData.MaterialNo, Count (DISTINCT tblDMC.DMC) as'pcs'" +
                    "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
                    "WHERE CAST(tblDMC.CreationDate AS TIME) BETWEEN '07:00' and '15:00'and tblDMC.CreationDate > GETDATE()-1 and tblHeaderData.InventoryNo = '421050' and (tblDMC.DMC like '20200%' OR tblDMC.DMC like '800511')" +
                    "group by tblHeaderData.MaterialNo order by MAX(tblDMC.CreationDate) DESC";
                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    C01_raport.ItemsSource = dt.DefaultView;
                }
                con.Close();
            }

            //C02

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 10 tblHeaderData.MaterialNo, Count (DISTINCT tblDMC.DMC) as'pcs'" +
                    "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
                    "WHERE CAST(tblDMC.CreationDate AS TIME) BETWEEN '07:00' and '15:00'and tblDMC.CreationDate > GETDATE()-1 and tblHeaderData.InventoryNo = '421913' and (tblDMC.DMC like '20200%' OR tblDMC.DMC like '800511')" +
                    "group by tblHeaderData.MaterialNo order by MAX(tblDMC.CreationDate) DESC";
                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    C02_raport.ItemsSource = dt.DefaultView;
                }
                con.Close();
            }

            //C03
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 10 tblHeaderData.MaterialNo, Count (DISTINCT tblDMC.DMC) as'pcs'" +
                    "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
                    "WHERE CAST(tblDMC.CreationDate AS TIME) BETWEEN '07:00' and '15:00'and tblDMC.CreationDate > GETDATE()-1 and tblHeaderData.InventoryNo = '444444' and (tblDMC.DMC like '20200%' OR tblDMC.DMC like '800511')" +
                    "group by tblHeaderData.MaterialNo order by MAX(tblDMC.CreationDate) DESC";
                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    C03_raport.ItemsSource = dt.DefaultView;
                }
                con.Close();
            }
            //C04
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 10 tblHeaderData.MaterialNo, Count (DISTINCT tblDMC.DMC) as'pcs'" +
                    "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
                    "WHERE CAST(tblDMC.CreationDate AS TIME) BETWEEN '07:00' and '15:00'and tblDMC.CreationDate > GETDATE()-1 and tblHeaderData.InventoryNo = '421008' and (tblDMC.DMC like '20200%' OR tblDMC.DMC like '800511')" +
                    "group by tblHeaderData.MaterialNo order by MAX(tblDMC.CreationDate) DESC";
                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    C04_raport.ItemsSource = dt.DefaultView;
                }
                con.Close();
            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 10 tblHeaderData.MaterialNo, Count (DISTINCT tblDMC.DMC) as'pcs'" +
                    "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
                    "WHERE CAST(tblDMC.CreationDate AS TIME) BETWEEN '07:00' and '15:00'and tblDMC.CreationDate > GETDATE()-1 and tblHeaderData.InventoryNo = '421914' and (tblDMC.DMC like '20200%' OR tblDMC.DMC like '800511')" +
                    "group by tblHeaderData.MaterialNo order by MAX(tblDMC.CreationDate) DESC";
                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    B02_raport.ItemsSource = dt.DefaultView;
                }
                con.Close();
            }

            //T01
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 10 tblHeaderData.MaterialNo, Count (DISTINCT tblDMC.DMC) as'pcs'" +
                    "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
                    "WHERE CAST(tblDMC.CreationDate AS TIME) BETWEEN '07:00' and '15:00'and tblDMC.CreationDate > GETDATE()-1 and tblHeaderData.InventoryNo = '421052' and tblDMC.CodeAnalysisText = 'BidiProcess'" +
                    "group by tblHeaderData.MaterialNo order by MAX(tblDMC.CreationDate) DESC";
                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    T01_raport.ItemsSource = dt.DefaultView;
                }
                con.Close();
            }

            //T02
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 10 tblHeaderData.MaterialNo, Count (DISTINCT tblDMC.DMC) as'pcs'" +
                    "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
                    "WHERE CAST(tblDMC.CreationDate AS TIME) BETWEEN '07:00' and '15:00'and tblDMC.CreationDate > GETDATE()-1 and tblHeaderData.InventoryNo = '421978' and tblDMC.CodeAnalysisText = 'BidiProcess'" +
                    "group by tblHeaderData.MaterialNo order by MAX(tblDMC.CreationDate) DESC";
                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    T02_raport.ItemsSource = dt.DefaultView;
                }
                con.Close();
            }
            //T03
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 10 tblHeaderData.MaterialNo, Count (DISTINCT tblDMC.DMC) as'pcs'" +
                    "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
                    "WHERE CAST(tblDMC.CreationDate AS TIME) BETWEEN '07:00' and '15:00'and tblDMC.CreationDate > GETDATE()-1 and tblHeaderData.InventoryNo = '421022' and tblDMC.CodeAnalysisText = 'BidiProcess'" +
                    "group by tblHeaderData.MaterialNo order by MAX(tblDMC.CreationDate) DESC";
                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    T03_raport.ItemsSource = dt.DefaultView;
                }
                con.Close();
            }
            //T04
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 10 tblHeaderData.MaterialNo, Count (DISTINCT tblDMC.DMC) as'pcs'" +
                    "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
                    "WHERE CAST(tblDMC.CreationDate AS TIME) BETWEEN '07:00' and '15:00'and tblDMC.CreationDate > GETDATE()-1 and tblHeaderData.InventoryNo = '422261' and tblDMC.CodeAnalysisText = 'BidiProcess'" +
                    "group by tblHeaderData.MaterialNo order by MAX(tblDMC.CreationDate) DESC";
                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    T04_raport.ItemsSource = dt.DefaultView;
                }
                con.Close();
            }
            //T05
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 10 tblHeaderData.MaterialNo, Count (DISTINCT tblDMC.DMC) as'pcs'" +
                    "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
                    "WHERE CAST(tblDMC.CreationDate AS TIME) BETWEEN '07:00' and '15:00'and tblDMC.CreationDate > GETDATE()-1 and tblHeaderData.InventoryNo = '4211791' and tblDMC.CodeAnalysisText = 'BidiProcess'" +
                    "group by tblHeaderData.MaterialNo order by MAX(tblDMC.CreationDate) DESC";
                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    T05_raport.ItemsSource = dt.DefaultView;
                }
                con.Close();
            }
            //T06
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 10 tblHeaderData.MaterialNo, Count (DISTINCT tblDMC.DMC) as'pcs'" +
                    "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
                    "WHERE CAST(tblDMC.CreationDate AS TIME) BETWEEN '07:00' and '15:00'and tblDMC.CreationDate > GETDATE()-1 and tblHeaderData.InventoryNo = '421998' and tblDMC.CodeAnalysisText = 'BidiProcess'" +
                    "group by tblHeaderData.MaterialNo order by MAX(tblDMC.CreationDate) DESC";
                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    T06_raport.ItemsSource = dt.DefaultView;
                }
                con.Close();
            }
        }
    }
}
