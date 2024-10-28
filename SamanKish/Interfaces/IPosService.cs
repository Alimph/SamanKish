using SamanKish.Agg.Models;
using System.Threading.Tasks;

namespace SamanKish.Agg.Interfaces
{
    public interface IPosService
    {
        Task StartPayment(BaseReuestModel loginModel, StartPaymentModel paymentModel);
    }
}
