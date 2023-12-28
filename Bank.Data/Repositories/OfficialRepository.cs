using Bank.Core.Repositories;
using Bank.Entities;
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
        public List<Official> GetOfficials()
        {
            return _context.OfficialList.ToList();
        }
        public Official GetOfficialById(int id)
        {
            return _context.OfficialList.ToList().Find(x => x.Id == id);
        }
        public Official AddOfficial(Official official)
        {
            _context.OfficialList.Add(official);
            return official;
        }
        public Official UpdateOfficial(int id, Official official)
        {
            var updatedOfficial = _context.OfficialList.ToList().Find(x => x.Id == id);
            if (updatedOfficial == null)
                return null;
            updatedOfficial = official;
            return updatedOfficial;
        }
        public void DeleteOfficial(int id)
        {
            _context.OfficialList.Remove(_context.OfficialList.ToList().Find(x => x.Id == id));
        }
    }
}
