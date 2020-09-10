using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panel_Lidera_Linii.Helper
{
    public class Configuration
    {
        private static string _connectionString =
            ConfigurationManager.ConnectionStrings["ConnectionString-borg"].ConnectionString;

        public static string ConnectionString
        {
            get
            {
                return _connectionString;
            }
        }

        private static int _refresh = 15;
/// <summary>
///  z jaka częstotliwością ma się odświeżać wątek - wartości podane w sekundach
/// jeśli puste - domyślnie 60 sekund
/// </summary>
        public static int Refresh
        {
            get
            {
                int number;

                string _tmpNumber = ConfigurationManager.AppSettings["refresh"];
                bool success = Int32.TryParse(_tmpNumber, out number);
                if (success)
                {
                    return number;
                }
                return _refresh;
            }
        }
    }







}
