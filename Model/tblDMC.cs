using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Panel_Lidera_Linii.ViewModels
{
    public class tblDMC
    {
        public int ID { get; set; }
        public string PSN { get; set; }
        public int Status { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? DBInsertDatetime { get; set; }
        public string MateriDMCalNo { get; set; }
        public string Description { get; set; }
        public string CodeType { get; set; }
        public string CodeAnalysisText { get; set; }
        public int TraceConnected { get; set; }
    }

    public partial class tblDMCView   :tblDMC
    {
        public string pcs { get; set; }
        public string kod { get; set; }
    }
}
