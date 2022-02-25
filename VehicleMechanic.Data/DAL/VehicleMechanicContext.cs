using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleMechanic.Entity.Data;

namespace VehicleMechanic.Data.DAL
{
    public class VehicleMechanicContext : DbContext
    {
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(
				"Server=(localdb)\\mssqllocaldb;Database=VehicleMechanic;Trusted_Connection=True"
				);
		}


		public DbSet<Customer> Customer { get; set; }
		public DbSet<Vehicle> Vehicle { get; set; }
		public DbSet<Appointment> Appointment { get; set; }
		public DbSet<WorkOrder> WorkOrder { get; set; }
	}
}
