using UnitOfWork.Correct.Models;

namespace UnitOfWork.Correct;

public class OrderService
{
    private readonly UnitOfWork _unitOfWork;

    public OrderService(UnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public void CreateOrder(Order order)
    {
        _unitOfWork.Orders.Add(order);
        _unitOfWork.Products.UpdateStock();

        _unitOfWork.Commit(); 
    }
}
