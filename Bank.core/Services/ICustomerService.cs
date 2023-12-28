using Bank.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Core.Services
{
    public interface ICustomerService
    {
        List<Customer> GetCustomers();

        Customer GetById(int id);

        Customer AddCustomer(Customer customer);
        Customer UpdateCustomer(int id, Customer customer);
        void DeleteCustomer(int id);
    }
}
