using Microsoft.AspNetCore.Mvc;

namespace EZParking.Api.Addresses.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : Controller
    {
        [HttpGet]
        public async Task<ActionResult> Get(Guid parkingLotId)
        {
            return Ok();
        }
    }
}
