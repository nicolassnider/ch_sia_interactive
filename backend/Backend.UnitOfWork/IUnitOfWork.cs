using Backend.Repositories;

namespace Backend.UnitOfWork
{
    public interface IUnitOfWork
    {
        ICustomerRepository Customer { get; }
    }
}
