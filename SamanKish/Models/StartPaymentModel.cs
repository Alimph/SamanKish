using System;

namespace SamanKish.Agg.Models
{
    public class StartPaymentModel
    {
        public StartPaymentModel(string terminalId, string amount, string resNum, string item = "", string value = "")
        {
            TerminalID = terminalId;
            Amount = amount;
            Identifier = Guid.NewGuid().ToString();
            ResNum = resNum;
            UserNotifiable = new UserNotifiable
            {
                PrintItems = new System.Collections.Generic.List<PrintItem>
                {
                    new PrintItem(item,value,Alignment.Center,ReceiptType.Customer)
                }
            };
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
