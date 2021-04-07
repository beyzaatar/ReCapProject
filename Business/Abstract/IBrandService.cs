using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        List<Brand> Getall();
        List<Brand> GetById(int brandId);
    }
}
