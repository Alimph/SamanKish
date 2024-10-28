using System.Collections.Generic;

namespace SamanKish.Agg.Models
{
    public class UserNotifiable
    {
        /// <summary> 
        /// متن چاپ در پایین رسید
        /// </summary> 

        public string FooterMessage { get; set; }
        /// آیتم و مقدار چاپ در بالا رسید
        /// </summary> 

        public List<PrintItem> PrintItems { get; set; }

    }
}
