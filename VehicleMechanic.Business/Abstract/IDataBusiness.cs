using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleMechanic.Data.Abstract; 


namespace VehicleMechanic.Business.Abstract
{
    public interface IDataBusiness : IDisposable
    {
        ICustomerRepository Customer { get;  }
        IVehicleRepository Vehicle { get;  }
        IAppointmentRepository Appointment { get;  }
        IWorkOrderRepository WorkOrder { get;  }
    }
}
