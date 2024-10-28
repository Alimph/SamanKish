using Microsoft.AspNetCore.Mvc.RazorPages;
using SamanKish.Agg.Interfaces;
using SamanKish.Agg.Models;

namespace Example.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IPosService _posService;

        public IndexModel(IPosService posService)
        {
            _posService = posService;
        }
        public void OnGet()
        {
            try
            {
                var loginModel = new BaseRequestModel
                {
                    Password = "Your password",
                    UserName = "Your userName"
                };
                _posService.StartPayment(loginModel, new StartPaymentModel
                {
                    Amount = "150000",
                    TerminalID = "14442777",
                    Identifier = Guid.NewGuid().ToString(),
                    ResNum = "215777",

                    UserNotifiable = new UserNotifiable
                    {
                        FooterMessage = "dd",
                        PrintItems = new List<PrintItem>
                    {
                        new PrintItem("bala","paein",Alignment.Center,ReceiptType.Customer)

                    }
                    }
                });
            }
            catch (Exception e)
            {

                throw;
            }

        }
    }
}
