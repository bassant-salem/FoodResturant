namespace FoodResturant.Models
{
    //what the user sees when they are creating an order
    public class OrderViewModel
    {
        public decimal TotalAmount { get; set; }
        public List<OrderItemViewModel> OrderItems { get; set; } 

        public IEnumerable<Product> Products { get; set; }
    }
}
