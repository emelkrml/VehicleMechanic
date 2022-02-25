using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleMechanic.Core.Data;
using VehicleMechanic.Entity.Data;

namespace VehicleMechanic.Data.Abstract
{
    public interface IVehicleRepository : IEntityRepository<Vehicle>
    {
        //Vehicle GetVehicle(int vehicleId);
        //IEnumerable<Vehicle> GetVehicles();
        //long Insert(Vehicle vehicle);
        //long Update(Vehicle vehicle);
        //long Delete(long vehicleId);
    }
}
