using Backend.Repositories;
using Backend.UnitOfWork;

namespace Backend.DataAccess
{
    public class BackendUnitOfWork : IUnitOfWork
    {
        public BackendUnitOfWork(string connectionString)
        {
            Customer = new CustomerRepository(connectionString);
            User = new UserRepository(connectionString);
            Supplier = new SupplierRepository(connectionString);
        }
        public ICustomerRepository Customer { get; private set; }
        public IUserRepository User { get; private set; }
        public ISupplierRepository Supplier { get; private set; }
    }
}
