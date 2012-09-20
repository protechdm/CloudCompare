using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloudCompare.Web.Models
{
    public class LicenceTypeMinimumModel
    {
        //[Display(Name = "Search Filter ID")]
        public int SearchFilterID { get; set; }

        //[Display(Name = "Name")]
        //[Required(ErrorMessage="Name is required")]
        //[StringLength(50,ErrorMessage="Must be under 50 characters")]
        //public string SearchFilterName { get; set; }

        //[Display(Name = "Selected")]
        public int LicenceTypeMinimumID { get; set; }
        public string LicenceTypeMinimumName { get; set; }
    }

    public class LicenceTypeMaximumModel
    {
        //[Display(Name = "Search Filter ID")]
        public int SearchFilterID { get; set; }

        //[Display(Name = "Name")]
        //[Required(ErrorMessage="Name is required")]
        //[StringLength(50,ErrorMessage="Must be under 50 characters")]
        //public string SearchFilterName { get; set; }

        //[Display(Name = "Selected")]
        public int LicenceTypeMaximumID { get; set; }
        public string LicenceTypeMaximumName { get; set; }
    }

}





