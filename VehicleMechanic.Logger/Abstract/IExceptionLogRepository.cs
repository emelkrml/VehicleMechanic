using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleMechanic.Core.Logger;
using VehicleMechanic.Entity.Logger;

namespace VehicleMechanic.Logger.Abstract
{
    public interface IExceptionLogRepository : ILogRepository<ExceptionLog>
    {
    }
}
