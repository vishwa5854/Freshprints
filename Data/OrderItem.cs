namespace Freshprints.Data
{
    public class OrderItem
    {
        public string OrderId { get; set; }

        public Item Item { get; set; }

        public string OrderDescription { get; set; }

        public string OrderDate { get; set; }



        public OrderItem(string orderId, string orderDescription, string orderDate)
        {
            OrderId = orderId;
            OrderDescription = orderDescription;
            OrderDate = orderDate;
            Item = ItemsMockRepository.GetItemById(1);
        }
    }
}