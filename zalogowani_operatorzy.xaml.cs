using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace Panel_Lidera_Linii
{
    /// <summary>
    ///     Logika interakcji dla klasy zalogowani_operatorzy.xaml
    /// </summary>
    public partial class zalogowani_operatorzy : Window
    {
        //poniżej parametry połączenia z bazą danych //
        private static readonly string _connectionString =
            ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        private SqlCommand cmd;
        private SqlDataAdapter adpt;
        private DataTable dt;

        public zalogowani_operatorzy()
        {
            InitializeComponent();
        }

        private void downlad_all(object sender, RoutedEventArgs e)
        {
            using (var con = new SqlConnection(_connectionString))
            {
                con.Open(); //otwarcie połączenie
                var sqlQuery =
                    "select TOP 1 Worker,LastName,FirstName from [turboPCSProduction].[dbo].[tblHeaderData] as t1 inner join [turboPCSTools].[dbo].[tblRigManPerson] as t2 on t1.Worker = t2.PersonalNo where InventoryNo = '421050'and CreationDate >= dateadd(HOUR, datediff(HOUR, 0, GETDATE()), 0) order by CreationDate DESC";
                using (var a = new SqlDataAdapter(sqlQuery, con))
                {
                    var dt = new DataTable();
                    a.Fill(dt);
                    C01.ItemsSource = dt.DefaultView;
                }

                var sqlQuery2 =
                    "select TOP 1 Worker,LastName,FirstName from [turboPCSProduction].[dbo].[tblHeaderData] as t1 inner join [turboPCSTools].[dbo].[tblRigManPerson] as t2 on t1.Worker = t2.PersonalNo where InventoryNo = '421913' and CreationDate >= dateadd(HOUR, datediff(HOUR, 0, GETDATE()), 0) order by CreationDate DESC";
                using (var a = new SqlDataAdapter(sqlQuery2, con))
                {
                    var dt = new DataTable();
                    a.Fill(dt);
                    C02.ItemsSource = dt.DefaultView;
                }

                var sqlQuery3 =
                    "select TOP 1 Worker,LastName,FirstName from [turboPCSProduction].[dbo].[tblHeaderData] as t1 inner join [turboPCSTools].[dbo].[tblRigManPerson] as t2 on t1.Worker = t2.PersonalNo where InventoryNo = '444444' and CreationDate >= dateadd(HOUR, datediff(HOUR, 0, GETDATE()), 0) order by CreationDate DESC";
                using (var a = new SqlDataAdapter(sqlQuery3, con))
                {
                    var dt = new DataTable();
                    a.Fill(dt);
                    C03.ItemsSource = dt.DefaultView;
                }

                var sqlQuery4 =
                    "select TOP 1 Worker,LastName,FirstName from [turboPCSProduction].[dbo].[tblHeaderData] as t1 inner join [turboPCSTools].[dbo].[tblRigManPerson] as t2 on t1.Worker = t2.PersonalNo where InventoryNo = '421008' and CreationDate >= dateadd(HOUR, datediff(HOUR, 0, GETDATE()), 0) order by CreationDate DESC";
                using (var a = new SqlDataAdapter(sqlQuery4, con))
                {
                    var dt = new DataTable();
                    a.Fill(dt);
                    C04.ItemsSource = dt.DefaultView;
                }

                var sqlQuery5 =
                    "select TOP 1 Worker,LastName,FirstName from [turboPCSProduction].[dbo].[tblHeaderData] as t1 inner join [turboPCSTools].[dbo].[tblRigManPerson] as t2 on t1.Worker = t2.PersonalNo where InventoryNo = '421051' and CreationDate >= dateadd(HOUR, datediff(HOUR, 0, GETDATE()), 0) order by CreationDate DESC";
                using (var a = new SqlDataAdapter(sqlQuery5, con))
                {
                    var dt = new DataTable();
                    a.Fill(dt);
                    T01_032.ItemsSource = dt.DefaultView;
                }

                var sqlQuery6 =
                    "select TOP 1 Worker,LastName,FirstName from [turboPCSProduction].[dbo].[tblHeaderData] as t1 inner join [turboPCSTools].[dbo].[tblRigManPerson] as t2 on t1.Worker = t2.PersonalNo where InventoryNo = '421052' and CreationDate >= dateadd(HOUR, datediff(HOUR, 0, GETDATE()), 0) order by CreationDate DESC";
                using (var a = new SqlDataAdapter(sqlQuery6, con))
                {
                    var dt = new DataTable();
                    a.Fill(dt);
                    T01_042.ItemsSource = dt.DefaultView;
                }

                var sqlQuery7 =
                    "select TOP 1 Worker,LastName,FirstName from [turboPCSProduction].[dbo].[tblHeaderData] as t1 inner join [turboPCSTools].[dbo].[tblRigManPerson] as t2 on t1.Worker = t2.PersonalNo where InventoryNo = '421011' and CreationDate >= dateadd(HOUR, datediff(HOUR, 0, GETDATE()), 0) order by CreationDate DESC";
                using (var a = new SqlDataAdapter(sqlQuery7, con))
                {
                    var dt = new DataTable();
                    a.Fill(dt);
                    T02_031.ItemsSource = dt.DefaultView;
                }

                var sqlQuery8 =
                    "select TOP 1 Worker,LastName,FirstName from [turboPCSProduction].[dbo].[tblHeaderData] as t1 inner join [turboPCSTools].[dbo].[tblRigManPerson] as t2 on t1.Worker = t2.PersonalNo where InventoryNo = '421976' and CreationDate >= dateadd(HOUR, datediff(HOUR, 0, GETDATE()), 0) order by CreationDate DESC";
                using (var a = new SqlDataAdapter(sqlQuery8, con))
                {
                    var dt = new DataTable();
                    a.Fill(dt);
                    T02_032.ItemsSource = dt.DefaultView;
                }

                var sqlQuery9 =
                    "select TOP 1 Worker,LastName,FirstName from [turboPCSProduction].[dbo].[tblHeaderData] as t1 inner join [turboPCSTools].[dbo].[tblRigManPerson] as t2 on t1.Worker = t2.PersonalNo where InventoryNo = '421978' and CreationDate >= dateadd(HOUR, datediff(HOUR, 0, GETDATE()), 0) order by CreationDate DESC";
                using (var a = new SqlDataAdapter(sqlQuery9, con))
                {
                    var dt = new DataTable();
                    a.Fill(dt);
                    T02_042.ItemsSource = dt.DefaultView;
                }

                var sqlQuery10 =
                    "select TOP 1 Worker,LastName,FirstName from [turboPCSProduction].[dbo].[tblHeaderData] as t1 inner join [turboPCSTools].[dbo].[tblRigManPerson] as t2 on t1.Worker = t2.PersonalNo where InventoryNo = '421977' and CreationDate >= dateadd(HOUR, datediff(HOUR, 0, GETDATE()), 0) order by CreationDate DESC";
                using (var a = new SqlDataAdapter(sqlQuery10, con))
                {
                    var dt = new DataTable();
                    a.Fill(dt);
                    T02_062.ItemsSource = dt.DefaultView;
                }

                var sqlQuery11 =
                    "select TOP 1 Worker,LastName,FirstName from [turboPCSProduction].[dbo].[tblHeaderData] as t1 inner join [turboPCSTools].[dbo].[tblRigManPerson] as t2 on t1.Worker = t2.PersonalNo where InventoryNo = '421975' and CreationDate >= dateadd(HOUR, datediff(HOUR, 0, GETDATE()), 0) order by CreationDate DESC";
                using (var a = new SqlDataAdapter(sqlQuery11, con))
                {
                    var dt = new DataTable();
                    a.Fill(dt);
                    T02_072.ItemsSource = dt.DefaultView;
                }

                var sqlQuery12 =
                    "select TOP 1 Worker,LastName,FirstName from [turboPCSProduction].[dbo].[tblHeaderData] as t1 inner join [turboPCSTools].[dbo].[tblRigManPerson] as t2 on t1.Worker = t2.PersonalNo where InventoryNo = '421910' and CreationDate >= dateadd(HOUR, datediff(HOUR, 0, GETDATE()), 0) order by CreationDate DESC";
                using (var a = new SqlDataAdapter(sqlQuery12, con))
                {
                    var dt = new DataTable();
                    a.Fill(dt);
                    T03_032.ItemsSource = dt.DefaultView;
                }

                var sqlQuery13 =
                    "select TOP 1 Worker,LastName,FirstName from [turboPCSProduction].[dbo].[tblHeaderData] as t1 inner join [turboPCSTools].[dbo].[tblRigManPerson] as t2 on t1.Worker = t2.PersonalNo where InventoryNo = '421022' and CreationDate >= dateadd(HOUR, datediff(HOUR, 0, GETDATE()), 0) order by CreationDate DESC";
                using (var a = new SqlDataAdapter(sqlQuery13, con))
                {
                    var dt = new DataTable();
                    a.Fill(dt);
                    T03_042.ItemsSource = dt.DefaultView;
                }

                var sqlQuery14 =
                    "select TOP 1 Worker,LastName,FirstName from [turboPCSProduction].[dbo].[tblHeaderData] as t1 inner join [turboPCSTools].[dbo].[tblRigManPerson] as t2 on t1.Worker = t2.PersonalNo where InventoryNo = '422263' and CreationDate >= dateadd(HOUR, datediff(HOUR, 0, GETDATE()), 0) order by CreationDate DESC";
                using (var a = new SqlDataAdapter(sqlQuery14, con))
                {
                    var dt = new DataTable();
                    a.Fill(dt);
                    T04_032.ItemsSource = dt.DefaultView;
                }

                var sqlQuery15 =
                    "select TOP 1 Worker,LastName,FirstName from [turboPCSProduction].[dbo].[tblHeaderData] as t1 inner join [turboPCSTools].[dbo].[tblRigManPerson] as t2 on t1.Worker = t2.PersonalNo where InventoryNo = '422261' and CreationDate >= dateadd(HOUR, datediff(HOUR, 0, GETDATE()), 0) order by CreationDate DESC";
                using (var a = new SqlDataAdapter(sqlQuery15, con))
                {
                    var dt = new DataTable();
                    a.Fill(dt);
                    T04_042.ItemsSource = dt.DefaultView;
                }

                var sqlQuery16 =
                    "select TOP 1 Worker,LastName,FirstName from [turboPCSProduction].[dbo].[tblHeaderData] as t1 inner join [turboPCSTools].[dbo].[tblRigManPerson] as t2 on t1.Worker = t2.PersonalNo where InventoryNo = '4211792' and CreationDate >= dateadd(HOUR, datediff(HOUR, 0, GETDATE()), 0) order by CreationDate DESC";
                using (var a = new SqlDataAdapter(sqlQuery16, con))
                {
                    var dt = new DataTable();
                    a.Fill(dt);
                    T05_032.ItemsSource = dt.DefaultView;
                }

                var sqlQuery17 =
                    "select TOP 1 Worker,LastName,FirstName from [turboPCSProduction].[dbo].[tblHeaderData] as t1 inner join [turboPCSTools].[dbo].[tblRigManPerson] as t2 on t1.Worker = t2.PersonalNo where InventoryNo = '4211791' and CreationDate >= dateadd(HOUR, datediff(HOUR, 0, GETDATE()), 0) order by CreationDate DESC";
                using (var a = new SqlDataAdapter(sqlQuery17, con))
                {
                    var dt = new DataTable();
                    a.Fill(dt);
                    T05_042.ItemsSource = dt.DefaultView;
                }

                var sqlQuery18 =
                    "select TOP 1 Worker,LastName,FirstName from [turboPCSProduction].[dbo].[tblHeaderData] as t1 inner join [turboPCSTools].[dbo].[tblRigManPerson] as t2 on t1.Worker = t2.PersonalNo where InventoryNo = '421997' and CreationDate >= dateadd(HOUR, datediff(HOUR, 0, GETDATE()), 0) order by CreationDate DESC";
                using (var a = new SqlDataAdapter(sqlQuery18, con))
                {
                    var dt = new DataTable();
                    a.Fill(dt);
                    T06_032.ItemsSource = dt.DefaultView;
                }

                var sqlQuery19 =
                    "select TOP 1 Worker,LastName,FirstName from [turboPCSProduction].[dbo].[tblHeaderData] as t1 inner join [turboPCSTools].[dbo].[tblRigManPerson] as t2 on t1.Worker = t2.PersonalNo where InventoryNo = '421998' and CreationDate >= dateadd(HOUR, datediff(HOUR, 0, GETDATE()), 0) order by CreationDate DESC";
                using (var a = new SqlDataAdapter(sqlQuery19, con))
                {
                    var dt = new DataTable();
                    a.Fill(dt);
                    T06_042.ItemsSource = dt.DefaultView;
                }

                var sqlQuery20 =
                    "select TOP 1 Worker,LastName,FirstName from [turboPCSProduction].[dbo].[tblHeaderData] as t1 inner join [turboPCSTools].[dbo].[tblRigManPerson] as t2 on t1.Worker = t2.PersonalNo where InventoryNo = '421914' order by CreationDate DESC";
                using (var a = new SqlDataAdapter(sqlQuery20, con))
                {
                    var dt = new DataTable();
                    a.Fill(dt);
                    B02.ItemsSource = dt.DefaultView;
                }

                con.Close();
            }
        }
    }
}
