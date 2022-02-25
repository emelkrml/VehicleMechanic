using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleMechanic.Business.Abstract;
using VehicleMechanic.Logger.Abstract;
using VehicleMechanic.Logger.Concrete;

namespace VehicleMechanic.Business.Concrete
{
    public class LogBusiness : ILogBusiness
    {
        IGeneralLogRepository _generalLog;
        IExceptionLogRepository _exceptionLog;

        public IGeneralLogRepository GeneralLog
            => _generalLog ?? (_generalLog = new GeneralLogRepository());

        public IExceptionLogRepository ExceptionLog
            => _exceptionLog ?? (_exceptionLog = new ExceptionLogRepository());
    }
}
