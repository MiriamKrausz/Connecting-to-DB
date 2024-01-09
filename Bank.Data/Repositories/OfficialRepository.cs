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
    public class OfficialRepository: IOfficialRepository
    {
        private readonly DataContext _context;


        public OfficialRepository(DataContext dataContext)
        {
            _context = dataContext;
        }
        public IEnumerable<Official> GetOfficials()
        {
            return _context.OfficialList.Include(u=>u.AppointmentId);
        }
        public Official GetOfficialById(int id)
        {
            return _context.OfficialList.Find(id);
        }
        public Official AddOfficial(Official official)
        {
            _context.OfficialList.Add(official);
            _context.SaveChanges();
            return official;
        }
        public Official UpdateOfficial(int id, Official official)
        {
            var updatedOfficial = _context.OfficialList.Find(id);
            //if (updatedOfficial == null)
            //    return null;
            updatedOfficial = official;
            _context.SaveChanges();
            return updatedOfficial;
        }
        public void DeleteOfficial(int id)
        {
            _context.OfficialList.Remove(_context.OfficialList.Find(id));
            _context.SaveChanges();
        }
    }
}
