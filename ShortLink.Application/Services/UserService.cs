using ShortLink.Application.DTOs.Account;
using ShortLink.Application.Interfaces;
using ShortLink.Domain.Interface;
using ShortLink.Domain.Models.Account;
using ShortLink.Domain.ViewModels.Account;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShortLink.Application.Services
{
    public class UserService : IUserService
    {
        #region constractor
        private readonly IUserRepository _userRepository;
        private readonly IPasswordHelper _passwordHelper;
        public UserService(IUserRepository userRepository, IPasswordHelper passwordHelper)
        {
            _userRepository = userRepository;
            _passwordHelper = passwordHelper;
        }
        #endregion

        #region account
        public async Task<RegisterUserResult> RegisterUser(RegisterUserDTO registerUser)
        {
            if (!await _userRepository.IsExistMobile(registerUser.Mobile))
            {
                var user = new User
                {
                    FirstName = registerUser.FirstName,
                    LastName = registerUser.LastName,
                    Password = _passwordHelper.EncodePasswordMd5(registerUser.Password),
                    Mobile = registerUser.Mobile,
                    MobileActiveCode = new Random().Next(10000, 9999999).ToString(),
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now,
                    IsAdmin = false
                };
                await _userRepository.AddUser(user);
                await _userRepository.SaveChange();
                //todo : Send sms
                return RegisterUserResult.Success;
            }
            return RegisterUserResult.IsMobileExist;
        }

        public async Task<LoginUserResult> LoginUser(LoginUserDTO loginUser)
        {
            var user = await _userRepository.GetUserByMobile(loginUser.Mobile);
            if (user == null) return LoginUserResult.NotFound;
            if (!user.IsMobileActive) return LoginUserResult.NotActivate;
            if (user.Password != _passwordHelper.EncodePasswordMd5(loginUser.Password)) return LoginUserResult.NotFound;

            return LoginUserResult.Success;
        }

        public async Task<User> GetUserByMobile(string mobile)
        {
            return await _userRepository.GetUserByMobile(mobile);
        }

        public async Task<List<UserForShowViewModel>> GetAllUserForShow()
        {
            return await _userRepository.GetAllUserForShow();
        }
        #endregion
    }
}
