using System.Reflection;

namespace SamanKish.Agg.Models
{
    public class BaseRequestModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        /// <summary>
        /// from milliSeconds
        /// </summary>
        public int TimeOut { get; set; } = 100_000;
    }
}
