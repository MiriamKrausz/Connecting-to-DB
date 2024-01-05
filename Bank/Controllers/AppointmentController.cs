using Bank.Core.Services;
using Bank.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly IAppointmentService _appointmentService;

        public AppointmentController(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_appointmentService.GetAppointments());
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var app = _appointmentService.GetById(id);
            if (app is null)
            {
                return NotFound();
            }
            return Ok(app);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public ActionResult Post([FromBody] Appointment appointment)
        {
            return Ok(_appointmentService.AddAppointment(appointment));
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Appointment appointment)
        {
            return Ok(_appointmentService.UpdateAppointment(id,appointment));
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _appointmentService.DeleteAppointment(id);
            return NoContent();
        }
    }
}
