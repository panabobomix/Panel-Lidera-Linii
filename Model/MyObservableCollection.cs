using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Panel_Lidera_Linii.ViewModels;

namespace Panel_Lidera_Linii.Model
{

    public class MyObservableCollection<T> : ObservableCollection<T>
    {
        public MyObservableCollection<tblHeaderDataView> C01 { get; set; }
        public MyObservableCollection<tblHeaderDataView> C02 { get; set; }
        public MyObservableCollection<tblHeaderDataView> C03 { get; set; }
        public MyObservableCollection<tblHeaderDataView> C04 { get; set; }
        public MyObservableCollection<tblHeaderDataView> B02 { get; set; }
        public MyObservableCollection<tblHeaderDataView> T01 { get; set; }
        public MyObservableCollection<tblHeaderDataView> T02 { get; set; }
        public MyObservableCollection<tblHeaderDataView> T03 { get; set; }
        public MyObservableCollection<tblHeaderDataView> T04 { get; set; }
        public MyObservableCollection<tblHeaderDataView> T05 { get; set; }
        public MyObservableCollection<tblHeaderDataView> T06 { get; set; }
        public MyObservableCollection<tblDMCView> KodLiderski { get; set; }
        public MyObservableCollection<tblDMCView> Quantity { get; set; }
        public MyObservableCollection<tblAtlasCopcoView> Last { get; set; }
    } // class MyObservableCollection
}
