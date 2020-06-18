using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Panel_Lidera_Linii.Wpf;

namespace Panel_Lidera_Linii
{
    /// <summary>
    /// Logika interakcji dla klasy App.xaml
    /// </summary>
    public partial class App : Application
    {
        internal static Messenger Messenger
        {
            get { return _messenger; }
        }
        readonly static Messenger _messenger = new Messenger();
    }
}
