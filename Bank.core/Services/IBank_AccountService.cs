using Bank.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Core.Services
{
    public  interface IBank_AccountService
    {
        List<Bank_Account> GetAccounts();

        Bank_Account GetByBankNumber(int BankNumber);

        Bank_Account AddBank_Account(Bank_Account bank_account);
        Bank_Account UpdateBank_Account(int BankNumber, Bank_Account bank_account);
        void DeleteBank_Account(int BankNumber);
    }
}
