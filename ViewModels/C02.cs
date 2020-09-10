using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Panel_Lidera_Linii.Helper;
using Panel_Lidera_Linii.Model;

namespace Panel_Lidera_Linii.ViewModels
{
    /// <summary>
    /// Klasa dla C02
    /// </summary>
    public class C02 : LoggerBase
    {
        private static string _connectionString = Configuration.ConnectionString;

        public static async Task Load(MyObservableCollection<tblHeaderDataView> dataItems, Filter _filter)
        {
            await Task.Run(() =>
            {
                try
                {
                    using (var con = new SqlConnection(_connectionString))
                    {
                        //C02 głowne dane produkcyjne
                        con.Open(); //otwarcie połączenie
                        var sqlQuery = String.Format(
                            "select TOP 1 MaterialNo, CreationDate from tblHeaderData Where InventoryNo = '{0}' Order by CreationDate DESC",
                            _filter.InventoryNo);
                        //C02 ile od ostatniej sztuki
                        var sqlQuery2 = String.Format(
                            "select TOP 1 " +
                            " count(tblAtlasCopco.PSN) over() as 'hours'," +
                            " DATEDIFF(MINUTE, tblAtlasCopco.CreationDate, getdate()) as 'time' " +
                            " from tblHeaderData " +
                            " inner join tblAtlasCopco on tblHeaderData.PSN = tblAtlasCopco.PSN" +
                            " where tblHeaderData.InventoryNo  = '{0}' and " +
                            " (TighteningType = 'Nakretka walka' OR TighteningType = 'Back plate') and " +
                            " tblAtlasCopco.CreationDate >= dateadd(hour, datediff(hour, 0, GETDATE()), 0)" +
                            " Order by tblHeaderData.CreationDate DESC", _filter.InventoryNo);

                        //C02 ile sztuk wyprodukowanych
                        
                        var sqlQuery3 = String.Format("select TOP 1 Count (DISTINCT tblDMC.DMC) as 'pcs'" +
                                                      " from tblHeaderData" +
                                                      " inner join tblDMC on tblHeaderData.PSN = tblDMC.PSN" +
                                                      " where tblHeaderData.InventoryNo = '{0}' " +
                                                      " and (tblDMC.DMC like '20200%' OR tblDMC.DMC like '800511') group by tblHeaderData.ProductionOrder order by MAX(tblDMC.CreationDate) DESC",
                            _filter.InventoryNo);

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

                                DataRow _dataRow = dt.Rows[0];
                                DataHelper.BindData(dataItems, _dataRow);
                            }
                            else
                            {
                                // MessageBox.Show("Brak elementu");
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

                                DataRow _dataRow = dt.Rows[0];
                                DataHelper.BindData(dataItems, _dataRow);
                            }
                            else
                            {
                                // MessageBox.Show("Brak elementu");
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

                                DataRow _dataRow = dt.Rows[0];
                                DataHelper.BindData(dataItems, _dataRow);
                            }
                            else
                            {
                                // MessageBox.Show("Brak elementu");
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
