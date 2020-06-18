using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;
using NLog;
using Panel_Lidera_Linii.Helper;
using Panel_Lidera_Linii.ViewModels;

namespace Panel_Lidera_Linii.Views
{
    public partial class current_production : Window
    {
        protected readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public current_production()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                Logger.Fatal(ex);
            }
        }
    }
}
