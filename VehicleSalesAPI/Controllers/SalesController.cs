using Microsoft.AspNetCore.Mvc;
using VehicleSalesAPI.Models;

namespace VehicleSalesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SalesController : ControllerBase
    {
        [HttpGet("SGetSales")]
        public IActionResult GetSales()
        {
            var salesData = VehicleSales.GetSampleData();
            return Ok(salesData);
        }
    }
}
