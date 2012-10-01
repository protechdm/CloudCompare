using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
//using CloudCompare.Domain.Models;
using System.ComponentModel;
//using Microsoft.Web.Mvc.DataAnnotations;

namespace CloudCompare.Web.Models
{
    public class SearchInputModel
    {
        private void Test()
        {
            System.ComponentModel.DisplayNameAttribute d = new System.ComponentModel.DisplayNameAttribute();
            
        }
        //[Display(Name = "Categories", ResourceType = typeof(App_LocalResources.ENG_Case))]
        [Display(Name = "Categories")]
        public IList<CategoryModel> Categories { get; set; }

        [Display(Name = "Category ID")]
        public int ChosenCategoryID { get; set; }

        [Display(Name = "Number Of Users")]
        public IList<NumberOfUsersModel> NumberOfUsers { get; set; }

        [Display(Name = "Chosen Number Of Users")]
        public int ChosenNumberOfUsers { get; set; }

        
        [DisplayName("First Name")]
        [Display(Name = "First Name")]
        [Required]
        //[Required(ErrorMessage = "Name is required")]
        //[StringLength(3, ErrorMessage = "Must be under 50 characters")]
        public string Firstname { get; set; }

        [Display(Name = "email")]
        [Required(ErrorMessage = "EMail Required")]
        [RegularExpression("^[a-z0-9_\\+-]+(\\.[a-z0-9_\\+-]+)*@[a-z0-9-]+(\\.[a-z0-9-]+)*\\.([a-z]{2,4})$", ErrorMessage = "Not a valid EMail address")]
        public string EMailAddress { get; set; }

        //[Display(Name = "Search Filter ID")]
        public int SearchInputID { get; set; }

        //[Display(Name = "Category ID")]
        public int CategoryID { get; set; }
        public int OperatingSystemID { get; set; }

        //[Display(Name = "Name")]
        //[Required(ErrorMessage="Name is required")]
        //[StringLength(50,ErrorMessage="Must be under 50 characters")]
        //public string SearchFilterName { get; set; }

        //[Display(Name = "Selected")]
        //public string Name { get; set; }
        //public string EMailAddress { get; set; }    


    }
}





