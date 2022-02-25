using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleMechanic.Core.Data;
using VehicleMechanic.Entity.Data;

namespace VehicleMechanic.Data.Abstract
{
    public interface ICustomerRepository : IEntityRepository<Customer>
    {
        //Customer GetCustomer(int customerId);
        //IEnumerable<Customer> GetCustomers();
        //long Insert(Customer customer);
        //long Update(Customer customer);
        //long Delete(long customerId);
    }
}
