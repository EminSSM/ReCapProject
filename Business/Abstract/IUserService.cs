using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> TGetAllUsers();
        IDataResult<User> TGetBy(int id);
        IResult TAdd(User user);
        IResult TUpdate(User user);
        IResult TDelete(User user);
    }
}
