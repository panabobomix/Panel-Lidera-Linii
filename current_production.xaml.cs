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
        SqlCommand cmd, cmd2;
        SqlDataAdapter adpt, adpt2;
        DataTable dt;
        SqlDataReader reader, reader2;

       

        /*
private void download_production(object sender, RoutedEventArgs e)
{

   //ILOŚĆ SZTUK WYPRODUKOWANYCH PO PRODUCTION ORDER


   using (SqlConnection con = new SqlConnection(connectionString))
   {
       con.Open();//otwarcie połączenie
       string sqlQuery = "select TOP 1 tblHeaderData.ProductionOrder, Count (DISTINCT tblDMC.DMC) as'pcs'" +
           "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
           "where tblHeaderData.InventoryNo = '421050' and (tblDMC.DMC like '20200%' OR tblDMC.DMC like '800511')group by tblHeaderData.ProductionOrder order by MAX(tblDMC.CreationDate) DESC";

       using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))

       {
           DataTable dt = new DataTable();
           a.Fill(dt);
           quantity_c01.ItemsSource = dt.DefaultView;

       }

   }
   using (SqlConnection con = new SqlConnection(connectionString))
   {
       con.Open();//otwarcie połączenie
       string sqlQuery = "select TOP 1 tblHeaderData.ProductionOrder, Count (DISTINCT tblDMC.DMC) as'pcs'" +
           "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
           "where tblHeaderData.InventoryNo = '421913' and (tblDMC.DMC like '20200%' OR tblDMC.DMC like '800511')group by tblHeaderData.ProductionOrder order by MAX(tblDMC.CreationDate) DESC";

       using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))

       {
           DataTable dt = new DataTable();
           a.Fill(dt);
           quantity_c02.ItemsSource = dt.DefaultView;

       }

   }
   using (SqlConnection con = new SqlConnection(connectionString))
   {
       con.Open();//otwarcie połączenie
       string sqlQuery = "select TOP 1 tblHeaderData.ProductionOrder, Count (DISTINCT tblDMC.DMC) as'pcs'" +
           "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
           "where tblHeaderData.InventoryNo = '444444' and (tblDMC.DMC like '20200%' OR tblDMC.DMC like '800511')group by tblHeaderData.ProductionOrder order by MAX(tblDMC.CreationDate) DESC";

       using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))

       {
           DataTable dt = new DataTable();
           a.Fill(dt);
           quantity_c03.ItemsSource = dt.DefaultView;

       }

   }
   using (SqlConnection con = new SqlConnection(connectionString))
   {
       con.Open();//otwarcie połączenie
       string sqlQuery = "select TOP 1 tblHeaderData.ProductionOrder, Count (DISTINCT tblDMC.DMC) as'pcs'" +
           "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
           "where tblHeaderData.InventoryNo = '421008' and (tblDMC.DMC like '20200%' OR tblDMC.DMC like '800511')group by tblHeaderData.ProductionOrder order by MAX(tblDMC.CreationDate) DESC";

       using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))

       {
           DataTable dt = new DataTable();
           a.Fill(dt);
           quantity_c04.ItemsSource = dt.DefaultView;

       }

   }
   using (SqlConnection con = new SqlConnection(connectionString))
   {
       con.Open();//otwarcie połączenie
       string sqlQuery = "select TOP 1 tblHeaderData.ProductionOrder, Count (DISTINCT tblDMC.DMC) as'pcs'" +
           "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
           "where tblHeaderData.InventoryNo = '421052' and (tblDMC.DMC like '20200%' OR tblDMC.DMC like '800511')group by tblHeaderData.ProductionOrder order by MAX(tblDMC.CreationDate) DESC";

       using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))

       {
           DataTable dt = new DataTable();
           a.Fill(dt);
           quantity_t01.ItemsSource = dt.DefaultView;

       }

   }
   using (SqlConnection con = new SqlConnection(connectionString))
   {
       con.Open();//otwarcie połączenie
       string sqlQuery = "select TOP 1 tblHeaderData.ProductionOrder, Count (DISTINCT tblDMC.DMC) as'pcs'" +
           "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
           "where tblHeaderData.InventoryNo = '421975' and (tblDMC.DMC like '20200%' OR tblDMC.DMC like '800511')group by tblHeaderData.ProductionOrder order by MAX(tblDMC.CreationDate) DESC";

       using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))

       {
           DataTable dt = new DataTable();
           a.Fill(dt);
           quantity_t02.ItemsSource = dt.DefaultView;

       }

   }
   using (SqlConnection con = new SqlConnection(connectionString))
   {
       con.Open();//otwarcie połączenie
       string sqlQuery = "select TOP 1 tblHeaderData.ProductionOrder, Count (DISTINCT tblDMC.DMC) as'pcs'" +
           "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
           "where tblHeaderData.InventoryNo = '421022' and (tblDMC.DMC like '20200%' OR tblDMC.DMC like '800511')group by tblHeaderData.ProductionOrder order by MAX(tblDMC.CreationDate) DESC";

       using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))

       {
           DataTable dt = new DataTable();
           a.Fill(dt);
           quantity_t03.ItemsSource = dt.DefaultView;

       }

   }
   using (SqlConnection con = new SqlConnection(connectionString))
   {
       con.Open();//otwarcie połączenie
       string sqlQuery = "select TOP 1 tblHeaderData.ProductionOrder, Count (DISTINCT tblDMC.DMC) as'pcs'" +
           "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
           "where tblHeaderData.InventoryNo = '422261' and (tblDMC.DMC like '20200%' OR tblDMC.DMC like '800511')group by tblHeaderData.ProductionOrder order by MAX(tblDMC.CreationDate) DESC";

       using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))

       {
           DataTable dt = new DataTable();
           a.Fill(dt);
           quantity_t04.ItemsSource = dt.DefaultView;

       }

   }
   using (SqlConnection con = new SqlConnection(connectionString))
   {
       con.Open();//otwarcie połączenie
       string sqlQuery = "select TOP 1 tblHeaderData.ProductionOrder, Count (DISTINCT tblDMC.DMC) as'pcs'" +
           "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
           "where tblHeaderData.InventoryNo = '4211791' and (tblDMC.DMC like '20200%' OR tblDMC.DMC like '800511')group by tblHeaderData.ProductionOrder order by MAX(tblDMC.CreationDate) DESC";

       using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))

       {
           DataTable dt = new DataTable();
           a.Fill(dt);
           quantity_t05.ItemsSource = dt.DefaultView;

       }

   }
   using (SqlConnection con = new SqlConnection(connectionString))
   {
       con.Open();//otwarcie połączenie
       string sqlQuery = "select TOP 1 tblHeaderData.ProductionOrder, Count (DISTINCT tblDMC.DMC) as'pcs'" +
           "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
           "where tblHeaderData.InventoryNo = '421998' and (tblDMC.DMC like '20200%' OR tblDMC.DMC like '800511')group by tblHeaderData.ProductionOrder order by MAX(tblDMC.CreationDate) DESC";

       using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))

       {
           DataTable dt = new DataTable();
           a.Fill(dt);
           quantity_t06.ItemsSource = dt.DefaultView;

       }

   }
}
*/ // przycisk dane produkcyjne tymczasowo wyłączony
        public current_production()
        {
            InitializeComponent();
            
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(30);
            timer.Tick += timer_Tick;
            timer.Start();

            DispatcherTimer timer2 = new DispatcherTimer();
            timer2.Interval = TimeSpan.FromMinutes(15);
            timer2.Tick += new System.EventHandler(timer2_Tick);
            timer2.Start();

            DispatcherTimer timer3 = new DispatcherTimer();
            timer3.Interval = TimeSpan.FromMinutes(15);
            timer3.Tick += new System.EventHandler(timer3_Tick);
            timer3.Start();

        }



        void timer3_Tick(object sender, EventArgs e)
        {

        }


        //TESTY!!!


        void timer_Tick(object sender, EventArgs e)
        {
            



            //POBIERANIE STANDARDOWYCH INFORMACJI T01/T02/T03/T04 

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



            // pobranie standardowych danych C01 -numer materiałowy oraz kiedy ostatnia sztuka

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




            // OSTATNIE SZTUKI ORAZ ILOŚĆ GODZINOWA C01/C02/C03/C04

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 1 tblHeaderData.CreationDate, MaterialNo, InventoryNo,tblAtlasCopco.PSN, " +
                    "count(tblAtlasCopco.PSN) over() as 'hours',DATEDIFF(MINUTE, tblAtlasCopco.CreationDate, getdate()) as 'time' " +
                    "from (tblHeaderData inner join tblAtlasCopco on tblHeaderData.PSN = tblAtlasCopco.PSN)" +
                    "where tblAtlasCopco.PSN like '7500421050%' and TighteningType = 'Nakretka walka'and Torque_Status = 'OK' and tblAtlasCopco.CreationDate >= dateadd(hour, datediff(hour, 0, GETDATE()), 0)" +
                    "Order by tblHeaderData.CreationDate DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))

                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    C01_last.ItemsSource = dt.DefaultView;

                }

            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 1 tblHeaderData.CreationDate, MaterialNo, InventoryNo,tblAtlasCopco.PSN, " +
                    "count(tblAtlasCopco.PSN) over() as 'hours',DATEDIFF(MINUTE, tblAtlasCopco.CreationDate, getdate()) as 'time' " +
                    "from (tblHeaderData inner join tblAtlasCopco on tblHeaderData.PSN = tblAtlasCopco.PSN)" +
                    "where tblAtlasCopco.PSN like '7500421913%' and TighteningType = 'Nakretka walka'and Torque_Status = 'OK' and tblAtlasCopco.CreationDate >= dateadd(hour, datediff(hour, 0, GETDATE()), 0)" +
                    "Order by tblHeaderData.CreationDate DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))

                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    C02_last.ItemsSource = dt.DefaultView;

                }

            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 1 tblHeaderData.CreationDate, MaterialNo, InventoryNo,tblAtlasCopco.PSN, " +
                    "count(tblAtlasCopco.PSN) over() as 'hours',DATEDIFF(MINUTE, tblAtlasCopco.CreationDate, getdate()) as 'time' " +
                    "from (tblHeaderData inner join tblAtlasCopco on tblHeaderData.PSN = tblAtlasCopco.PSN)" +
                    "where tblAtlasCopco.PSN like '7500444444%' and TighteningType = 'Nakretka walka'and Torque_Status = 'OK' and tblAtlasCopco.CreationDate >= dateadd(hour, datediff(hour, 0, GETDATE()), 0)" +
                    "Order by tblHeaderData.CreationDate DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))

                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    C03_last.ItemsSource = dt.DefaultView;

                }

            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 1 tblHeaderData.CreationDate, MaterialNo, InventoryNo,tblAtlasCopco.PSN, " +
                    "count(tblAtlasCopco.PSN) over() as 'hours',DATEDIFF(MINUTE, tblAtlasCopco.CreationDate, getdate()) as 'time' " +
                    "from (tblHeaderData inner join tblAtlasCopco on tblHeaderData.PSN = tblAtlasCopco.PSN)" +
                    "where tblAtlasCopco.PSN like '7500421008%' and TighteningType = 'Nakretka walka'and Torque_Status = 'OK' and tblAtlasCopco.CreationDate >= dateadd(hour, datediff(hour, 0, GETDATE()), 0)" +
                    "Order by tblHeaderData.CreationDate DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))

                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    C04_last.ItemsSource = dt.DefaultView;

                }

            }





            //Ile od ostatniej sztuki + ilość godzinowa



            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 1 tblHeaderData.CreationDate, MaterialNo, InventoryNo,tblDmc.PSN,count(tblDMC.PSN) over() as 'hours',DATEDIFF(MINUTE, tblDMC.CreationDate, getdate()) as 'time'from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)where tblDMC.PSN like '7500421052%' and tblDMC.CreationDate >= dateadd(hour, datediff(hour, 0, GETDATE()), 0)Order by tblHeaderData.CreationDate DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    T01_last.ItemsSource = dt.DefaultView;
                }
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 1 tblHeaderData.CreationDate, MaterialNo, InventoryNo,tblDmc.PSN,count(tblDMC.PSN) over() as 'hours',DATEDIFF(MINUTE, tblDMC.CreationDate, getdate()) as 'time'from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)where tblDMC.PSN like '7500421975%' and tblDMC.CreationDate >= dateadd(hour, datediff(hour, 0, GETDATE()), 0)Order by tblHeaderData.CreationDate DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    T02_last.ItemsSource = dt.DefaultView;
                }
            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 1 tblHeaderData.CreationDate, MaterialNo, InventoryNo,tblDmc.PSN,count(tblDMC.PSN) over() as 'hours',DATEDIFF(MINUTE, tblDMC.CreationDate, getdate()) as 'time'from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)where tblDMC.PSN like '7500421022%' and tblDMC.CreationDate >= dateadd(hour, datediff(hour, 0, GETDATE()), 0)Order by tblHeaderData.CreationDate DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    T03_last.ItemsSource = dt.DefaultView;
                }
            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 1 tblHeaderData.CreationDate, MaterialNo, InventoryNo,tblDmc.PSN,count(tblDMC.PSN) over() as 'hours',DATEDIFF(MINUTE, tblDMC.CreationDate, getdate()) as 'time'from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)where tblDMC.PSN like '7500422261%' and tblDMC.CreationDate >= dateadd(hour, datediff(hour, 0, GETDATE()), 0)Order by tblHeaderData.CreationDate DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    T04_last.ItemsSource = dt.DefaultView;
                }
            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 1 tblHeaderData.CreationDate, MaterialNo, InventoryNo,tblDmc.PSN,count(tblDMC.PSN) over() as 'hours',DATEDIFF(MINUTE, tblDMC.CreationDate, getdate()) as 'time'from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)where tblDMC.PSN like '75004211791%' and tblDMC.CreationDate >= dateadd(hour, datediff(hour, 0, GETDATE()), 0)Order by tblHeaderData.CreationDate DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    T05_last.ItemsSource = dt.DefaultView;
                }
            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 1 tblHeaderData.CreationDate, MaterialNo, InventoryNo,tblDmc.PSN,count(tblDMC.PSN) over() as 'hours',DATEDIFF(MINUTE, tblDMC.CreationDate, getdate()) as 'time'from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)where tblDMC.PSN like '7500421998%' and tblDMC.CreationDate >= dateadd(hour, datediff(hour, 0, GETDATE()), 0)Order by tblHeaderData.CreationDate DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    T06_last.ItemsSource = dt.DefaultView;
                }
            }

            //ILOŚĆ SZTUK WYPRODUKOWANYCH PO PRODUCTION ORDER


            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 1 tblHeaderData.ProductionOrder, Count (DISTINCT tblDMC.DMC) as'pcs'" +
                    "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
                    "where tblHeaderData.InventoryNo = '421050' and (tblDMC.DMC like '20200%' OR tblDMC.DMC like '800511')group by tblHeaderData.ProductionOrder order by MAX(tblDMC.CreationDate) DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))

                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    quantity_c01.ItemsSource = dt.DefaultView;

                }

            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 1 tblHeaderData.ProductionOrder, Count (DISTINCT tblDMC.DMC) as'pcs'" +
                    "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
                    "where tblHeaderData.InventoryNo = '421913' and (tblDMC.DMC like '20200%' OR tblDMC.DMC like '800511')group by tblHeaderData.ProductionOrder order by MAX(tblDMC.CreationDate) DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))

                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    quantity_c02.ItemsSource = dt.DefaultView;

                }

            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 1 tblHeaderData.ProductionOrder, Count (DISTINCT tblDMC.DMC) as'pcs'" +
                    "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
                    "where tblHeaderData.InventoryNo = '444444' and (tblDMC.DMC like '20200%' OR tblDMC.DMC like '800511')group by tblHeaderData.ProductionOrder order by MAX(tblDMC.CreationDate) DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))

                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    quantity_c03.ItemsSource = dt.DefaultView;

                }

            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 1 tblHeaderData.ProductionOrder, Count (DISTINCT tblDMC.DMC) as'pcs'" +
                    "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
                    "where tblHeaderData.InventoryNo = '421008' and (tblDMC.DMC like '20200%' OR tblDMC.DMC like '800511')group by tblHeaderData.ProductionOrder order by MAX(tblDMC.CreationDate) DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))

                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    quantity_c04.ItemsSource = dt.DefaultView;

                }

            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 1 tblHeaderData.ProductionOrder, Count (DISTINCT tblDMC.DMC) as'pcs'" +
                    "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
                    "where tblHeaderData.InventoryNo = '421052' and tblDMC.CodeAnalysisText = 'BidiProcess' group by tblHeaderData.ProductionOrder order by MAX(tblDMC.CreationDate) DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))

                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    quantity_t01.ItemsSource = dt.DefaultView;

                }

            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 1 tblHeaderData.ProductionOrder, Count (DISTINCT tblDMC.DMC) as'pcs'" +
                    "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
                    "where tblHeaderData.InventoryNo = '421975' and (tblDMC.DMC like '20200%' OR tblDMC.DMC like '800511')group by tblHeaderData.ProductionOrder order by MAX(tblDMC.CreationDate) DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))

                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    quantity_t02.ItemsSource = dt.DefaultView;

                }

            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 1 tblHeaderData.ProductionOrder, Count (DISTINCT tblDMC.DMC) as'pcs'" +
                    "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
                    "where tblHeaderData.InventoryNo = '421022' and tblDMC.CodeAnalysisText = 'BidiProcess' group by tblHeaderData.ProductionOrder order by MAX(tblDMC.CreationDate) DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))

                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    quantity_t03.ItemsSource = dt.DefaultView;

                }

            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 1 tblHeaderData.ProductionOrder, Count (DISTINCT tblDMC.DMC) as'pcs'" +
                    "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
                    "where tblHeaderData.InventoryNo = '422261' and tblDMC.CodeAnalysisText = 'BidiProcess' group by tblHeaderData.ProductionOrder order by MAX(tblDMC.CreationDate) DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))

                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    quantity_t04.ItemsSource = dt.DefaultView;

                }

            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 1 tblHeaderData.ProductionOrder, Count (DISTINCT tblDMC.DMC) as'pcs'" +
                    "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
                    "where tblHeaderData.InventoryNo = '4211791' and tblDMC.CodeType = 'NamePlate' group by tblHeaderData.ProductionOrder order by MAX(tblDMC.CreationDate) DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))

                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    quantity_t05.ItemsSource = dt.DefaultView;

                }

            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 1 tblHeaderData.ProductionOrder, Count (DISTINCT tblDMC.DMC) as'pcs'" +
                    "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
                    "where tblHeaderData.InventoryNo = '421998' and tblDMC.Description = 'NamePlate' group by tblHeaderData.ProductionOrder order by MAX(tblDMC.CreationDate) DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))

                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    quantity_t06.ItemsSource = dt.DefaultView;

                }

            }





        }



        void timer2_Tick(object sender, EventArgs e) // timer do zapytania o  użycie kodu liderskiego
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select count (DMC) as 'kod'" +
                    "from tblDMCwhere DMC = '1234567851247921547921475320' and PSN like '7500444444%'and CreationDate > DATEADD(hh,-3,GETDATE())" +
                    "group by tblDMC.DMC";
                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    T01.ItemsSource = dt.DefaultView;
                }
            }

        }








        private void download_all(object sender, RoutedEventArgs e)
        {


            //POBIERANIE STANDARDOWYCH INFORMACJI T01/T02/T03/T04 

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
       


            // pobranie standardowych danych C01 -numer materiałowy oraz kiedy ostatnia sztuka

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




            // OSTATNIE SZTUKI ORAZ ILOŚĆ GODZINOWA C01/C02/C03/C04

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 1 tblHeaderData.CreationDate, MaterialNo, InventoryNo,tblAtlasCopco.PSN, " +
                    "count(tblAtlasCopco.PSN) over() as 'hours',DATEDIFF(MINUTE, tblAtlasCopco.CreationDate, getdate()) as 'time' " +
                    "from (tblHeaderData inner join tblAtlasCopco on tblHeaderData.PSN = tblAtlasCopco.PSN)" +
                    "where tblAtlasCopco.PSN like '7500421050%' and TighteningType = 'Nakretka walka' and tblAtlasCopco.CreationDate >= dateadd(hour, datediff(hour, 0, GETDATE()), 0)" +
                    "Order by tblHeaderData.CreationDate DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))

                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    C01_last.ItemsSource = dt.DefaultView;

                }

            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 1 tblHeaderData.CreationDate, MaterialNo, InventoryNo,tblAtlasCopco.PSN, " +
                    "count(tblAtlasCopco.PSN) over() as 'hours',DATEDIFF(MINUTE, tblAtlasCopco.CreationDate, getdate()) as 'time' " +
                    "from (tblHeaderData inner join tblAtlasCopco on tblHeaderData.PSN = tblAtlasCopco.PSN)" +
                    "where tblAtlasCopco.PSN like '7500421913%' and TighteningType = 'Nakretka walka' and tblAtlasCopco.CreationDate >= dateadd(hour, datediff(hour, 0, GETDATE()), 0)" +
                    "Order by tblHeaderData.CreationDate DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))

                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    C02_last.ItemsSource = dt.DefaultView;

                }

            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 1 tblHeaderData.CreationDate, MaterialNo, InventoryNo,tblAtlasCopco.PSN, " +
                    "count(tblAtlasCopco.PSN) over() as 'hours',DATEDIFF(MINUTE, tblAtlasCopco.CreationDate, getdate()) as 'time' " +
                    "from (tblHeaderData inner join tblAtlasCopco on tblHeaderData.PSN = tblAtlasCopco.PSN)" +
                    "where tblAtlasCopco.PSN like '7500444444%' and TighteningType = 'Nakretka walka' and tblAtlasCopco.CreationDate >= dateadd(hour, datediff(hour, 0, GETDATE()), 0)" +
                    "Order by tblHeaderData.CreationDate DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))

                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    C03_last.ItemsSource = dt.DefaultView;

                }

            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 1 tblHeaderData.CreationDate, MaterialNo, InventoryNo,tblAtlasCopco.PSN, " +
                    "count(tblAtlasCopco.PSN) over() as 'hours',DATEDIFF(MINUTE, tblAtlasCopco.CreationDate, getdate()) as 'time' " +
                    "from (tblHeaderData inner join tblAtlasCopco on tblHeaderData.PSN = tblAtlasCopco.PSN)" +
                    "where tblAtlasCopco.PSN like '7500421008%' and TighteningType = 'Nakretka walka' and tblAtlasCopco.CreationDate >= dateadd(hour, datediff(hour, 0, GETDATE()), 0)" +
                    "Order by tblHeaderData.CreationDate DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))

                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    C04_last.ItemsSource = dt.DefaultView;

                }

            }




            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 1 tblHeaderData.ProductionOrder, Count (DISTINCT tblDMC.DMC) as'pcs'" +
                    "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
                    "where tblHeaderData.InventoryNo = '421050' and (tblDMC.DMC like '20200%' OR tblDMC.DMC like '800511')group by tblHeaderData.ProductionOrder order by MAX(tblDMC.CreationDate) DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))

                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    quantity_c01.ItemsSource = dt.DefaultView;

                }

            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 1 tblHeaderData.ProductionOrder, Count (DISTINCT tblDMC.DMC) as'pcs'" +
                    "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
                    "where tblHeaderData.InventoryNo = '421913' and (tblDMC.DMC like '20200%' OR tblDMC.DMC like '800511')group by tblHeaderData.ProductionOrder order by MAX(tblDMC.CreationDate) DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))

                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    quantity_c02.ItemsSource = dt.DefaultView;

                }

            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 1 tblHeaderData.ProductionOrder, Count (DISTINCT tblDMC.DMC) as'pcs'" +
                    "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
                    "where tblHeaderData.InventoryNo = '444444' and (tblDMC.DMC like '20200%' OR tblDMC.DMC like '800511')group by tblHeaderData.ProductionOrder order by MAX(tblDMC.CreationDate) DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))

                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    quantity_c03.ItemsSource = dt.DefaultView;

                }

            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 1 tblHeaderData.ProductionOrder, Count (DISTINCT tblDMC.DMC) as'pcs'" +
                    "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
                    "where tblHeaderData.InventoryNo = '421008' and (tblDMC.DMC like '20200%' OR tblDMC.DMC like '800511')group by tblHeaderData.ProductionOrder order by MAX(tblDMC.CreationDate) DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))

                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    quantity_c04.ItemsSource = dt.DefaultView;

                }

            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 1 tblHeaderData.ProductionOrder, Count (DISTINCT tblDMC.DMC) as'pcs'" +
                    "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
                    "where tblHeaderData.InventoryNo = '421052' and tblDMC.CodeAnalysisText = 'BidiProcess' group by tblHeaderData.ProductionOrder order by MAX(tblDMC.CreationDate) DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))

                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    quantity_t01.ItemsSource = dt.DefaultView;

                }

            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 1 tblHeaderData.ProductionOrder, Count (DISTINCT tblDMC.DMC) as'pcs'" +
                    "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
                    "where tblHeaderData.InventoryNo = '421975' and (tblDMC.DMC like '20200%' OR tblDMC.DMC like '800511')group by tblHeaderData.ProductionOrder order by MAX(tblDMC.CreationDate) DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))

                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    quantity_t02.ItemsSource = dt.DefaultView;

                }

            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 1 tblHeaderData.ProductionOrder, Count (DISTINCT tblDMC.DMC) as'pcs'" +
                    "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
                    "where tblHeaderData.InventoryNo = '421022' and tblDMC.CodeAnalysisText = 'BidiProcess' group by tblHeaderData.ProductionOrder order by MAX(tblDMC.CreationDate) DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))

                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    quantity_t03.ItemsSource = dt.DefaultView;

                }

            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 1 tblHeaderData.ProductionOrder, Count (DISTINCT tblDMC.DMC) as'pcs'" +
                    "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
                    "where tblHeaderData.InventoryNo = '422261' and tblDMC.CodeAnalysisText = 'BidiProcess' group by tblHeaderData.ProductionOrder order by MAX(tblDMC.CreationDate) DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))

                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    quantity_t04.ItemsSource = dt.DefaultView;

                }

            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 1 tblHeaderData.ProductionOrder, Count (DISTINCT tblDMC.DMC) as'pcs'" +
                    "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
                    "where tblHeaderData.InventoryNo = '4211791' and tblDMC.CodeType = 'NamePlate' group by tblHeaderData.ProductionOrder order by MAX(tblDMC.CreationDate) DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))

                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    quantity_t05.ItemsSource = dt.DefaultView;

                }

            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 1 tblHeaderData.ProductionOrder, Count (DISTINCT tblDMC.DMC) as'pcs'" +
                    "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
                    "where tblHeaderData.InventoryNo = '421998' and tblDMC.Description = 'NamePlate' group by tblHeaderData.ProductionOrder order by MAX(tblDMC.CreationDate) DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))

                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    quantity_t06.ItemsSource = dt.DefaultView;

                }

            }


            //pobranie informacji o użyciu kodu liderskiego w ostatnich 3 godzinach pracy 

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select count (DMC) as 'kod'" +
                    "from tblDMC where DMC = '1234567851247921547921475320' and PSN like '7500444444%'and CreationDate > DATEADD(hh,-3,GETDATE())" +
                    "group by tblDMC.DMC";
                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    T01.ItemsSource = dt.DefaultView;
                }
            }







            //ZLICZANIE ILOSCI SZTUK Z DANEGO ZLECENIA PRODUKCYJNEGO !!!
            /*
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 1 tblHeaderData.ProductionOrder, Count (*) as'liczba sztuk' " +
                    "from (tblHeaderData inner join tblAtlasCopco on tblHeaderData.PSN = tblAtlasCopco.PSN)" +
                    "where tblHeaderData.InventoryNo = '421050' and TighteningType = 'Nakretka walka' group by tblHeaderData.ProductionOrder order by MAX(tblAtlasCopco.CreationDate) DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))

                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    quantity_c01.ItemsSource = dt.DefaultView;

                }

            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 1 tblHeaderData.ProductionOrder, Count (*) as'liczba sztuk' " +
                    "from (tblHeaderData inner join tblAtlasCopco on tblHeaderData.PSN = tblAtlasCopco.PSN)" +
                    "where tblHeaderData.InventoryNo = '421913' and TighteningType = 'Nakretka walka' group by tblHeaderData.ProductionOrder order by MAX(tblAtlasCopco.CreationDate) DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))

                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    quantity_c02.ItemsSource = dt.DefaultView;

                }

            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 1 tblHeaderData.ProductionOrder, Count (*) as'liczba sztuk' " +
                    "from (tblHeaderData inner join tblAtlasCopco on tblHeaderData.PSN = tblAtlasCopco.PSN)" +
                    "where tblHeaderData.InventoryNo = '444444' and TighteningType = 'Nakretka walka' group by tblHeaderData.ProductionOrder order by MAX(tblAtlasCopco.CreationDate) DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))

                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    quantity_c03.ItemsSource = dt.DefaultView;

                }

            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 1 tblHeaderData.ProductionOrder, Count (*) as'liczba sztuk' " +
                    "from (tblHeaderData inner join tblAtlasCopco on tblHeaderData.PSN = tblAtlasCopco.PSN)" +
                    "where tblHeaderData.InventoryNo = '421008' and TighteningType = 'Nakretka walka' group by tblHeaderData.ProductionOrder order by MAX(tblAtlasCopco.CreationDate) DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))

                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    quantity_c04.ItemsSource = dt.DefaultView;

                }

            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 1 tblHeaderData.ProductionOrder, Count (DISTINCT tblDMC.DMC) as'liczba sztuk'" +
                    "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
                    "where tblHeaderData.InventoryNo = '421052' and (DMC like '8005%' OR DMC like'20200')" +
                    "group by tblHeaderData.ProductionOrder" +
                    "order by MAX(tblDMC.CreationDate) DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))

                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    quantity_t01.ItemsSource = dt.DefaultView;

                }

            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 1 tblHeaderData.ProductionOrder, Count (DISTINCT tblDMC.DMC) as'liczba sztuk'" +
                    "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
                    "where tblHeaderData.InventoryNo = '421975' and (DMC like '8005%' OR DMC like'20200')" +
                    "group by tblHeaderData.ProductionOrder" +
                    "order by MAX(tblDMC.CreationDate) DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))

                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    quantity_t02.ItemsSource = dt.DefaultView;

                }

            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 1 tblHeaderData.ProductionOrder, Count (DISTINCT tblDMC.DMC) as'liczba sztuk'" +
                    "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
                    "where tblHeaderData.InventoryNo = '421022' and (DMC like '8005%' OR DMC like'20200')" +
                    "group by tblHeaderData.ProductionOrder" +
                    "order by MAX(tblDMC.CreationDate) DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))

                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    quantity_t03.ItemsSource = dt.DefaultView;

                }

            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 1 tblHeaderData.ProductionOrder, Count (DISTINCT tblDMC.DMC) as'liczba sztuk'" +
                    "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
                    "where tblHeaderData.InventoryNo = '422261' and (DMC like '8005%' OR DMC like'20200')" +
                    "group by tblHeaderData.ProductionOrder" +
                    "order by MAX(tblDMC.CreationDate) DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))

                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    quantity_t04.ItemsSource = dt.DefaultView;

                }

            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 1 tblHeaderData.ProductionOrder, Count (DISTINCT tblDMC.DMC) as'liczba sztuk'" +
                    "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
                    "where tblHeaderData.InventoryNo = '4211791' and (DMC like '8005%' OR DMC like'20200')" +
                    "group by tblHeaderData.ProductionOrder" +
                    "order by MAX(tblDMC.CreationDate) DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))

                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    quantity_t05.ItemsSource = dt.DefaultView;

                }

            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 1 tblHeaderData.ProductionOrder, Count (DISTINCT tblDMC.DMC) as'liczba sztuk'" +
                    "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
                    "where tblHeaderData.InventoryNo = '421998' and (DMC like '8005%' OR DMC like'20200')" +
                    "group by tblHeaderData.ProductionOrder" +
                    "order by MAX(tblDMC.CreationDate) DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))

                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    quantity_t06.ItemsSource = dt.DefaultView;

                }

            }
            */

        }


    }
}
