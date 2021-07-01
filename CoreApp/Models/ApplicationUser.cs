using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp.Models
{
    public class ApplicationUser : IdentityUser
    {
        #region Properties

        [Display(Name = "First Name")]
        public string FirstName { get; set; }


        [Display(Name = "Last Name")]
        public string LastName { get; set; }


        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        //[Display(Name = "Date of Birth")]
        //public DateTime DataOfBirth { get; set; }


        [Display(Name = "Company Name")]
        public string Company { get; set; }


        public int UserNameChangeLimit { get; set; } = 10;
        public byte[] ProfilePicture { get; set; }

        #endregion

        #region Constructor

        public ApplicationUser()
        {}

        #endregion
    }
}
