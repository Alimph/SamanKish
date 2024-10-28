using Newtonsoft.Json;

namespace SamanKish.Agg.Models
{
    public class TokenModel
    {
        [JsonProperty("access_token")]
        public string Token{ get; set; }
    }
}
