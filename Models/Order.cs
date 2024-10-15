namespace Appliance.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public List<Product> Products { get; set; }
        public decimal TotalPrice { get; set; }
        public string Status { get; set; }
    }
}
