using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleMechanic.Core.Data;
using VehicleMechanic.Data.Abstract;
using VehicleMechanic.Data.DAL;
using VehicleMechanic.Entity.Data;

namespace VehicleMechanic.Data.Concrete
{
    public class CustomerRepository : EntityRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(VehicleMechanicContext context) : base(context) { }
    }
}
