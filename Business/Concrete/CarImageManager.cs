using Business.Abstract;
using IResult = Core.Utilities.Results.IResult;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Core.Utilities.Results;
using Business.Constants;
using Core.Helpers;
using Core.Business;
using DataAccess.Concrete.EntityFramework;


namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carimagedal;
        IFileHelper _filehelper;

        public CarImageManager(ICarImageDal carimagedal, IFileHelper filehelper)
        {
            _carimagedal = carimagedal;
            _filehelper = filehelper;
        }

        public IDataResult<List<CarImage>> GetAllCarImages()
        {
            return new SuccessDataResult<List<CarImage>>(_carimagedal.GetAll().ToList(),Messages.AllCarImagesListed);
        }

        public IDataResult<CarImage> GetByCaridImage(int carid)
        {
            return new SuccessDataResult<CarImage>(_carimagedal.GetBy(c=>c.CarId == carid),Messages.GetByCarImage);    
        }

        public IDataResult<CarImage> GetCarImage(int id)
        {
            return new SuccessDataResult<CarImage>(_carimagedal.GetBy(c=>c.Id == id),Messages.GetByCarImageforCarId);
        }

        public IResult TAdd(IFormFile file, CarImage carImage)
        {
            var result = BusinessRules.Run(CheckIfCarImageLimitExceeded(carImage.CarId));
            if (result != null)
            {
                return result;
            }
            carImage.ImagePath = _filehelper.Upload(file, PathConstants.ImagesPath);
            carImage.CreateDate = DateTime.Now;
            _carimagedal.Add(carImage);
            return new SuccessResult(Messages.AddToSuccessImage);
        }

        private IResult CheckIfCarImageLimitExceeded(int carId)
        {
            var result = _carimagedal.GetAll(c=>c.CarId==carId).Count();
            if (result > 5)
            {
                return new ErrorResult("Bir arabanın en fazla 5 resmi olabilir.");
            }
            return new SuccessResult();
        }

        public IResult TDelete(int id)
        {
            var result = new SuccessDataResult<CarImage>(_carimagedal.GetBy(c => c.Id == id));
            if (result == null)
            {
                return new ErrorResult("Resim bilgisi yok");
            }
            _carimagedal.Delete(result.Data);
            return new SuccessResult("Ürün başarıyla silindi");
        }

        public IResult TUpdate(IFormFile file, CarImage carImage)
        {
            carImage.ImagePath = _filehelper.Upload(file, PathConstants.ImagesPath);
            carImage.CreateDate = DateTime.Now;
            _carimagedal.Update(carImage);
            return new SuccessResult(Messages.CarImageUpdated);
        }
    }
}
