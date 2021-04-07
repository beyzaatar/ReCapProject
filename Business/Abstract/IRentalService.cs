using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        List<Rental> Getall();
        Rental GetById(int rentalId);
        void Add(Rental rental);
        void Update(Rental rental);
        void Delete(Rental rental);
    }
}
