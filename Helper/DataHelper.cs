using System;
using System.Data;
using Panel_Lidera_Linii.Model;
using Panel_Lidera_Linii.ViewModels;

namespace Panel_Lidera_Linii.Helper
{
    public class DataHelper : LoggerBase
    {
        public static void BindData(MyObservableCollection<tblHeaderDataView> dataItems, DataRow _dataRow)
        {
            try
            {
                App.Current.Dispatcher.Invoke((Action) delegate
                {
                    if (
                        _dataRow.Table.Columns.Contains("MaterialNo") &&
                        _dataRow.Table.Columns.Contains("CreationDate")
                    )
                    {
                        dataItems.Clear();
                        dataItems.Add(new tblHeaderDataView()
                        {
                            MaterialNo = _dataRow["MaterialNo"].ToString(),
                            CreationDate = _dataRow["CreationDate"].ToString()
                            // CreationDate = DateTime.Now.ToUniversalTime().ToString()
                        });
                    }

                    if (
                        _dataRow.Table.Columns.Contains("hours"))
                    {
                        dataItems.Last.Clear();
                        dataItems.Last.Add(new tblAtlasCopcoView()
                        {
                            hours = _dataRow["hours"].ToString()
                           
                        });
                    }

                    if (
                        _dataRow.Table.Columns.Contains("pcs")
                    )
                    {
                        dataItems.Quantity.Clear();
                        dataItems.Quantity.Add(new tblDMCView()
                        {
                            pcs = _dataRow["pcs"].ToString()
                        });
                    }

                    
                });
            }
            catch (Exception ex)
            {
                Logger.Fatal(ex);
            }
        }
    }
}
