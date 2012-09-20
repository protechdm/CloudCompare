using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;
using CloudCompare.Domain.Models;

namespace CloudCompare.Web.Models
{

    public class HomePageModel
    {
        //[Display(Name = "Categories", ResourceType = typeof(App_LocalResources.ENG_Case))]
        [Display(Name = "Categories")]
        public IList<Category> Categories { get; set; }

        [Display(Name = "Category ID")]
        public int ChosenCategoryID { get; set; }

        [Display(Name = "Operating Systems")]
        public IList<Domain.Models.OperatingSystem> OperatingSystems { get; set; }

        [Display(Name = "Operating System ID")]
        public int ChosenOperatingSystemID { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage="Name is required")]
        [StringLength(50,ErrorMessage="Must be under 50 characters")]
        public string Name { get; set; }

        [Display(Name = "email")]
        [Required(ErrorMessage="EMail Required")]
        [RegularExpression("^[a-z0-9_\\+-]+(\\.[a-z0-9_\\+-]+)*@[a-z0-9-]+(\\.[a-z0-9-]+)*\\.([a-z]{2,4})$",ErrorMessage="Not a valid EMail address")]
        public string EMailAddress { get; set; }

        public TabbedSearchResults TabbedSearchResults { get; set; }
    }

}
