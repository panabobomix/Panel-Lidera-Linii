namespace Panel_Lidera_Linii.Helper
{
    public class Filter
    {
        private string _InventoryNo;
        private string _DMC;
        public string InventoryNo
        {
            get
            {
                return _InventoryNo;
            }
            set
            {
                _InventoryNo = value;
            }
        }
        public string DMC
        {
            get
            {
                return _DMC;
            }
            set
            {
                _DMC = value;
            }
        }
    }
}
