using Bank.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Core.Repositories
{
    public  interface IOfficialRepository
    {
        List<Official>GetOfficials();

        Official GetOfficialById(int id);
        Official AddOfficial(Official official);
        Official UpdateOfficial(int id,Official official);
        void DeleteOfficial(int id);

    }
}
