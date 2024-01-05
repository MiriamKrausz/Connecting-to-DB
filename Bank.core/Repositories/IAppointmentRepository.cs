using Bank.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Core.Repositories
{
    public interface IAppointmentRepository
    {
        List<Appointment> GetAppointments();

        Appointment GetById(int id);

        Appointment AddAppointment(Appointment appointment);
        Appointment UpdateAppointment(int id, Appointment appointment);
        void DeleteAppointment(int id);
    }
}
