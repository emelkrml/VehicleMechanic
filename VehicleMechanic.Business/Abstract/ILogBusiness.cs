using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleMechanic.Logger.Abstract;

namespace VehicleMechanic.Business.Abstract
{
    public interface ILogBusiness
    {
        IGeneralLogRepository GeneralLog { get; }
        IExceptionLogRepository ExceptionLog { get; }
    }
}
