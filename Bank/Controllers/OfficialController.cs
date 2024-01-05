using Bank.Core.Services;
using Bank.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bank.Controllers
{
    [Route("api/[controller]")]
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

        [HttpPost]
        public ActionResult Post([FromBody] Official official)
        {
            return Ok(_officialService.AddOfficial(official));
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var official = _officialService.GetOfficialById(id);
            if (official is null)
            {
                return NotFound();
            }
            return Ok(official);
        }

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
