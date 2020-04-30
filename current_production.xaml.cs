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
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(30);
            timer.Tick += timer_Tick;
            timer.Start();
            
        }


        //TESTY!!!


        void timer_Tick(object sender, EventArgs e)
        {
           
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

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select top 1 CreationDate, DATEDIFF (MINUTE, CreationDate , getdate()) as 'time' from tblHeaderData where InventoryNo ='421050'order by CreationDate DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    last_c01.ItemsSource = dt.DefaultView;
                }
            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select top 1 CreationDate, DATEDIFF (MINUTE, CreationDate , getdate()) as 'time' from tblHeaderData where InventoryNo ='421913'order by CreationDate DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    last_c02.ItemsSource = dt.DefaultView;
                }
            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select top 1 CreationDate, DATEDIFF (MINUTE, CreationDate , getdate()) as 'time' from tblHeaderData where InventoryNo ='444444'order by CreationDate DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    last_c03.ItemsSource = dt.DefaultView;
                }
            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select top 1 CreationDate, DATEDIFF (MINUTE, CreationDate , getdate()) as 'time' from tblHeaderData where InventoryNo ='421008'order by CreationDate DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    last_c04.ItemsSource = dt.DefaultView;
                }
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select top 1 CreationDate, DATEDIFF (MINUTE, CreationDate , getdate()) as 'time' from tblHeaderData where InventoryNo ='421052'order by CreationDate DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    last_t01.ItemsSource = dt.DefaultView;
                }
            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select top 1 CreationDate, DATEDIFF (MINUTE, CreationDate , getdate()) as 'time' from tblHeaderData where InventoryNo ='421975'order by CreationDate DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    last_t02.ItemsSource = dt.DefaultView;
                }
            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select top 1 CreationDate, DATEDIFF (MINUTE, CreationDate , getdate()) as 'time' from tblHeaderData where InventoryNo ='421022'order by CreationDate DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    last_t03.ItemsSource = dt.DefaultView;
                }
            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select top 1 CreationDate, DATEDIFF (MINUTE, CreationDate , getdate()) as 'time' from tblHeaderData where InventoryNo ='422261'order by CreationDate DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    last_t04.ItemsSource = dt.DefaultView;
                }
            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select top 1 CreationDate, DATEDIFF (MINUTE, CreationDate , getdate()) as 'time' from tblHeaderData where InventoryNo ='4211791'order by CreationDate DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    last_t05.ItemsSource = dt.DefaultView;
                }
            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select top 1 CreationDate, DATEDIFF (MINUTE, CreationDate , getdate()) as 'time' from tblHeaderData where InventoryNo ='421998'order by CreationDate DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    last_t06.ItemsSource = dt.DefaultView;
                }
            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "SELECT count(*) as hours FROM tblHeaderData WHERE CreationDate >= dateadd(hour, datediff(hour, 0, GETDATE()), 0) and InventoryNo ='444444'";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    hours_c03.ItemsSource = dt.DefaultView;
                }
            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "SELECT count(*) as hours FROM tblHeaderData WHERE CreationDate >= dateadd(hour, datediff(hour, 0, GETDATE()), 0) and InventoryNo ='421050'";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    hours_c01.ItemsSource = dt.DefaultView;
                }
            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "SELECT count(*) as hours FROM tblHeaderData WHERE CreationDate >= dateadd(hour, datediff(hour, 0, GETDATE()), 0) and InventoryNo ='421913'";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    hours_c02.ItemsSource = dt.DefaultView;
                }
            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "SELECT count(*) as hours FROM tblHeaderData WHERE CreationDate >= dateadd(hour, datediff(hour, 0, GETDATE()), 0) and InventoryNo ='421008'";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    hours_c04.ItemsSource = dt.DefaultView;
                }
            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "SELECT count(*) as hours FROM tblHeaderData WHERE CreationDate >= dateadd(hour, datediff(hour, 0, GETDATE()), 0) and InventoryNo ='421052'";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    hours_t01.ItemsSource = dt.DefaultView;
                }
            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "SELECT count(*) as hours FROM tblHeaderData WHERE CreationDate >= dateadd(hour, datediff(hour, 0, GETDATE()), 0) and InventoryNo ='421975'";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    hours_t02.ItemsSource = dt.DefaultView;
                }
            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "SELECT count(*) as hours FROM tblHeaderData WHERE CreationDate >= dateadd(hour, datediff(hour, 0, GETDATE()), 0) and InventoryNo ='421022'";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    hours_t03.ItemsSource = dt.DefaultView;
                }
            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "SELECT count(*) as hours FROM tblHeaderData WHERE CreationDate >= dateadd(hour, datediff(hour, 0, GETDATE()), 0) and InventoryNo ='422261'";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    hours_t04.ItemsSource = dt.DefaultView;
                }
            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "SELECT count(*) as hours FROM tblHeaderData WHERE CreationDate >= dateadd(hour, datediff(hour, 0, GETDATE()), 0) and InventoryNo ='4211791'";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    hours_t05.ItemsSource = dt.DefaultView;
                }
            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "SELECT count(*) as hours FROM tblHeaderData WHERE CreationDate >= dateadd(hour, datediff(hour, 0, GETDATE()), 0) and InventoryNo ='421998'";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    hours_t06.ItemsSource = dt.DefaultView;
                }
            }

        }



        //TESTY~!!!!!


        /*

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
        */



       






        private void download_all(object sender, RoutedEventArgs e)
        {
           
            
              

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

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select top 1 CreationDate, DATEDIFF (MINUTE, CreationDate , getdate()) as 'time' from tblHeaderData where InventoryNo ='421050'order by CreationDate DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    last_c01.ItemsSource = dt.DefaultView;
                }
            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select top 1 CreationDate, DATEDIFF (MINUTE, CreationDate , getdate()) as 'time' from tblHeaderData where InventoryNo ='421913'order by CreationDate DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    last_c02.ItemsSource = dt.DefaultView;
                }
            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select top 1 CreationDate, DATEDIFF (MINUTE, CreationDate , getdate()) as 'time' from tblHeaderData where InventoryNo ='444444'order by CreationDate DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    last_c03.ItemsSource = dt.DefaultView;
                }
            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select top 1 CreationDate, DATEDIFF (MINUTE, CreationDate , getdate()) as 'time' from tblHeaderData where InventoryNo ='421008'order by CreationDate DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    last_c04.ItemsSource = dt.DefaultView;
                }
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select top 1 CreationDate, DATEDIFF (MINUTE, CreationDate , getdate()) as 'time' from tblHeaderData where InventoryNo ='421052'order by CreationDate DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    last_t01.ItemsSource = dt.DefaultView;
                }
            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select top 1 CreationDate, DATEDIFF (MINUTE, CreationDate , getdate()) as 'time' from tblHeaderData where InventoryNo ='421975'order by CreationDate DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    last_t02.ItemsSource = dt.DefaultView;
                }
            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select top 1 CreationDate, DATEDIFF (MINUTE, CreationDate , getdate()) as 'time' from tblHeaderData where InventoryNo ='421022'order by CreationDate DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    last_t03.ItemsSource = dt.DefaultView;
                }
            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select top 1 CreationDate, DATEDIFF (MINUTE, CreationDate , getdate()) as 'time' from tblHeaderData where InventoryNo ='422261'order by CreationDate DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    last_t04.ItemsSource = dt.DefaultView;
                }
            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select top 1 CreationDate, DATEDIFF (MINUTE, CreationDate , getdate()) as 'time' from tblHeaderData where InventoryNo ='4211791'order by CreationDate DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    last_t05.ItemsSource = dt.DefaultView;
                }
            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select top 1 CreationDate, DATEDIFF (MINUTE, CreationDate , getdate()) as 'time' from tblHeaderData where InventoryNo ='421998'order by CreationDate DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    last_t06.ItemsSource = dt.DefaultView;
                }
            }



            /// ilość sztuk w ostatniej godzinie///
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "SELECT count(*) as hours FROM tblHeaderData WHERE CreationDate >= dateadd(hour, datediff(hour, 0, GETDATE()), 0) and InventoryNo ='444444'";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    hours_c03.ItemsSource = dt.DefaultView;
                }
            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "SELECT count(*) as hours FROM tblHeaderData WHERE CreationDate >= dateadd(hour, datediff(hour, 0, GETDATE()), 0) and InventoryNo ='421050'";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    hours_c01.ItemsSource = dt.DefaultView;
                }
            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "SELECT count(*) as hours FROM tblHeaderData WHERE CreationDate >= dateadd(hour, datediff(hour, 0, GETDATE()), 0) and InventoryNo ='421913'";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    hours_c02.ItemsSource = dt.DefaultView;
                }
            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "SELECT count(*) as hours FROM tblHeaderData WHERE CreationDate >= dateadd(hour, datediff(hour, 0, GETDATE()), 0) and InventoryNo ='421008'";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    hours_c04.ItemsSource = dt.DefaultView;
                }
            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "SELECT count(*) as hours FROM tblHeaderData WHERE CreationDate >= dateadd(hour, datediff(hour, 0, GETDATE()), 0) and InventoryNo ='421052'";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    hours_t01.ItemsSource = dt.DefaultView;
                }
            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "SELECT count(*) as hours FROM tblHeaderData WHERE CreationDate >= dateadd(hour, datediff(hour, 0, GETDATE()), 0) and InventoryNo ='421975'";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    hours_t02.ItemsSource = dt.DefaultView;
                }
            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "SELECT count(*) as hours FROM tblHeaderData WHERE CreationDate >= dateadd(hour, datediff(hour, 0, GETDATE()), 0) and InventoryNo ='421022'";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    hours_t03.ItemsSource = dt.DefaultView;
                }
            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "SELECT count(*) as hours FROM tblHeaderData WHERE CreationDate >= dateadd(hour, datediff(hour, 0, GETDATE()), 0) and InventoryNo ='422261'";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    hours_t04.ItemsSource = dt.DefaultView;
                }
            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "SELECT count(*) as hours FROM tblHeaderData WHERE CreationDate >= dateadd(hour, datediff(hour, 0, GETDATE()), 0) and InventoryNo ='4211791'";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    hours_t05.ItemsSource = dt.DefaultView;
                }
            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "SELECT count(*) as hours FROM tblHeaderData WHERE CreationDate >= dateadd(hour, datediff(hour, 0, GETDATE()), 0) and InventoryNo ='421998'";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    hours_t06.ItemsSource = dt.DefaultView;
                }
            }
        }

        
    }
}
