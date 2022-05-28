using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Security_system.Views
{
    public class AdminModel
    {
        public int user_id { get; set; }

        [Required(ErrorMessage = "Please enter employee code.")]
        [Range(1000, 99999, ErrorMessage = "Employee Code must be 4 or 5 digit long.")]
        public int emp_code { get; set; }

        [Required(ErrorMessage = "Please enter your name.")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Name cannot be longer than 100 characters")]
        public string name { get; set; }

        [Required(ErrorMessage = "Please enter your address.")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Address cannot be longer than 50 characters")]
        public string address { get; set; }

        [Required(ErrorMessage = "Please enter contact number.")]
        [StringLength(15, MinimumLength = 1, ErrorMessage = "Contact number cannot be longer than 15 characters")]
        [RegularExpression(@"[0][3][0-9]{2}[\-]?[0-9]{7}", ErrorMessage = "Correct format is: 0333(-)3333333.")]
        public string contact_num { get; set; }

        public string qualification { get; set; }

        [Required(ErrorMessage = "Please enter your role.")]
        public string role { get; set; }

        public string grade { get; set; }

        public string achievements { get; set; }

        [Required(ErrorMessage = "Please enter email address.")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Email address must be at least 5 characters long and cannot be longer than 50 characters")]
        public string email { get; set; }

        [Required(ErrorMessage = "Please enter password.")]
        [StringLength(20, MinimumLength = 1, ErrorMessage = "password cannot be longer than 20 characters")]
        public string password { get; set; }
    }
}