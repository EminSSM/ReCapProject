using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IColorService
    {
        IDataResult<List<Color>> TGetAllColors();
        IDataResult<Color> TGetBy(int id);
        IResult TAdd(Color color);
        IResult TUpdate(Color color);
        IResult TDelete(Color color);
    }
}
