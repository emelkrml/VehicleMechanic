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
    [Table("Vehicle")]
    public class Vehicle : IEntity
    {
        [Key]
        public int VehicleID { get; set; }
        public string Plate { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int ModelYear { get; set; }

        public int CustomerID { get; set; }
        public Customer Customer { get; set; }

        // TODO: Customer modeliyle ilişki kurulacak
    }
}
