using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ANIMA.Models
{
    public class SignInViewModel
    {
        [Required(ErrorMessage = "ENTER EMAIL.")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "EMAIL")]
        public string Email { get; set; }

        [Required(ErrorMessage = "ENTER PASSWORD.")]
        [DataType(DataType.Password)]
        [Display(Name = "PASSWORD")]
        public string Password { get; set; }
    }
}
