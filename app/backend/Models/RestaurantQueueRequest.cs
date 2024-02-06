namespace backend.Models
{
    public class RestaurantQueueRequest
    {
        public int[] Customers { get; set; }
        public int SelfCheckoutPoints { get; set; }
    }
}
