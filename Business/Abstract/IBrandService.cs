using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBrandService
    {
        IDataResult<List<Brand>> TGetAllBrands();
        IDataResult<Brand> TGetBy(int id);
        IResult TAdd(Brand brand);
        IResult TUpdate(Brand brand);
        IResult TDelete(Brand brand);
    }
}
