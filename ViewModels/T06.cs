using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Panel_Lidera_Linii.Helper;
using Panel_Lidera_Linii.Model;

namespace Panel_Lidera_Linii.ViewModels
{
    /// <summary>
    /// Klasa dla T06
    /// </summary>
    public class T06 : LoggerBase
    {
        private static readonly string ConnectionString = Configuration.ConnectionString;

        public static async Task<int> LoadAsync()
        {
         return await Task.FromResult(1);
        }
        public static async Task Load(MyObservableCollection<tblHeaderDataView> dataItems, Filter filter)
        {
            await Task.Run(() =>
            {
                try
                {
                    using (var con = new SqlConnection(ConnectionString))
                    {
                        //T06 głowne dane produkcyjne
                        con.Open(); //otwarcie połączenie
                        var sqlQuery = string.Format(
                            "select TOP 1 MaterialNo, CreationDate from tblHeaderData Where InventoryNo = '{0}' Order by CreationDate DESC",
                            filter.InventoryNo);
                        //T06 ile od ostatniej sztuki
                        var sqlQuery2 = string.Format(
                            "select TOP 1 " +
                            " count(tblDMC.PSN) over() as 'hours'," +
                            " DATEDIFF(MINUTE, tblDMC.CreationDate, getdate()) as 'time'" +
                            " from tblHeaderData " +
                            " inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN" +
                            " where tblHeaderData.InventoryNo  = '{0}' and " +
                            " tblDMC.CreationDate >= dateadd(hour, datediff(hour, 0, GETDATE()), 0)" +
                            " Order by tblHeaderData.CreationDate DESC", filter.InventoryNo);

                        //T06 ile sztuk wyprodukowanych
                        var sqlQuery3 = string.Format("select TOP 1 Count (DISTINCT tblDMC.DMC) as 'pcs'" +
                                                      " from tblHeaderData" +
                                                      " inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN" +
                                                      " where tblHeaderData.InventoryNo = '{0}' AND" +
                                                      " tblDMC.CodeAnalysisText = 'BidiProcess' " +
                                                      " group by tblHeaderData.ProductionOrder" +
                                                      " order by MAX(tblDMC.CreationDate) DESC", filter.InventoryNo);

                        using (var a = new SqlDataAdapter(sqlQuery, con))
                        {
                            var dt = new DataTable();
                            a.Fill(dt);
                            if (dt.Rows.Count > 0)
                            {
                                if (dt.Rows.Count > 1)
                                {
                                    //MessageBox.Show("Znaleziono więcej niż 1 element");
                                    //error
                                }

                                var _dataRow = dt.Rows[0];
                                DataHelper.BindData(dataItems, _dataRow);
                            }
                        }

                        using (var a = new SqlDataAdapter(sqlQuery2, con))
                        {
                            var dt = new DataTable();
                            a.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {
                                if (dt.Rows.Count > 1)
                                {
                                    //MessageBox.Show("Znaleziono więcej niż 1 element");
                                    //error
                                }

                                var _dataRow = dt.Rows[0];
                                DataHelper.BindData(dataItems, _dataRow);
                            }
                        }

                        using (var a = new SqlDataAdapter(sqlQuery3, con))
                        {
                            var dt = new DataTable();
                            a.Fill(dt);
                            if (dt.Rows.Count > 0)
                            {
                                if (dt.Rows.Count > 1)
                                {
                                    //MessageBox.Show("Znaleziono więcej niż 1 element");
                                    //error
                                }

                                var _dataRow = dt.Rows[0];
                                DataHelper.BindData(dataItems, _dataRow);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Logger.Fatal(ex);
                }
            });
        }
    }
}
