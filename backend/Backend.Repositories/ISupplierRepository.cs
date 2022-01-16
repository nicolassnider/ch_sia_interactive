using Backend.Models;
using System.Collections.Generic;

namespace Backend.Repositories
{
    public interface ISupplierRepository:IRepository<Supplier>
    {
        IEnumerable<Supplier> SupplierPagedList(int page, int rows);
    }
}
