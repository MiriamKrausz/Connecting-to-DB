//using Bank.Core.Repositories;
//using Bank.Core.Services;
//using Bank.Entities;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

using Bank.Core.Repositories;
using Bank.Core.Services;
using Bank.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Service
{
    public class AppointmentService:IAppointmentService
    {
        private readonly IAppointmentService _iAppointmentService;
        public AppointmentService(IAppointmentService iAppointmentService)
        {
            _iAppointmentService = iAppointmentService;
        }
        public IEnumerable<Appointment> GetAppointments()
        {
            return _iAppointmentService.GetAppointments();
        }
        public Appointment GetById(int id)
        {
            return _iAppointmentService.GetById(id);
        }

        public Appointment AddAppointment(Appointment appointment)
        {
            return _iAppointmentService.AddAppointment(appointment);
        }
        public Appointment UpdateAppointment(int id, Appointment appointment)
        {
            return _iAppointmentService.UpdateAppointment(id, appointment);
        }
        public void DeleteAppointment(int id)
        {
            _iAppointmentService.DeleteAppointment(id);
        }
    }
}
