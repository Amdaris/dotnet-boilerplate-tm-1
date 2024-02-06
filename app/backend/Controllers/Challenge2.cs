using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    public class Challenge2 : ControllerBase
    {
        [HttpPost("restaurant-order")]
        public string FormatRestaurantOrder([FromBody] string order)
        {
            // Write the code for Challenge 2 here

            return "";
        }
    }
}
