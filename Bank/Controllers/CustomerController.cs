using Bank.Core.Services;
using Bank.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bank.Controllers
{
    [Route("bank/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        // GET: api/<Customers>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_customerService.GetCustomers());
        }

        // GET api/<Customers>/5
        //[HttpGet("{address}")]
        //public IEnumerable<Customer> Get(string address)
        //{
        //    return _dataContext_Customers.Where(e => e.Address == address).ToList();
        //}

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var cust=_customerService.GetById(id);
            if(cust is null)
            {
                return NotFound();
            }
            return Ok(cust);
        }

        //// POST api/<Customers>
        //[HttpPost]
        //public void Post([FromBody] Customer newcustomer)
        //{
        //    _dataContext_Customers.Add(newcustomer);
        //}

        //// PUT api/<Customers>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] Customer cust)
        //{
        //    Customer updatedCust = _dataContext_Customers.Find(e => e.Id == id);
        //    updatedCust.PhoneNumber = cust.PhoneNumber;
        //    updatedCust.Address=cust.Address;
        //    updatedCust.Id = cust.Id;
        //    updatedCust.City=cust.City;
        //    updatedCust.Name = cust.Name;
        //}

        //// DELETE api/<Customers>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //    Customer cust = _dataContext_Customers.Find(e => e.Id == id);
        //    _dataContext_Customers.Remove(cust);
        //}
    }
}
