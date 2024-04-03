using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _branddal;
        public BrandManager(IBrandDal branddal)
        {
            _branddal = branddal;
        }
        public IResult TAdd(Brand brand)
        {
            _branddal.Add(brand);
            return new SuccessResult();
        }

        public IResult TDelete(Brand brand)
        {
            _branddal.Delete(brand);
            return new SuccessResult();
        }

        public IDataResult<List<Brand>> TGetAllCars()
        {
            return new SuccessDataResult<List<Brand>>(_branddal.GetAll());
        }


        public IDataResult<List<Brand>> TGetAllBrands()
        {
            return new SuccessDataResult<List<Brand>>(_branddal.GetAll());
        }

        public IDataResult<Brand> TGetBy(int id)
        {
            return new SuccessDataResult<Brand>(_branddal.GetBy(c => c.BrandId == id));
        }

        public IResult TUpdate(Brand brand)
        {
            _branddal.Update(brand);
            return new SuccessResult();
        }

    }
}
