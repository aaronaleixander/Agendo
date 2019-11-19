using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Agendo.Models
{
    public class UserAccount
    {
        public int UserID { get; set; }

        /// <summary>
        /// The users First Name
        /// </summary>
        [Required]
        public string FirstName { get; set; }

        /// <summary>
        /// The users last name
        /// </summary>
        [Required]
        public string LastName { get; set; }

        /// <summary>
        /// The users chosen username from site use.
        /// </summary>
        [Required]
        public string UserName { get; set; }

        /// <summary>
        /// Users E - Mail Address
        /// </summary>
        [Required]
        public string EmailAddress { get; set; }

        /// <summary>
        /// User Passwword
        /// </summary>
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        /// <summary>
        /// Users Date of Birth
        /// </summary>
        [Display(Name ="Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Username or Email")]
        public string UsernameOrEmail { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }

}
