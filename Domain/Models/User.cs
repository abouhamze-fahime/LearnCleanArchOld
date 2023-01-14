using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Models
{
  public  class User
    {
        [Key]
        public int UserId { get; set; }
        [MaxLength(250)]
        [Required(ErrorMessage ="You should fill this field {0}")]
        public string UserName { get; set; }
        [Required]
        [MaxLength(12)]
        public string Mobile { get; set; }
        [EmailAddress]
        [MaxLength(250)]
        [Required]
        public string Email { get; set; }
        [MaxLength(250)]
        [Required]
        public string Password { get; set; }

    }
}
