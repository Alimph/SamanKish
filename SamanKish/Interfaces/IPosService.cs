using SamanKish.Agg.Models;
using System.Threading.Tasks;

namespace SamanKish.Agg.Interfaces
{
    public interface IPosService
    {
        Task StartPaymentAsync(BaseRequestModel loginModel, StartPaymentModel paymentModel);
    }
}
