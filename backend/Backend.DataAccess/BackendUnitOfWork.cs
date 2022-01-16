using Backend.Repositories;
using Backend.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Backend.DataAccess
{
    public class BackendUnitOfWork : IUnitOfWork
    {
        public BackendUnitOfWork(string connectionString)
        {
            Customer = new CustomerRepository(connectionString);
        }
        public ICustomerRepository Customer { get; private set; }
    }
}
