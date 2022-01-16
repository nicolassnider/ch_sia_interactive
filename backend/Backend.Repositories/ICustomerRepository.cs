using Backend.Models;
using System.Collections.Generic;

namespace Backend.Repositories
{
    public interface ICustomerRepository:IRepository<Customer>
    {
        IEnumerable<Customer> CustomerPagedList(int page, int rows); 
    }
}
