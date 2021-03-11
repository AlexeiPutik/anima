using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ANIMA.Models
{
    public class SignUpViewModel
    {
        [Required(ErrorMessage = "ENTER EMAIL.")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "EMAIL")]
        public string Email { get; set; }

        [Required(ErrorMessage = "CREATE PASSWORD.")]
        [DataType(DataType.Password)]
        [Display(Name = "PASSWORD")]
        public string Password { get; set; }

        [Required(ErrorMessage = "CONFIRM PASSWORD.")]
        [Compare("Password", ErrorMessage = "PASSWORDS MUST BE SAME.")]
        [DataType(DataType.Password)]
        [Display(Name = "PASSWORD")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "CREATE PASSWORD")]
        [Display(Name = "AUTHOR NAME")]
        public string AuthorName { get; set; }
    }
}
