using Bank.Core.Repositories;
using Bank.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Data.Repositories
{
    public class CustomerRepository: ICustomerRepository
    {
        private readonly DataContext _context;
        public CustomerRepository(DataContext dataContext)
        {
            _context = dataContext;
        }
        public List<Customer> GetCustomers()
        {
            return _context.CustomerList.ToList();
        }
        public  Customer GetById(int id)

        {
            return _context.CustomerList.Find(id);
        }
        public Customer AddCustomer(Customer customer)
        {
            _context.CustomerList.Add(customer);
            _context.SaveChanges();
            
            return customer;
        }
        public Customer UpdateCustomer(int id, Customer customer)
        {
            var updatedCustomer = _context.CustomerList.Find(id);
            updatedCustomer = customer;
            //if (updatedCustomer == null)
            //    return null;
            //updatedCustomer = customer;
            _context.SaveChanges();
            return updatedCustomer;
        }
        public void DeleteCustomer(int id)
        {
            _context.CustomerList.Remove(_context.CustomerList.Find(id));
            _context.SaveChanges();
        }
    }
}
