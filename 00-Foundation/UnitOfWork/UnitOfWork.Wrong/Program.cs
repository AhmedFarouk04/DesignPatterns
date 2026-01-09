using UnitOfWork.Wrong;
using UnitOfWork.Wrong.Models;

class Program
{
    static void Main()
    {
        var service = new OrderService();
        service.CreateOrder(new Order { Id = 1, Price = 200 });
    }
}
