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
    public class OfficialService: IOfficialService
    {
        private readonly IOfficialRepository _officialRepository;
        public OfficialService(IOfficialRepository officialRepository)
        {
            _officialRepository = officialRepository;
        }
        public List<Official> GetOfficials()
        {
        return _officialRepository.GetOfficials();
         }


      public  Official GetOfficialById(int id)
        {
            return _officialRepository.GetOfficialById(id);
        }
       public Official AddOfficial(Official official)
        {
            return _officialRepository.AddOfficial(official);
        }
      public  Official UpdateOfficial(int id, Official official)
        {
            return _officialRepository.UpdateOfficial(id, official);    
        }
      public  void DeleteOfficial(int id)
        {
            _officialRepository.DeleteOfficial(id);
        }

    }
}
