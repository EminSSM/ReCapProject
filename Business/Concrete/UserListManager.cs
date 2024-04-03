using Business.Abstract;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class UserListManager : IUserListService
    {
        IUserListDal _userDal;

        public UserListManager(IUserListDal userDal)
        {
            _userDal = userDal;
        }

        public IDataResult<List<OperationClaim>> GetClaims(UserList user)
        {
            return new SuccessDataResult<List<OperationClaim>>(_userDal.GetClaims(user));
        }

        public IResult Add(UserList user)
        {
            _userDal.Add(user);
            return new SuccessResult();
        }

        public IDataResult<UserList> GetByMail(string email)
        {
            return new SuccessDataResult<UserList>(_userDal.GetAll(u => u.Email == email).FirstOrDefault());
        }
    }
}
