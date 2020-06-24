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
using Panel_Lidera_Linii.Helper;
using Configuration = Panel_Lidera_Linii.Helper.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Panel_Lidera_Linii
{
    /// <summary>
    /// Logika interakcji dla klasy status_dmc.xaml
    /// </summary>
    public partial class status_dmc : Window
    {
        static string _connectionString = Configuration.ConnectionString;

        SqlCommand cmd, cmd2;
        SqlDataAdapter adpt, adpt2;
        DataTable dt;

       

        SqlDataReader reader, reader2;

        public status_dmc()
        {
            InitializeComponent();
        }


        private void search(object sender, RoutedEventArgs e)
        {
            //Zapytanie o sztukę
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open(); //otwarcie połączenie
                string sqlQuery = "select tblHeaderData.CreationDate,MaterialNo,ProductionOrder,InventoryNo,Worker from(tblHeaderData inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN) where tblDMC.DMC like '" +search_box.Text + "'order by tblDMC.CreationDate DESC";
                using (SqlDataAdapter a = new SqlDataAdapter(sqlQuery, con))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    grid_search.ItemsSource = dt.DefaultView;
                }

                con.Close();
            }


        }
    }
}
