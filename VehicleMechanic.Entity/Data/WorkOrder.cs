using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleMechanic.Core.Entity;

namespace VehicleMechanic.Entity.Data
{

    [Table("WorkOrder")]
    public class WorkOrder : IEntity
    {
        [Key]
        public int WorkOrderID { get; set; }
        public bool Process { get; set; }
        public bool Done { get; set; }
        public DateTime ProcessDate { get; set; }
        public DateTime DoneDate { get; set; }

        public Vehicle Vehicle { get; set; }
    }
}
