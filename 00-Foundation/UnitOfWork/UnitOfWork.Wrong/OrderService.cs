using UnitOfWork.Wrong.Data;
using UnitOfWork.Wrong.Models;
using UnitOfWork.Wrong.Repositories;

namespace UnitOfWork.Wrong;

public class OrderService
{
    public void CreateOrder(Order order)
    {
        var context = new FakeDbContext();

        var orderRepo = new OrderRepository(context);
        var productRepo = new ProductRepository(context);

        orderRepo.Add(order);      
        productRepo.UpdateStock(); 
    }
}
