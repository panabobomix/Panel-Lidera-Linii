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
                "Integrated Security=SSPI;Connection Timeout=0";
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
          /*
            // czasówka dla C1/C2/C3/C4
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(60);
            timer.Tick += timer_Tick;
            timer.Start();
            // czasówka dla kodu liderskiego
            DispatcherTimer timer2 = new DispatcherTimer();
            timer2.Interval = TimeSpan.FromSeconds(180);
            timer2.Tick += new System.EventHandler(timer2_Tick);
            timer2.Start();


            // czasówka dla T01/T02/T03/T04
            DispatcherTimer timer3 = new DispatcherTimer();
            timer3.Interval = TimeSpan.FromSeconds(60);
            timer3.Tick += new System.EventHandler(timer3_Tick);
            timer3.Start();
            // czasówka  testowa
            DispatcherTimer timer4 = new DispatcherTimer();
            timer4.Interval = TimeSpan.FromSeconds(45);
            timer4.Tick += new System.EventHandler(timer4_Tick);
            timer4.Start();
            */
        }
        
        
        

    

        private void download_CORE(object sender, RoutedEventArgs e)
        {

            //KOD LIDERSKI
            
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select count (DMC) as 'kod'" +
                    "from tblDMC where DMC = '1234567851247921547921475320' and CreationDate > DATEADD(hh,-3,GETDATE())" +
                    "group by tblDMC.DMC";
                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    kod_liderski.ItemsSource = dt.DefaultView;
                }
            }


            //CORE



            //C01 głowne dane produkcyjne
            using (SqlConnection con = new SqlConnection(connectionString))
            {   //C01 głowne dane produkcyjne
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 1*  from tblHeaderData Where InventoryNo = '421050' Order by CreationDate DESC";
                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    C01.ItemsSource = dt.DefaultView;
                }
                //C01 ile od ostatniej sztuki
                string sqlQuery2 = "select TOP 1 tblHeaderData.CreationDate, MaterialNo, InventoryNo,tblAtlasCopco.PSN, count(tblAtlasCopco.PSN) over() as 'hours',DATEDIFF(MINUTE, tblAtlasCopco.CreationDate, getdate()) as 'time' from(tblHeaderData inner join tblAtlasCopco on tblHeaderData.PSN = tblAtlasCopco.PSN) where tblHeaderData.InventoryNo = '421050' and TighteningType = 'Nakretka walka'and Torque_Status = 'OK' and tblAtlasCopco.CreationDate >= dateadd(hour, datediff(hour, 0, GETDATE()), 0) Order by tblHeaderData.CreationDate DESC";
                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery2, con))

                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    C01_last.ItemsSource = dt.DefaultView;

                }
                //C01 ile sztuk wyprodukowanych
                string sqlQuery3 = "select TOP 1 tblHeaderData.ProductionOrder, Count (DISTINCT tblDMC.DMC) as'pcs'" +
                                  "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
                                  "where tblHeaderData.InventoryNo = '421050' and (tblDMC.DMC like '20200%' OR tblDMC.DMC like '800511')group by tblHeaderData.ProductionOrder order by MAX(tblDMC.CreationDate) DESC";
                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery3, con))

                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    quantity_c01.ItemsSource = dt.DefaultView;

                }
                //C02 głowne dane produkcyjne
                string sqlQuery4 = "select TOP 1*  from tblHeaderData Where InventoryNo = '421913' Order by CreationDate DESC";
                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery4, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    C02.ItemsSource = dt.DefaultView;
                }
                //C02 ile od ostatniej sztuki
                string sqlQuery5 = "select TOP 1 tblHeaderData.CreationDate, MaterialNo, InventoryNo,tblAtlasCopco.PSN, " +
                                    "count(tblAtlasCopco.PSN) over() as 'hours',DATEDIFF(MINUTE, tblAtlasCopco.CreationDate, getdate()) as 'time' " +
                                        "from (tblHeaderData inner join tblAtlasCopco on tblHeaderData.PSN = tblAtlasCopco.PSN)" +
                                    "where tblHeaderData.InventoryNo  = '421913' and (TighteningType = 'Nakretka walka' OR TighteningType = 'Back plate') and tblAtlasCopco.CreationDate >= dateadd(hour, datediff(hour, 0, GETDATE()), 0)" +
                                    "Order by tblHeaderData.CreationDate DESC";
                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery5, con))

                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    C02_last.ItemsSource = dt.DefaultView;

                }
                //C02 ile sztuk wyprodukowanych
                string sqlQuery6 = "select TOP 1 tblHeaderData.ProductionOrder, Count (DISTINCT tblDMC.DMC) as'pcs'" +
                                    "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
                                       "where tblHeaderData.InventoryNo = '421913' and (tblDMC.DMC like '20200%' OR tblDMC.DMC like '800511')group by tblHeaderData.ProductionOrder order by MAX(tblDMC.CreationDate) DESC";
                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery6, con))

                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    quantity_c02.ItemsSource = dt.DefaultView;

                }
                //C03 głowne dane produkcyjne
                string sqlQuery7 = "select TOP 1*  from tblHeaderData Where InventoryNo = '444444' Order by CreationDate DESC";
                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery7, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    C03.ItemsSource = dt.DefaultView;
                }
                //C03 ile od ostatniej sztuki
                string sqlQuery8 = "select TOP 1 tblHeaderData.CreationDate, MaterialNo, InventoryNo,tblAtlasCopco.PSN, count(tblAtlasCopco.PSN) over() as 'hours',DATEDIFF(MINUTE, tblAtlasCopco.CreationDate, getdate()) as 'time' from(tblHeaderData inner join tblAtlasCopco on tblHeaderData.PSN = tblAtlasCopco.PSN) where tblHeaderData.InventoryNo = '444444' and TighteningType = 'Nakretka walka'and Torque_Status = 'OK' and tblAtlasCopco.CreationDate >= dateadd(hour, datediff(hour, 0, GETDATE()), 0) Order by tblHeaderData.CreationDate DESC";
                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery8, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    C03_last.ItemsSource = dt.DefaultView;
                }
                //C03 ile sztuk wyprodukowanych
                string sqlQuery9 = "select TOP 1 tblHeaderData.ProductionOrder, Count (DISTINCT tblDMC.DMC) as'pcs'" +
                                    "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
                                        "where tblHeaderData.InventoryNo = '444444' and (tblDMC.DMC like '20200%' OR tblDMC.DMC like '800511')group by tblHeaderData.ProductionOrder order by MAX(tblDMC.CreationDate) DESC";
                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery9, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    quantity_c03.ItemsSource = dt.DefaultView;
                }
                //C04 głowne dane produkcyjne
                string sqlQuery10 = "select TOP 1*  from tblHeaderData Where InventoryNo = '421008' Order by CreationDate DESC";
                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery10, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    C04.ItemsSource = dt.DefaultView;
                }
                //C04 ile od ostatniej sztuki
                string sqlQuery11 = "select TOP 1 tblHeaderData.CreationDate, MaterialNo, InventoryNo,tblAtlasCopco.PSN, " +
                    "count(tblAtlasCopco.PSN) over() as 'hours',DATEDIFF(MINUTE, tblAtlasCopco.CreationDate, getdate()) as 'time' " +
                    "from (tblHeaderData inner join tblAtlasCopco on tblHeaderData.PSN = tblAtlasCopco.PSN)" +
                    "where tblHeaderData.InventoryNo  = '421008' and TighteningType = 'Nakretka walka'and Torque_Status = 'OK' and tblAtlasCopco.CreationDate >= dateadd(hour, datediff(hour, 0, GETDATE()), 0)" +
                    "Order by tblHeaderData.CreationDate DESC";
                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery11, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    C04_last.ItemsSource = dt.DefaultView;
                }
                //C04 ile sztuk wyprodukowanych
                string sqlQuery12 = "select TOP 1 tblHeaderData.ProductionOrder, Count (DISTINCT tblDMC.DMC) as'pcs'" +
                    "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
                    "where tblHeaderData.InventoryNo = '421008' and (tblDMC.DMC like '20200%' OR tblDMC.DMC like '800511')group by tblHeaderData.ProductionOrder order by MAX(tblDMC.CreationDate) DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery12, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    quantity_c04.ItemsSource = dt.DefaultView;
                }
                //C04 ile sztuk wyprodukowanych
                string sqlQuery13 = "select TOP 1 tblHeaderData.ProductionOrder, Count (DISTINCT tblDMC.DMC) as'pcs'" +
                                    "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
                                    "where tblHeaderData.InventoryNo = '421008' and (tblDMC.DMC like '20200%' OR tblDMC.DMC like '800511')group by tblHeaderData.ProductionOrder order by MAX(tblDMC.CreationDate) DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery13, con))

                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    quantity_c04.ItemsSource = dt.DefaultView;

                }
                //B02 głowne dane produkcyjne
                string sqlQuery14 = "select TOP 1*  from tblHeaderData Where InventoryNo = '421914' Order by CreationDate DESC";
                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery14, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    B02.ItemsSource = dt.DefaultView;
                }
                //B02 ile od ostatniej sztuki
                string sqlQuery15 = "select TOP 1 tblHeaderData.CreationDate, MaterialNo, InventoryNo,tblDmc.PSN,count(tblDMC.PSN) over() as 'hours',DATEDIFF(MINUTE, tblDMC.CreationDate, getdate()) as 'time'from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)where tblHeaderData.InventoryNo = '421914' and tblDMC.CreationDate >= dateadd(hour, datediff(hour, 0, GETDATE()), 0)Order by tblHeaderData.CreationDate DESC";
                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery15, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    B02_last.ItemsSource = dt.DefaultView;
                }
                //B02 ile sztuk wyprodukowanych
                string sqlQuery16 = "select TOP 1 tblHeaderData.ProductionOrder, Count (DISTINCT tblDMC.DMC) as'pcs'" +
                    "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
                    "where tblHeaderData.InventoryNo = '421914' and (tblDMC.DMC like '20200%' OR tblDMC.DMC like '800511')group by tblHeaderData.ProductionOrder order by MAX(tblDMC.CreationDate) DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery16, con))

                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    quantity_B02.ItemsSource = dt.DefaultView;

                }

                con.Close();
            }



                












        }





        private void download_TC(object sender, RoutedEventArgs e)
        {



            //KOD LIDERSKI

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select count (DMC) as 'kod'" +
                    "from tblDMC where DMC = '1234567851247921547921475320' and CreationDate > DATEADD(hh,-3,GETDATE())" +
                    "group by tblDMC.DMC";
                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    kod_liderski.ItemsSource = dt.DefaultView;
                }
            }

            /*
            //CORE

            //C01 ALL DATA

            //C01 głowne dane produkcyjne
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
            //C01 ile od ostatniej sztuki
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sqlQuery = "select TOP 1 tblHeaderData.CreationDate, MaterialNo, InventoryNo,tblAtlasCopco.PSN, count(tblAtlasCopco.PSN) over() as 'hours',DATEDIFF(MINUTE, tblAtlasCopco.CreationDate, getdate()) as 'time' from(tblHeaderData inner join tblAtlasCopco on tblHeaderData.PSN = tblAtlasCopco.PSN) where tblHeaderData.InventoryNo = '421050' and TighteningType = 'Nakretka walka'and Torque_Status = 'OK' and tblAtlasCopco.CreationDate >= dateadd(hour, datediff(hour, 0, GETDATE()), 0) Order by tblHeaderData.CreationDate DESC";

                con.Open();//otwarcie połączenie
               // string sqlQuery = "select TOP 1 tblHeaderData.CreationDate, MaterialNo, InventoryNo,tblAtlasCopco.PSN, " +
               //     "count(tblAtlasCopco.PSN) over() as 'hours',DATEDIFF(MINUTE, tblAtlasCopco.CreationDate, getdate()) as 'time' " +
               //     "from (tblHeaderData inner join tblAtlasCopco on tblHeaderData.PSN = tblAtlasCopco.PSN)" +
               //     "where tblAtlasCopco.PSN like '7500421050%' and TighteningType = 'Nakretka walka'and Torque_Status = 'OK' and tblAtlasCopco.CreationDate >= dateadd(hour, datediff(hour, 0, GETDATE()), 0)" +
               //     "Order by tblHeaderData.CreationDate DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))

                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    C01_last.ItemsSource = dt.DefaultView;

                }

            }
            //C01 ile sztuk wyprodukowanych
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
            // C02 ALL DATA

            //C02 głowne dane produkcyjne

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
            //C02 ile od ostatniej sztuki
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 1 tblHeaderData.CreationDate, MaterialNo, InventoryNo,tblAtlasCopco.PSN, " +
                    "count(tblAtlasCopco.PSN) over() as 'hours',DATEDIFF(MINUTE, tblAtlasCopco.CreationDate, getdate()) as 'time' " +
                    "from (tblHeaderData inner join tblAtlasCopco on tblHeaderData.PSN = tblAtlasCopco.PSN)" +
                    "where tblHeaderData.InventoryNo  = '421913' and (TighteningType = 'Nakretka walka' OR TighteningType = 'Back plate') and tblAtlasCopco.CreationDate >= dateadd(hour, datediff(hour, 0, GETDATE()), 0)" +
                    "Order by tblHeaderData.CreationDate DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))

                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    C02_last.ItemsSource = dt.DefaultView;

                }

            }
            //C02 ile sztuk wyprodukowanych
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
            //C03 głowne dane produkcyjne

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
    
            //C03 ile od ostatniej sztuki
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                           //string sqlQuery = "select TOP 1 tblHeaderData.CreationDate, MaterialNo, InventoryNo,tblAtlasCopco.PSN, " +
                           //  "count(tblAtlasCopco.PSN) over() as 'hours',DATEDIFF(MINUTE, tblAtlasCopco.CreationDate, getdate()) as 'time' " +
                           //"from (tblHeaderData inner join tblAtlasCopco on tblHeaderData.PSN = tblAtlasCopco.PSN)" +
                           // "where tblAtlasCopco.PSN like '7500444444%' and TighteningType = 'Nakretka walka'and Torque_Status = 'OK' and tblAtlasCopco.CreationDate >= dateadd(hour, datediff(hour, 0, GETDATE()), 0)" +
                           //"Order by tblHeaderData.CreationDate DESC";




                string sqlQuery = "select TOP 1 tblHeaderData.CreationDate, MaterialNo, InventoryNo,tblAtlasCopco.PSN, count(tblAtlasCopco.PSN) over() as 'hours',DATEDIFF(MINUTE, tblAtlasCopco.CreationDate, getdate()) as 'time' from(tblHeaderData inner join tblAtlasCopco on tblHeaderData.PSN = tblAtlasCopco.PSN) where tblHeaderData.InventoryNo = '444444' and TighteningType = 'Nakretka walka'and Torque_Status = 'OK' and tblAtlasCopco.CreationDate >= dateadd(hour, datediff(hour, 0, GETDATE()), 0) Order by tblHeaderData.CreationDate DESC";
                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))

                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    C03_last.ItemsSource = dt.DefaultView;

                }

            }
            //C03 ile sztuk wyprodukowanych
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

            //C04 głowne dane produkcyjne
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
            //C04 ile od ostatniej sztuki
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 1 tblHeaderData.CreationDate, MaterialNo, InventoryNo,tblAtlasCopco.PSN, " +
                    "count(tblAtlasCopco.PSN) over() as 'hours',DATEDIFF(MINUTE, tblAtlasCopco.CreationDate, getdate()) as 'time' " +
                    "from (tblHeaderData inner join tblAtlasCopco on tblHeaderData.PSN = tblAtlasCopco.PSN)" +
                    "where tblHeaderData.InventoryNo  = '421008' and TighteningType = 'Nakretka walka'and Torque_Status = 'OK' and tblAtlasCopco.CreationDate >= dateadd(hour, datediff(hour, 0, GETDATE()), 0)" +
                    "Order by tblHeaderData.CreationDate DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))

                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    C04_last.ItemsSource = dt.DefaultView;

                }
            }
            //C04 ile sztuk wyprodukowanych
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


            //B02 ALL DATA

            //B02 głowne dane produkcyjne
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 1*  from tblHeaderData Where InventoryNo = '421914' Order by CreationDate DESC";
                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    B02.ItemsSource = dt.DefaultView;
                }
            }

            //B02 ile od ostatniej sztuki
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                //string sqlQuery = "select TOP 1 tblHeaderData.CreationDate, MaterialNo, InventoryNo,tblDmc.PSN,count(tblDMC.PSN) over() as 'hours',DATEDIFF(MINUTE, tblDMC.CreationDate, getdate()) as 'time'from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)where tblDMC.PSN like '7500421914%' and tblDMC.CreationDate >= dateadd(hour, datediff(hour, 0, GETDATE()), 0)Order by tblHeaderData.CreationDate DESC";
                string sqlQuery = "select TOP 1 tblHeaderData.CreationDate, MaterialNo, InventoryNo,tblDmc.PSN,count(tblDMC.PSN) over() as 'hours',DATEDIFF(MINUTE, tblDMC.CreationDate, getdate()) as 'time'from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)where tblHeaderData.InventoryNo = '421914' and tblDMC.CreationDate >= dateadd(hour, datediff(hour, 0, GETDATE()), 0)Order by tblHeaderData.CreationDate DESC";
                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    B02_last.ItemsSource = dt.DefaultView;
                }
            }
            //B02 ile sztuk wyprodukowanych
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 1 tblHeaderData.ProductionOrder, Count (DISTINCT tblDMC.DMC) as'pcs'" +
                    "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
                    "where tblHeaderData.InventoryNo = '421914' and (tblDMC.DMC like '20200%' OR tblDMC.DMC like '800511')group by tblHeaderData.ProductionOrder order by MAX(tblDMC.CreationDate) DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))

                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    quantity_B02.ItemsSource = dt.DefaultView;

                }
            }

    */
            //TC
            //TC ALL DATA


            //T01 głowne dane produkcyjne
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
            //T01 ile od ostatniej sztuki
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 1 tblHeaderData.CreationDate, MaterialNo, InventoryNo,tblDmc.PSN,count(tblDMC.PSN) over() as 'hours',DATEDIFF(MINUTE, tblDMC.CreationDate, getdate()) as 'time'from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)where tblHeaderData.InventoryNo  = '421052' and tblDMC.CreationDate >= dateadd(hour, datediff(hour, 0, GETDATE()), 0)Order by tblHeaderData.CreationDate DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    T01_last.ItemsSource = dt.DefaultView;
                }
            }
            //T01 ile sztuk wyprodukowanych
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

            //T02 głowne dane produkcyjne
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 1*  from tblHeaderData Where InventoryNo = '421978' Order by CreationDate DESC";
                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    T02.ItemsSource = dt.DefaultView;
                }
            }
            //T02 ile od ostatniej sztuki
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 1 tblHeaderData.CreationDate, MaterialNo, InventoryNo,tblDmc.PSN,count(tblDMC.PSN) over() as 'hours',DATEDIFF(MINUTE, tblDMC.CreationDate, getdate()) as 'time'from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)where tblHeaderData.InventoryNo  = '421978' and tblDMC.CreationDate >= dateadd(hour, datediff(hour, 0, GETDATE()), 0)Order by tblHeaderData.CreationDate DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    T02_last.ItemsSource = dt.DefaultView;
                }
            }
            //T02 ile sztuk wyprodukowanych
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 1 tblHeaderData.ProductionOrder, Count (DISTINCT tblDMC.DMC) as'pcs'" +
                    "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
                    "where tblHeaderData.InventoryNo = '421978' and tblDMC.CodeAnalysisText = 'BidiProcess' group by tblHeaderData.ProductionOrder order by MAX(tblDMC.CreationDate) DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))

                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    quantity_t02.ItemsSource = dt.DefaultView;

                }
            }

            //T03 głowne dane produkcyjne
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
            //T03 ile od ostatniej sztuki
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 1 tblHeaderData.CreationDate, MaterialNo, InventoryNo,tblDmc.PSN,count(tblDMC.PSN) over() as 'hours',DATEDIFF(MINUTE, tblDMC.CreationDate, getdate()) as 'time'from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)where tblHeaderData.InventoryNo  = '421022' and tblDMC.CreationDate >= dateadd(hour, datediff(hour, 0, GETDATE()), 0)Order by tblHeaderData.CreationDate DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    T03_last.ItemsSource = dt.DefaultView;
                }
            }
            //T03 ile sztuk wyprodukowanych
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

            //T04 głowne dane produkcyjne
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
            //T04 ile od ostatniej sztuki

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 1 tblHeaderData.CreationDate, MaterialNo, InventoryNo,tblDmc.PSN,count(tblDMC.PSN) over() as 'hours',DATEDIFF(MINUTE, tblDMC.CreationDate, getdate()) as 'time'from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)where tblHeaderData.InventoryNo  = '422261' and tblDMC.CreationDate >= dateadd(hour, datediff(hour, 0, GETDATE()), 0)Order by tblHeaderData.CreationDate DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    T04_last.ItemsSource = dt.DefaultView;
                }
            }
            //T04 ile sztuk wyprodukowanych
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

            //T05 głowne dane produkcyjne
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
            //T05 ile od ostatniej sztuki
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 1 tblHeaderData.CreationDate, MaterialNo, InventoryNo,tblDmc.PSN,count(tblDMC.PSN) over() as 'hours',DATEDIFF(MINUTE, tblDMC.CreationDate, getdate()) as 'time'from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)where tblHeaderData.InventoryNo  = '4211791' and tblDMC.CreationDate >= dateadd(hour, datediff(hour, 0, GETDATE()), 0)Order by tblHeaderData.CreationDate DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    T05_last.ItemsSource = dt.DefaultView;
                }
            }
            //t05 ile wyprodukowano
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

            //T06 głowne dane produkcyjne
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
            //T06 ile od ostatniej sztuki
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 1 tblHeaderData.CreationDate, MaterialNo, InventoryNo,tblDmc.PSN,count(tblDMC.PSN) over() as 'hours',DATEDIFF(MINUTE, tblDMC.CreationDate, getdate()) as 'time'from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)where tblHeaderData.InventoryNo  = '421998' and tblDMC.CreationDate >= dateadd(hour, datediff(hour, 0, GETDATE()), 0)Order by tblHeaderData.CreationDate DESC";

                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    T06_last.ItemsSource = dt.DefaultView;
                }
            }
            //t06 ile sztuk  wyprodukowano
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();//otwarcie połączenie
                string sqlQuery = "select TOP 1 tblHeaderData.ProductionOrder, Count (DISTINCT tblDMC.DMC) as'pcs'" +
                    "from (tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN)" +
                    "where tblHeaderData.InventoryNo = '421998' and tblDMC.CodeAnalysisText = 'BidiProcess' group by tblHeaderData.ProductionOrder order by MAX(tblDMC.CreationDate) DESC";
                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    quantity_t06.ItemsSource = dt.DefaultView;
                }
            }




        }


    }
}
