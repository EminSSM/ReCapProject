﻿using Core.Entities.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Security.JWT;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<UserList> Register(UserForRegisterDto userForRegisterDto, string password); //Kayıt operasyonu
        IDataResult<UserList> Login(UserForLoginDto userForLoginDto);//Giriş operasyonu
        IResult UserExists(string email);//Kullanıcı var mı
        IDataResult<AccessToken> CreateAccessToken(UserList user);
    }
}
