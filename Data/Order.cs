namespace Freshprints.Data
{
    public class Order
    {
        public string OrderId { get; set; }

        public string UserName { get; set; }

        public string OrderDescription { get; set; }

        public string OrderDate { get; set; }


        public Order(string orderId, string orderDescription, string orderDate, string userName)
        {
            OrderId = orderId;
            OrderDescription = orderDescription;
            OrderDate = orderDate;
            UserName = userName;
        }
    }
}