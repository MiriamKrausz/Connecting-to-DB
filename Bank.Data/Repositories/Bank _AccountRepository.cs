using Bank.Core.Repositories;
using Bank.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Data.Repositories
{
    public  class Bank_AccountRepository: IBank_AccountRepository
    {
        private readonly DataContext _context;
     

        public Bank_AccountRepository(DataContext dataContext)
        {
            _context = dataContext;
        }
        public List<Bank_Account> GetAccounts()
        {
            return _context.Bank_AccountList.ToList();
        }
        public Bank_Account GetByBankNumber(int BankNumber)
        {
            return _context.Bank_AccountList.ToList().Find(x => x.BankNumber == BankNumber);
        }
        public Bank_Account AddBank_Account(Bank_Account bank_account)
        {
            _context.Bank_AccountList.Add(bank_account);
            return bank_account;
        }
        public Bank_Account UpdateBank_Account(int BankNumber, Bank_Account bank_account)
        {
            var updatedBank_Account= _context.Bank_AccountList.ToList().Find(x => x.BankNumber == BankNumber);
            if (updatedBank_Account == null)
                return null;
            updatedBank_Account=bank_account;
            return updatedBank_Account;
        }
        public void DeleteBank_Account(int BankNumber)
        {
            _context.Bank_AccountList.Remove(_context.Bank_AccountList.ToList().Find(x => x.BankNumber == BankNumber));
        }
    }
}
