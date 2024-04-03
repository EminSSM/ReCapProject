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
    public class UserManager : IUserService
    {
        IUserDal _userdal;

        public UserManager(IUserDal userdal)
        {
            _userdal = userdal;
        }

        public IResult TAdd(User user)
        {
            _userdal.Add(user);
            return new SuccessResult("Kullanıcı başarıyla eklendi.");
        }

        public IResult TDelete(User user)
        {
            _userdal.Delete(user);  
            return new SuccessResult("Kullanıcı başarıyla silindi.");
        }

        public IDataResult<List<User>> TGetAllUsers()
        {
            return new SuccessDataResult<List<User>>(_userdal.GetAll(),"Tüm kullanıcılar listelendi");
        }

        public IDataResult<User> TGetBy(int id)
        {
            return new SuccessDataResult<User>(_userdal.GetBy(x=>x.Id == id));
        }

        public IResult TUpdate(User user)
        {
            _userdal.Update(user);
            return new SuccessResult();
        }
    }
}
