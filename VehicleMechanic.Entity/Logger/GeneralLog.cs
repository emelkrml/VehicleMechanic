using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleMechanic.Core.Entity;

namespace VehicleMechanic.Entity.Logger
{
    public class GeneralLog : ILog
    {
        public GeneralLog() => this.Date = DateTime.Now;
        public DateTime Date { get; set; }
        public string LogName { get; set; }
        public string LogInfo { get; set; }
    }
}
