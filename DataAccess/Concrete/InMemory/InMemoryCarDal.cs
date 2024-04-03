using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car() { Id = 1, BrandId = 1, ColorId = 1, ModelYear = 2010,DailyPrice=500000,Description="Kusursuz araba" },
                new Car() { Id = 2, BrandId = 1, ColorId = 2, ModelYear = 2012,DailyPrice=600000,Description="Janti araba"},
                new Car() { Id = 3, BrandId = 1, ColorId = 2, ModelYear = 2022,DailyPrice=900000,Description="Mükemmel araba"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public List<CarDetailsDto> CarDetails()
        {
            throw new NotImplementedException();
        }

        public void Delete(Car car)
        {
            var carDelete = _cars.FirstOrDefault(x => x.Id == car.Id);
            _cars.Remove(carDelete);
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllCars()
        {
            return _cars;
        }

        public Car GetBy(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(x=> x.Id == id).ToList();
        }

        public void Update(Car car)
        {
            var carUpdate = _cars.FirstOrDefault(x => x.Id == car.Id);
            carUpdate.DailyPrice = car.DailyPrice;
            carUpdate.Description = car.Description;
            carUpdate.ModelYear = car.ModelYear;
            carUpdate.BrandId = car.BrandId;
            carUpdate.ColorId = car.ColorId;
        }
    }
}
