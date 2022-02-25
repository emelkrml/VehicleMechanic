using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleMechanic.Business.Abstract;
using VehicleMechanic.Data.Abstract;
using VehicleMechanic.Data.Concrete;
using VehicleMechanic.Data.DAL;

namespace VehicleMechanic.Business.Concrete
{
    public class DataBusiness : IDataBusiness
    {
        private readonly VehicleMechanicContext context;

        public DataBusiness()
            => context = new VehicleMechanicContext();

        private ICustomerRepository _customer;
        private IVehicleRepository _vehicle;
        private IWorkOrderRepository _workOrder;
        private IAppointmentRepository _appointment;
        public ICustomerRepository Customer
            => _customer ?? (_customer = new CustomerRepository(context));

        public IVehicleRepository Vehicle
            => _vehicle ?? (_vehicle = new VehicleRepository(context));

        public IAppointmentRepository Appointment
            => _appointment ?? (_appointment = new AppointmentRepository(context));

        public IWorkOrderRepository WorkOrder
            => _workOrder ?? (_workOrder = new WorkOrderRepository(context));

        public int SaveChanges()
            => context.SaveChanges();

        public void Dispose() 
            => context.Dispose();
    }
}
