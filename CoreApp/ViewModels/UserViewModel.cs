using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp.ViewModels
{
    public class UserViewModel
    {
        public string Id { get; set; }

        [Display(Name="First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "User Id")]
        public string UserName { get; set; }

        [Display(Name = "Email Id")]
        public string Email { get; set; }
    }
}
