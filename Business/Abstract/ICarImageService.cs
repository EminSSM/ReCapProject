using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using IResult = Core.Utilities.Results.IResult;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IResult TAdd(IFormFile file, CarImage carImage);
        IResult TUpdate(IFormFile file, CarImage carImage);
        IResult TDelete(int id);
        IDataResult <List<CarImage>> GetAllCarImages();
        IDataResult<CarImage> GetCarImage(int id);
        IDataResult<CarImage> GetByCaridImage(int carid);
    }
}
