using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleMechanic.Core.Data;
using VehicleMechanic.Entity.Data;

namespace VehicleMechanic.Data.Abstract
{
    public interface IAppointmentRepository : IEntityRepository<Appointment>
    {
        //Appointment GetAppoinment(int appoinmentId);
        //IEnumerable<Appointment> GetAppointments();
        //long Insert(Appointment appointment);
        //long Update(Appointment appointment);
        //long Delete(long appoinmentId);
    }
}
