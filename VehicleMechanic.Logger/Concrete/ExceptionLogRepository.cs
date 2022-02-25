using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleMechanic.Core.Logger;
using VehicleMechanic.Entity.Logger;
using VehicleMechanic.Logger.Abstract;

namespace VehicleMechanic.Logger.Concrete
{
    public class ExceptionLogRepository : FileLogRepository<ExceptionLog>, IExceptionLogRepository
    {
        public ExceptionLogRepository() : base("exceptionLogs.json") { }
    }
}
