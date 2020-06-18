using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panel_Lidera_Linii.ViewModels
{
    public class tblAtlasCopco
    {
        public int ID { get; set; }
        public string PSN { get; set; }
        public int Status { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? DBInsertDatetime { get; set; }
        public string TighteningType { get; set; }
        public int? Number { get; set; }
        public string PF_Name { get; set; }
        public int ParameterSet { get; set; }
        public string Torque_Status { get; set; }
        public string Angle_Status { get; set; }
        public float Torque_Min { get; set; }
        public float Torque_Max { get; set; }
        public float Torque_Nominal { get; set; }
        public float Torque_Actual { get; set; }
        public int Angle_Min { get; set; }
        public int Angle_Max { get; set; }
        public int Angle_Nominal { get; set; }
        public int Angle_Actual { get; set; }
        public DateTime? PF_TimeStamp { get; set; }
        public DateTime? PSet_TimeStamp { get; set; }
        public string BatchStatus { get; set; }
        public string TighteningID { get; set; }
        public string ScrewdriverSerialNo { get; set; }
        public string ScrewdriverCalibrationDate { get; set; }
        public string ErrorCode { get; set; }
        public int GradientMonitoringONOFF { get; set; }
        public float GradientTorqueMin { get; set; }
        public float GradientTorqueMax { get; set; }
        public float GradientJointHardness { get; set; }
    }

    public partial class tblAtlasCopcoView : tblAtlasCopco
    {
        public string hours { get; set; }
        public string time { get; set; }
    }
}
