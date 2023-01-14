using ApplicationCore.Interfaces;
using ApplicationCore.ViewModels;
using System;
using Domain.Interfaces;
using System.Collections.Generic;
using System.Text;
using Domain.Models;

namespace ApplicationCore.Services
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
            
        }
        public CheckUser CheckUser( string email, string mobile)
        {
           // bool userNameValid = _userRepository.IsExistUserName(userName);
            bool emailValid = _userRepository.IsExistEmail(email.Trim().ToLower());
            bool mobileValid = _userRepository.IsExistMobile(mobile);

            if      (emailValid)  return ViewModels.CheckUser.EmailNotValid;
            else if (mobileValid) return ViewModels.CheckUser.MobileNotValid;
            return ViewModels.CheckUser.Ok;

        }

        public int RegisterUser(User user)
        {
            _userRepository.AddUser(user);
            _userRepository.Save();
            return user.UserId;
        }

     
    }
}
