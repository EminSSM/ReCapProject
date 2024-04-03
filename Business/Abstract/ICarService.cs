using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> TGetAllCars();
        IDataResult<Car> TGetByCar(int id);
        IDataResult<List<Car>> TGetCarsByBrandId(int id);
        IDataResult<List<Car>> TGetCarsByColorId(int id);
        IResult TAdd(Car car);
        IResult TUpdate(Car car);
        IResult TDelete(Car car);
        IDataResult<List<CarDetailsDto>> TGetCarsDetails();
    }
}
