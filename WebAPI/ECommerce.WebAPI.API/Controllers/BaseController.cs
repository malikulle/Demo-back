using ECommerce.Module.Wrapper.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WebAPI.API.Controllers
{
    public class BaseController : ControllerBase
    {
        protected IClientService Client => _Client ??= HttpContext.RequestServices.GetService<IClientService>();
        private IClientService _Client;
    }
}
