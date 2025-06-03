using Microsoft.AspNetCore.Mvc;
using System.Linq; // ✅ This is required for .Any()
using CountItemOccurrencesApi.Models;
using CountItemOccurrencesApi.Helpers;  

namespace CountItemOccurrencesApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CountOccurrencesController : ControllerBase
    {
        [HttpPost]
        public IActionResult CountOccurrences([FromBody] ItemListRequest request)
        {
            if (request.Items == null || !request.Items.Any())
            {
                return BadRequest("List is empty or null.");
            }

            var result = ItemCounter.CountItems(request.Items);  

            return Ok(result);
        }
    }
}

