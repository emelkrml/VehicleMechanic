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
    [Table("Customer")]
    public class Customer : IEntity
    {
        [Key]
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }

        public List<Vehicle> Vehicles { get; set; }
        public List<Appointment> Appointments { get; set; }
        public List<WorkOrder> WorkOrders { get; set; }
    }
}
