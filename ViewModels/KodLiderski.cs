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
    /// Klasa dla kodu liderskiego
    /// </summary>
   public class KodLiderski:LoggerBase
    {
        private static string _connectionString = Configuration.ConnectionString;

        public static async Task Load(MyObservableCollection<tblDMCView> dataItems, Filter _filter)
        {
            await Task.Run(() =>
            {
                try
                {
                    using (var con = new SqlConnection(_connectionString))
                    {
                        //KOD LIDERSKI
                        con.Open(); //otwarcie połączenie
                        var sqlQuery = String.Format("select tblHeaderData.InventoryNo, tblHeaderData.CreationDate" +
                                                      "from tblHeaderData " +
                                                      "inner join tblDMC on tblDMC.PSN = tblHeaderData.PSN" +
                                                      "where tblDMC.DMC = '{0}' and tblDMC.CreationDate > DATEADD(hh, -72,GETDATE())" +
                                                      "order by tblHeaderData.CreationDate DESC", _filter.DMC);
                        using (var a = new SqlDataAdapter(sqlQuery, con))
                        {
                            var dt = new DataTable();
                            a.Fill(dt);
                            if (dt.Rows.Count > 0)
                            {
                                if (dt.Rows.Count > 1)
                                {
                                    MessageBox.Show("Znaleziono więcej niż 1 element");
                                    //error
                                }

                                DataRow _dataRow = dt.Rows[0];
                                App.Current.Dispatcher.Invoke((Action) delegate
                                {
                                    dataItems.Clear();
                                   dataItems.Add(new tblDMCView()
                                   {
                                        kod = _dataRow["kod"].ToString()
                                    });
                                });
                            }
                            else
                            {
                                 MessageBox.Show("Brak elementu");
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
