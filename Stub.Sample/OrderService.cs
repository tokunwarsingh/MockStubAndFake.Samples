namespace Stub.Sample
{
    public class OrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public Order ProcessOrder(int id)
        {
            var order = _orderRepository.GetOrderById(id);
            if (order == null)
            {
                throw new Exception("Order not found");
            }
            return order;
        }
    }
}
