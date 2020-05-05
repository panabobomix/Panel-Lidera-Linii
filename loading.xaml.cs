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
using System.Timers;
using System.Windows.Threading;

namespace Panel_Lidera_Linii
{
    /// <summary>
    /// Logika interakcji dla klasy loading.xaml
    /// </summary>
    public partial class loading : Window
    {
        public loading()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(1800);
            timer.Tick += timer_Tick;
            timer.Start();

        }

        void timer_Tick(object sender, EventArgs e)
        {
            progress.Minimum = 0;
            progress.Maximum = 100;

            if ( progress.Value < progress.Maximum)
            {
                progress.Value = progress.Value + 5 ;

            }
            if (progress.Value  == 95)
            {
                MessageBox.Show("Ładowanie zakończone");
                

            }
        }

    }
}
