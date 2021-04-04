using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=1,DailyPrice=100000,
                Description="Toyota CH-R",ModelYear=2015},
                new Car{Id=2,BrandId=2,ColorId=2,DailyPrice=200000,
                Description="Honda civic",ModelYear=2016},
                new Car{Id=3,BrandId=3,ColorId=3,DailyPrice=300000,
                Description="Toyota corollo",ModelYear=2017},
                new Car{Id=4,BrandId=4,ColorId=4,DailyPrice=400000,
                Description="Nissan Qashqai",ModelYear=2018},
                new Car{Id=5,BrandId=5,ColorId=5,DailyPrice=500000,
                Description="Citroen C3",ModelYear=2019},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
            carToUpdate.DailyPrice = car.DailyPrice;

        }
    }
}
