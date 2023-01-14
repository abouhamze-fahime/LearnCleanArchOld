using ApplicationCore.ViewModels;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Interfaces
{
   public interface IUserService
    {
        CheckUser CheckUser( string email, string mobile);
        int RegisterUser(User user);
    }
}
