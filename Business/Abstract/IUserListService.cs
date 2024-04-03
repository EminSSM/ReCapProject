using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IUserListService
    {
        IDataResult<List<OperationClaim>> GetClaims(UserList user);
        IResult Add(UserList user);
        IDataResult<UserList> GetByMail(string email);
    }
}
