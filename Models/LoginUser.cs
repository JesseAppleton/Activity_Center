using System;
using System.ComponentModel.DataAnnotations;


namespace Activity_Center.Models
{
    public class LoginUser
    {
        [Required(ErrorMessage = "Email can not be blank")]
        [EmailAddress]
        public string LoginEmail { get; set; }

        [Required(ErrorMessage = "Password can not be blank")]
        [MinLength(8)]
        public string LoginPassword { get; set; }
    }
}