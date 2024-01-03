using Microsoft.AspNetCore.Mvc;
using Bank.Entities;
using Bank.Core.Services;
using Bank.Service;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bank.Controllers
{
    [Route("bank/[controller]")]
    [ApiController]
    public class OfficialController : ControllerBase
    {
        private readonly IOfficialService _officialService;
        public OfficialController(IOfficialService officialService)
        {
            _officialService = officialService;
        }
        // GET: api/<Officials>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_officialService.GetOfficials());
        }


        // GET api/<Officials>/5
        //[HttpGet("{branch}")]
        //public IEnumerable<Official> Get(int branch)
        //{
        //    return _dataContext_Official.Where(e => e.BranchNumber == branch).ToList();
        //}

        [HttpPost]
        public ActionResult Post([FromBody] Official official)
        {
            return Ok(_officialService.AddOfficial(official));
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var official=_officialService.GetOfficialById(id);
            if(official is null)
            {
                return NotFound();
            }
            return Ok(official);
        }

        // POST api/<Officials>
        //public void Post([FromBody] Official newOfficial)
        //{
        //    _dataContext_Official.Add(newOfficial);
        //}

        //// PUT api/<Customers>/5

        //public void Put(int id, [FromBody] Official off)
        //{
        //    Official updatedOfficial = _dataContext_Official.Find(e => e.Id == id);
        //    updatedOfficial.City =off.City;
        //    updatedOfficial.BranchNumber=off.BranchNumber;
        //    updatedOfficial.Id = off.Id;
        //    updatedOfficial.Name =off.Name;
        //    updatedOfficial.Addreess =off.Addreess;
        //    updatedOfficial.Age =off.Age;
        //}
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Official off)
        {
            return Ok(_officialService.UpdateOfficial(id, off));
        }

        //// DELETE api/<Customers>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _officialService.DeleteOfficial(id);
            return NoContent();
        }
    }

}
