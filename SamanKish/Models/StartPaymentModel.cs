namespace SamanKish.Agg.Models
{
    public class StartPaymentModel
    {
        public StartPaymentModel(string terminalId, string amount, string identifier, string resNum)
        {
            TerminalID = terminalId;
            Amount = amount;
            Identifier = identifier;
            ResNum = resNum;
        }
        public string TerminalID { get; set; }
        public string Amount { get; set; }
        //single
        public int TransactionType { get; set; } = 0;
        /// <summary>
        /// شماره فاکتور
        /// </summary>
        public string ResNum { get; set; }
        public string Identifier { get; set; }
        /// <summary>
        /// purchase
        /// </summary>
        public int AccountType { get; set; } = 0;
        public UserNotifiable UserNotifiable { get; set; }
    }
}
