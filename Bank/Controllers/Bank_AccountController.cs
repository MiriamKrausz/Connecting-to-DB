
using Bank.Core.Services;
using Bank.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bank.Controllers
{
    [Route("bank/[controller]")]
    [ApiController]
    public class Bank_AccountController : ControllerBase
    {
        private readonly IBank_AccountService _bank_AccountService;

        public Bank_AccountController(IBank_AccountService bank_AccountService)
        {
            _bank_AccountService = bank_AccountService;
        }


        // GET: api/<Accounts>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_bank_AccountService.GetAccounts());
        }

        // GET api/<Accounts>/5
        [HttpGet("{BankNumber}")]
        public IActionResult Get(int BankNumber)
        {
            var Bank_Account = _bank_AccountService.GetByBankNumber(BankNumber);
            if (Bank_Account is null)
            {
                return NotFound();
            }
            return Ok(Bank_Account);
        }

        [HttpPost]
        public ActionResult Post([FromBody] Bank_Account bank_Account)
        {
            return Ok(_bank_AccountService.AddBank_Account(bank_Account));
        }
        [HttpPut("{accountNumber}")]
        public ActionResult Put(int accountNumber, [FromBody] Bank_Account bank_Account)
        {
            return Ok(_bank_AccountService.UpdateBank_Account(accountNumber, bank_Account));
        }
        //// DELETE api/<Accounts>/5
        [HttpDelete("{accountNumber}")]
        public ActionResult Delete(int accountNumber)
        {
            _bank_AccountService.DeleteBank_Account(accountNumber);
            return NoContent();
        }
    }
}
