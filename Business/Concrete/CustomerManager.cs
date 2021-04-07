using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void Add(Customer customer)
        {
            _customerDal.Add(customer);
        }

        public void Delete(Customer customer)
        {
            _customerDal.Delete(customer);
        }

        public List<Customer> Getall()
        {
            return _customerDal.GetAll();
        }

        public Customer GetById(int customerId)
        {
            return _customerDal.Get(c => c.Id == customerId);
        }

        public void Update(Customer customer)
        {
            _customerDal.Update(customer);
        }
    }
}
