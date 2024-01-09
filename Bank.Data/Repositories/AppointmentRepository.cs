using Bank.Core.Repositories;
using Bank.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Data.Repositories
{
    public class AppointmentRepository:IAppointmentRepository
    {
        private readonly DataContext _context;


        public AppointmentRepository(DataContext dataContext)
        {
            _context = dataContext;
        }
        public IEnumerable<Appointment> GetAppointments()
        {
            return _context.AppointmentList.Include(u=>u.Customers).Include(u=>u.Officials);
        }
        public Appointment GetById(int id)
        {
            return _context.AppointmentList.Find(id);
        }
        public Appointment AddAppointment(Appointment appointment)
        {
            _context.AppointmentList.Add(appointment);
            _context.SaveChanges();
            return appointment;
        }
        public Appointment UpdateAppointment(int id, Appointment appointment)
        {
            var updatedAppointment = _context.AppointmentList.Find(id);
            //if (updatedBank_Account == null)
            //    return null;
            updatedAppointment = appointment;
            _context.SaveChanges();
            return updatedAppointment;
        }
        public void DeleteAppointment(int id)
        {
            _context.AppointmentList.Remove(_context.AppointmentList.Find(id));
        }
    }
}
