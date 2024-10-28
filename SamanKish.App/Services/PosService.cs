using Newtonsoft.Json;
using RestSharp;
using SamanKish.Agg.Infrastructures;
using SamanKish.Agg.Interfaces;
using SamanKish.Agg.Models;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace SamanKish.App.Services
{
    public class PosService : IPosService
    {
        public async Task StartPayment(BaseRequestModel baseModel, StartPaymentModel paymentModel)
        {
            var token = await GetTokenAsync(baseModel);
            try
            {
                var options = new RestClientOptions("https://cpcpos.seppay.ir")
                {
                    MaxTimeout = baseModel.TimeOut,
                };
                var client = new RestClient(options);
                var request = new RestRequest("/v1/PcPosTransaction/StartPayment", Method.Post);
                request.AddHeader("Authorization", $"bearer {token}");
                request.AddHeader("Content-Type", "application/json");
                var body = JsonConvert.SerializeObject(paymentModel);
                request.AddJsonBody(body);
                RestResponse response = await client.ExecuteAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    var responseModel = JsonConvert.DeserializeObject<ResponseModel>(response.Content);
                    if (!responseModel.IsSuccess)
                        throw new SamanKishException(responseModel.ErrorDescription);
                }
                throw new SamanKishException("خطا در ارسال مبلغ");

            }
            catch (Exception e)
            {

                throw;
            }




        }
        private async Task<string> GetTokenAsync(BaseRequestModel model)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Post, "https://idn.seppay.ir/connect/token");
            request.Headers.Add("Authorization", "Basic cm9jbGllbnQ6c2VjcmV0");
            var content = new StringContent($"grant_type=password&username={model.UserName}&password={model.Password}&scope=SepCentralPcPos ", null, "application/x-www-form-urlencoded");
            request.Content = content;
            var response = await client.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                var jsonResponse = await response.Content.ReadAsStringAsync();
                var reponseModel = JsonConvert.DeserializeObject<TokenModel>(jsonResponse);
                return reponseModel.Token;
            }
            throw new SamanKishException("خطا در دریافت توکن");
        }
    }
}
