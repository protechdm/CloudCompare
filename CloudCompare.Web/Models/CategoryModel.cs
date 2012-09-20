using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloudCompare.Web.Models
{
    public class CategoryModel
    {
        //[Display(Name = "Search Filter ID")]
        public int SearchFilterID { get; set; }

        //[Display(Name = "Category ID")]
        public int CategoryID { get; set; }

        //[Display(Name = "Name")]
        //[Required(ErrorMessage="Name is required")]
        //[StringLength(50,ErrorMessage="Must be under 50 characters")]
        //public string SearchFilterName { get; set; }

        //[Display(Name = "Selected")]
        public string CategoryName { get; set; }
        public bool Selected { get; set; }    
    }
}





