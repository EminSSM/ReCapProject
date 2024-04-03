using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _cardal;

        public CarManager(ICarDal cardal)
        {
            _cardal = cardal;
        }
        [SecuredOperation("car.add,admin")]
        [ValidationAspect(typeof(CarValidation))]
        public IResult TAdd(Car car)
        {
            _cardal.Add(car);
            return new SuccessResult("Araba başarıyla eklendi");
        }

        public IResult TDelete(Car car)
        {
            _cardal.Delete(car);
            return new SuccessResult("Araba başarıyla silindi");
        }
        [CacheAspect]
        [PerformanceAspect(10)]
        public IDataResult<List<Car>> TGetAllCars()
        {
            return new SuccessDataResult<List<Car>>(_cardal.GetAll());
        }
        [CacheAspect]
        public IDataResult<Car> TGetByCar(int id)
        {
            return new SuccessDataResult<Car>(_cardal.GetBy(c => c.Id == id));
        }

        public IDataResult<List<Car>> TGetCarsByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_cardal.GetAll(c=>c.BrandId == id));
        }

        public IDataResult<List<Car>> TGetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_cardal.GetAll(c=>c.ColorId == id));
        }

        public IDataResult<List<CarDetailsDto>> TGetCarsDetails()
        {
            return new SuccessDataResult<List<CarDetailsDto>>(_cardal.CarDetails());
        }

        public IResult TUpdate(Car car)
        {
            _cardal.Update(car);
            return new SuccessResult("Araba başarıyla güncellendi");
        }
        [TransactionScopeAspect]
        public IResult TransactionalOperation(Car car)
        {
            _cardal.Update(car);
            _cardal.Add(car);
            return new SuccessResult(Messages.CarUpdated);

        }
    }
}
