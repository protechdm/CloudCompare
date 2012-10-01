using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
//using System.Web.Mvc;
using System.Web.Security;

namespace CloudCompare.Web.Models
{

    public class FreeTrialBuyNowModel
    {
        [Required]
        //[DataType(DataType.Text)]
        [Display( Name="First Name")]
        public string FirstName { get; set; }

        [Required]
        [DataType(DataType.Text)]
        //[Display(Name = "Current password")]
        public string Surname { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        //[Display(Name = "Current password")]
        public string EMailAddress { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        //[Display(Name = "Current password")]
        public string Telephone { get; set; }

        [Required]
        [DataType(DataType.Text)]
        //[Display(Name = "Current password")]
        public string Company { get; set; }

        [Required]
        [DataType(DataType.Text)]
        //[Display(Name = "Current password")]
        public int NumberOfEmployees { get; set; }

        [Required]
        //[DataType(DataType.Text)]
        [Display(Name = "FREE Trial")]
        public bool FreeTrial { get; set; }

        [Required]
        //[DataType(DataType.Text)]
        [Display(Name = "Buy now")]
        public bool BuyNow { get; set; }

        //[Required]
        //[StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        //[DataType(DataType.Password)]
        //[Display(Name = "New password")]
        //public string NewPassword { get; set; }

        //[DataType(DataType.Password)]
        //[Display(Name = "Confirm new password")]
        //[Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        //public string ConfirmPassword { get; set; }
    }

}
