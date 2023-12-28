//using Bank.Core.Repositories;
//using Bank.Core.Services;
//using Bank.Core.Entities;
using Bank.Core.Repositories;
using Bank.Core.Services;
using Bank.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Service.Services
{
    public class Bank_AccountService : IBank_AccountService
    {
        private readonly IBank_AccountRepository _bank_AccountRepository;
        public Bank_AccountService(IBank_AccountRepository bank_AccountRepository)
        {
            _bank_AccountRepository=bank_AccountRepository;
        }
        public List<Bank_Account> GetAccounts()
        {
            return _bank_AccountRepository.GetAccounts();
        }
       public Bank_Account GetByBankNumber(int BankNumber)
        {
            return _bank_AccountRepository.GetByBankNumber(BankNumber);
        }

       public Bank_Account AddBank_Account(Bank_Account bank_account)
        {
            return _bank_AccountRepository.AddBank_Account(bank_account);
        }
       public Bank_Account UpdateBank_Account(int BankNumber, Bank_Account bank_account)
        {
            return _bank_AccountRepository.UpdateBank_Account(BankNumber, bank_account);
        }
      public void DeleteBank_Account(int BankNumber)
        {
            _bank_AccountRepository.DeleteBank_Account(BankNumber);
        }

    }
}
