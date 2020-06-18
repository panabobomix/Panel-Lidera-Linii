using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panel_Lidera_Linii.ViewModels
{
   public class tblHeaderData
    {
        public int ID { get; set; }
        public string PSN { get; set; }
        public int Status { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? DBInsertDatetime { get; set; }
        public string MaterialNo { get; set; }
        public string ProductionOrder { get; set; }
        public string InventoryNo { get; set; }
        public string Worker { get; set; }
        public string Version { get; set; }
    }

   public partial class tblHeaderDataView : tblHeaderData
   {
       public string CreationDate { get; set; }

    }

}
