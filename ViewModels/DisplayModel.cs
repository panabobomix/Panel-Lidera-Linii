using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Input;
using Panel_Lidera_Linii.Helper;
using Panel_Lidera_Linii.Model;
using Panel_Lidera_Linii.Wpf;

namespace Panel_Lidera_Linii.ViewModels
{
    public class DisplayModel : LoggerBase, INotifyPropertyChanged
    {
        private async void RunTasks()
        {
            try
            {
                if (Initialization())
                {
                    while (true)
                    {
                        await Task.Run(() => GetItemsAsync());
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Fatal(ex);
            }
        }

        private async Task GetItemsAsync()
        {
            await Task.Run(() => C01.Load(dataItems.C01, new Filter() {InventoryNo = "421050"}));
            await Task.Run(() => C02.Load(dataItems.C02, new Filter() {InventoryNo = "421913"}));
            await Task.Run(() => C03.Load(dataItems.C03, new Filter() {InventoryNo = "444444"}));
            await Task.Run(() => C04.Load(dataItems.C04, new Filter() {InventoryNo = "421008"}));
            await Task.Run(() => B02.Load(dataItems.B02, new Filter() {InventoryNo = "421914"}));
            await Task.Run(() => T01.Load(dataItems.T01, new Filter() {InventoryNo = "421052"}));
            await Task.Run(() => T02.Load(dataItems.T02, new Filter() {InventoryNo = "421978"}));
            await Task.Run(() => T03.Load(dataItems.T03, new Filter() {InventoryNo = "421022"}));
            await Task.Run(() => T04.Load(dataItems.T04, new Filter() {InventoryNo = "422261"}));
            await Task.Run(() => T05.Load(dataItems.T05, new Filter() {InventoryNo = "4211791"}));
            await Task.Run(() => T06.Load(dataItems.T06, new Filter() {InventoryNo = "421998"}));
            await Task.Run(() =>
                KodLiderski.Load(dataItems.KodLiderski, new Filter() {DMC = "1234567851247921547921475320"}));
            await Task.Delay(TimeSpan.FromSeconds(Configuration.Refresh));
        }

        public DisplayModel()
        {
            RunTasks();
            App.Messenger.Register("GetItems", (Action) (() => GetItems()));
        }

        private bool Initialization()
        {
            try
            {
                dataItems = new MyObservableCollection<tblHeaderDataView>()
                {
                    C01 = new MyObservableCollection<tblHeaderDataView>()
                    {
                        Last = new MyObservableCollection<tblAtlasCopcoView>(),
                        Quantity = new MyObservableCollection<tblDMCView>()
                    },
                    C02 = new MyObservableCollection<tblHeaderDataView>()
                    {
                        Last = new MyObservableCollection<tblAtlasCopcoView>(),
                        Quantity = new MyObservableCollection<tblDMCView>()
                    },
                    C03 = new MyObservableCollection<tblHeaderDataView>()
                    {
                        Last = new MyObservableCollection<tblAtlasCopcoView>(),
                        Quantity = new MyObservableCollection<tblDMCView>()
                    },
                    C04 = new MyObservableCollection<tblHeaderDataView>()
                    {
                        Last = new MyObservableCollection<tblAtlasCopcoView>(),
                        Quantity = new MyObservableCollection<tblDMCView>()
                    },
                    B02 = new MyObservableCollection<tblHeaderDataView>()
                    {
                        Last = new MyObservableCollection<tblAtlasCopcoView>(),
                        Quantity = new MyObservableCollection<tblDMCView>()
                    },
                    T01 = new MyObservableCollection<tblHeaderDataView>()
                    {
                        Last = new MyObservableCollection<tblAtlasCopcoView>(),
                        Quantity = new MyObservableCollection<tblDMCView>()
                    },
                    T02 = new MyObservableCollection<tblHeaderDataView>()
                    {
                        Last = new MyObservableCollection<tblAtlasCopcoView>(),
                        Quantity = new MyObservableCollection<tblDMCView>()
                    },
                    T03 = new MyObservableCollection<tblHeaderDataView>()
                    {
                        Last = new MyObservableCollection<tblAtlasCopcoView>(),
                        Quantity = new MyObservableCollection<tblDMCView>()
                    },
                    T04 = new MyObservableCollection<tblHeaderDataView>()
                    {
                        Last = new MyObservableCollection<tblAtlasCopcoView>(),
                        Quantity = new MyObservableCollection<tblDMCView>()
                    },
                    T05 = new MyObservableCollection<tblHeaderDataView>()
                    {
                        Last = new MyObservableCollection<tblAtlasCopcoView>(),
                        Quantity = new MyObservableCollection<tblDMCView>()
                    },
                    T06 = new MyObservableCollection<tblHeaderDataView>()
                    {
                        Last = new MyObservableCollection<tblAtlasCopcoView>(),
                        Quantity = new MyObservableCollection<tblDMCView>()
                    },
                };

                return true;
            }
            catch (Exception ex)
            {
                Logger.Fatal(ex);
                return false;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, e);
            }
        }

        private MyObservableCollection<tblHeaderDataView> dataItems;

        public MyObservableCollection<tblHeaderDataView> DataItems
        {
            get { return dataItems; }
            set
            {
                dataItems = value;
                OnPropertyChanged(new PropertyChangedEventArgs("DataItems"));
            }
        }

        private RelayCommand getItemsCommand;

        public ICommand GetItemsCommand
        {
            get { return getItemsCommand ?? (getItemsCommand = new RelayCommand(() => GetItems())); }
        }


        private void GetItems()
        {
            _ = C01.Load(dataItems.C01, new Filter() { InventoryNo = "421050" });
            _ = C02.Load(dataItems.C02, new Filter() {InventoryNo = "421913"});
            _ = C03.Load(dataItems.C03, new Filter() {InventoryNo = "444444"});
            _ = C04.Load(dataItems.C04, new Filter() {InventoryNo = "421008"});
            _ = B02.Load(dataItems.B02, new Filter() {InventoryNo = "421914"});
            _ = T01.Load(dataItems.T01, new Filter() {InventoryNo = "421052"});
            _ = T02.Load(dataItems.T02, new Filter() {InventoryNo = "421978"});
            _ = T03.Load(dataItems.T03, new Filter() {InventoryNo = "421022"});
            _ = T04.Load(dataItems.T04, new Filter() {InventoryNo = "422261"});
            _ = T05.Load(dataItems.T05, new Filter() {InventoryNo = "4211791"});
            _ = T06.Load(dataItems.T06, new Filter() {InventoryNo = "421998"});
            _ = KodLiderski.Load(dataItems.KodLiderski, new Filter() {DMC = "1234567851247921547921475320"});
        }
    }
}
