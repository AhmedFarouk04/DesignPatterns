using UnitOfWork.Correct;
using UnitOfWork.Correct.Data;
using UnitOfWork.Correct.Models;

class Program
{
    static void Main()
    {
        var context = new FakeDbContext();
        var uow = new UnitOfWork.Correct.UnitOfWork(context);

        var service = new OrderService(uow);
        service.CreateOrder(new Order { Id = 1, Price = 300 });
    }
}
