using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<Rental>> TGetAllRentals();
        IDataResult<Rental> TGetBy(int id);
        IResult TAdd(Rental rental);
        IResult TUpdate(Rental rental);
        IResult TDelete(Rental rental);
    }
}
