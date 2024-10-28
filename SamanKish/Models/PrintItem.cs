namespace SamanKish.Agg.Models
{
    public class PrintItem
    {
        #region Properties 
        public string Item { get; set; }
        public string Value { get; set; }
        public Alignment Alignment { get; set; }
        public ReceiptType ReceiptType { get; set; }

        #endregion

        #region Constructor 

        public PrintItem(string item, string value, Alignment alignment,
                        ReceiptType receiptType)
        {
            Item = item;
            Value = value;
            Alignment = alignment;
            ReceiptType = receiptType;
        }
    }
    #endregion
}
