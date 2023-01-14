using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApplicationCore.ViewModels
{
   public class RegisterViewModels
    {
        [Required]
        [MaxLength(250)]
        [Display(Name ="User Name")]
        public string UserName { get; set; }
        [Required(ErrorMessage ="You should enter {0}")]
        [MaxLength(250)]
        [Display(Name = "Email Address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "You should enter {0}")]
        [MaxLength(12)]
        public string  Mobile { get; set; }
        [Required]
        [MaxLength(250)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [MaxLength(250)]
        [Compare("Password" , ErrorMessage ="Confirm Password is not the same as password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }

    public enum CheckUser
    {
        UserNameAndEmailNotValid,
        UserNameAndMobileNotValid,
        EmailNotValid,
        MobileNotValid,
        Ok
    }
}
