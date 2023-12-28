using Bank.Core.Repositories;
using Bank.Core.Services;
using Bank.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Service
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public List<Customer> GetCustomers()
        {
            return _customerRepository.GetCustomers();
        }
        public Customer GetById(int id)
        {
            return _customerRepository.GetById(id);
        }

        public Customer AddCustomer(Customer customer)
        {
            return _customerRepository.AddCustomer(customer);
        }
        public Customer UpdateCustomer(int id, Customer customer)
        {
            return _customerRepository.UpdateCustomer(id, customer);
        }
       public void DeleteCustomer(int id)
        {
            _customerRepository.DeleteCustomer(id);
        }
    }
}
