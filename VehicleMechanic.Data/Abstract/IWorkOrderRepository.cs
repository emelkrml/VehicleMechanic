using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleMechanic.Core.Data;
using VehicleMechanic.Entity.Data;

namespace VehicleMechanic.Data.Abstract
{
    public interface IWorkOrderRepository : IEntityRepository<WorkOrder>
    {
        //WorkOrder GetVehicle(int workOrderId);
        //IEnumerable<WorkOrder> GetWorkOrderies();
        //long Insert(WorkOrder workOrder);
        //long Update(WorkOrder workOrder);
        //long Delete(long workOrderId);
    }
}
