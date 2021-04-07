﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        List<Customer> Getall();
        Customer GetById(int customerId);
        void Add(Customer customer);
        void Update(Customer customer);
        void Delete(Customer customer);
    }
}
