using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panel_Lidera_Linii
{
    /// <summary>
    /// 
    /// </summary>
    public static class Pomocniczna
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a">
        /// Parametr przyjmuje łańcuch znaków STRING
        /// </param>
        /// <returns>
        /// Zwraca wartość BOOL, która następnie jest testowana.
        /// </returns>
        public static bool popr_kod(string a)
        {
            if (a.Contains("%"))
            {
               return  false;
            }
           else  if (a == "")
            {
                return false;
            }
            else if (a.Length >=40)
            {
                return false ;
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="b">
        /// Parametr przyjmuje łańcuch znaków STRING
        /// </param>
        /// <returns>
        /// Zwraca wartość BOOL, która następnie jest testowana.
        /// </returns>
        public static bool kod_lid(string b)
        {
            
           if (b == "")
            {
                return false;
            }
            else if (b.Length >= 10)
            {
                return false;
            }
            else
            {
                return true;
            }
        }



    }
}
