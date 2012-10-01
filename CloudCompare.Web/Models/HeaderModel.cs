using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;
using CloudCompare.Domain.Models;

namespace CloudCompare.Web.Models
{
    #region HeaderModel
    public class HeaderModel
    {
        [DataType(DataType.Text)]
        [Display(Name = "Buy now")]
        [UIHint("SearchTextBox")]
        public string SearchText { get; set; }
    }
    #endregion
}
