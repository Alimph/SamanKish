using System.Globalization;

namespace SamanKish.Agg.Models
{
    public class ResponseModel
    {
        public bool IsSuccess { get; set; }
        public int ErrorCode { get; set; }
        public string ErrorDescription { get; set; }
        public object Data { get; set; }
    }
}
