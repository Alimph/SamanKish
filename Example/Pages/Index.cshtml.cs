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
        public async void OnGet()
        {
            try
            {
                var loginModel = new BaseRequestModel
                {
                    Password = "Your password",
                    UserName = "Your userName"
                };
                await _posService.StartPaymentAsync(loginModel, new StartPaymentModel("14442777", "150000", "215777"));
            }
            catch (Exception e)
            {

                throw;
            }

        }
    }
}
