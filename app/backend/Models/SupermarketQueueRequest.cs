namespace backend.Models
{
    public class SupermarketQueueRequest
    {
        public int[] Customers { get; set; }
        public int SelfCheckoutPoints { get; set; }
    }
}
