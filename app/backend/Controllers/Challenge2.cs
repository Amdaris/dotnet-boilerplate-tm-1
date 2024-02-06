using backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    public class Challenge2 : ControllerBase
    {
        [HttpPost("restaurant-order")]
        public string FormatRestaurantOrder([FromBody] RestaurantOrderRequest input)
        {
            // Write the code for Challenge 2 here
            var order = input.Order;

            return "";
        }
    }
}
