using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleMechanic.Core.Entity;

namespace VehicleMechanic.Core.Logger
{
    public interface ILogRepository<T>
        where T : class, ILog, new()
    {
        List<T> GetList(Func<T, bool> filter = null);
        void Add(T log);
        void Delete(T log);
    }
}
