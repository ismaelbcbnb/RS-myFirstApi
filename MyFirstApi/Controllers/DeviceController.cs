using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstApi.Controllers
{

    public class DeviceController : MyFirstApiBaseController
    {
        [HttpGet]
        public IActionResult Device()
        {
            return Ok();
        }
    }
}
