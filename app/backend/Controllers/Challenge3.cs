using backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    public class Challenge3 : ControllerBase
    {
        [HttpPost("supermarket-queue")]
        public int GetSupermarketQueueTime([FromBody] SupermarketQueueRequest input)
        {
            // Write the code for Challenge 3 here
            var customers = input.Customers;
            var selfCheckoutPoints = input.SelfCheckoutPoints;

            return -1;
        }
    }
}
