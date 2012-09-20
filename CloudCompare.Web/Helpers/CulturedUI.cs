using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text;
using System.Linq.Expressions;
using System.Web.Mvc.Html;
using System.Threading;
using System.Resources;

namespace CloudCompare.Web.Helpers
{
    public static class ViewModelHelpers
    {
        #region DropDownListForCulture
        public static MvcHtmlString DropDownListForCulture<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression
            , IEnumerable<SelectListItem> selectList, IList<CloudCompare.Domain.Models.Category> categories
            )
        {
            //var metaData = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);
            //var names = Enum.GetNames(metaData.ModelType);
            //var sb = new StringBuilder();
            //foreach (var name in names)
            //{
            //    var id = string.Format("{0}_{1}_{2}", htmlHelper.ViewData.TemplateInfo.HtmlFieldPrefix, metaData.PropertyName, name);
            //    var radio = htmlHelper.RadioButtonFor(expression, name, new { id = id }).ToHtmlString();
            //    sb.AppendFormat("<label for=\"{0}\">{1}</label> {2}", id, HttpUtility.HtmlEncode(name), radio);
            //}
            //return MvcHtmlString.Create(sb.ToString());


            // Create the resource manager.
            //Assembly assembly = this.GetType().Assembly;
            //ResFile.Strings -> <Namespace>.<ResourceFileName i.e. Strings.resx> 
            //ResourceManager resman = new ResourceManager("StringResources.Strings", assembly);

            string culture;
            //culture = System.Globalization.RegionInfo.CurrentRegion.TwoLetterISORegionName;
            //culture = "SE";
            //culture = categories.CategoryName;
            //ResourceManager resman = null;
            //switch (culture)
            //{
            //    case "NO":
            //        resman = new ResourceManager(typeof(ACMEE.App_LocalResources.NO_Case));
            //        break;
            //    case "SE":
            //        resman = new ResourceManager(typeof(ACMEE.App_LocalResources.SE_Case));
            //        break;
            //    case "DK":
            //        resman = new ResourceManager(typeof(ACMEE.App_LocalResources.DK_Case));
            //        break;
            //    default:
            //        throw new Exception("Could not establish culture: " + culture);
            //        break;
            //}
            var sb = new StringBuilder();
            sb.AppendFormat("<select data-val=\"true+\" data-val-required=\"The Reason Code field is required.\" id=\"ReasonCode\" name=\"ReasonCode\">");
            var metaData = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);
            //var names = Enum.GetNames(metaData.ModelType);
            var names = selectList;
            SelectListItem selectedValue = names.Where(x => x.Selected).FirstOrDefault();
            //foreach (var name in names)
            foreach (var name in categories)
            {
                //var id = string.Format("{0}_{1}_{2}", htmlHelper.ViewData.TemplateInfo.HtmlFieldPrefix, metaData.PropertyName, name);
                //var item1 = htmlHelper.DropDownListFor(expression, names, new { id = id }).ToHtmlString();
                //var item2 = htmlHelper.DropDownList("ReasonCode", names, new { id = id }).ToHtmlString();

                //var selectValue = name.Value;
                var selectValue = name.CategoryID.ToString();
                //var selectDisplayValue = name.Text;
                var selectDisplayValue = name.CategoryName;
                var language = "EN-US";

                string item3;
                if (selectedValue.Value == selectValue)
                {
                    item3 = "<option value=\"" + selectValue + "\" culture=\"" + language + "\"" + "selected=\"selected" + "\">" + selectDisplayValue + "</option>";
                }
                else
                {
                    item3 = "<option value=\"" + selectValue + "\" culture=\"" + language + "\">" + selectDisplayValue + "</option>";
                }
                //sb.AppendFormat("<label for=\"{0}\">{1}</label> {2}", id, HttpUtility.HtmlEncode(name), radio);
                //if (language == "NO")
                {
                    sb.AppendFormat(item3);
                }
            }
            sb.AppendFormat("</select>");


            // Load the value of string value for Client
            var field = (expression.Parameters[0] as ParameterExpression);
            var generictype = field.GetType();

            string key = field.Name;
            //string strLabel = resman.GetString(key);

            //return MvcHtmlString.Create("<label for=\"DOMESTIC_" + key + "\">" + strLabel + "</label>");
            //return MvcHtmlString.Create("<option value=\"103\">Faktura kopi / Invoice copy</option>");
            return MvcHtmlString.Create(sb.ToString());
        }
        #endregion

        #region DropDownListForCulture2
        public static MvcHtmlString DropDownListForCulture2<TModel, TProperty, TItems>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression
            , IEnumerable<SelectListItem> selectList, IList<TItems> modelItems
            )
        {
            //var metaData = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);
            //var names = Enum.GetNames(metaData.ModelType);
            //var sb = new StringBuilder();
            //foreach (var name in names)
            //{
            //    var id = string.Format("{0}_{1}_{2}", htmlHelper.ViewData.TemplateInfo.HtmlFieldPrefix, metaData.PropertyName, name);
            //    var radio = htmlHelper.RadioButtonFor(expression, name, new { id = id }).ToHtmlString();
            //    sb.AppendFormat("<label for=\"{0}\">{1}</label> {2}", id, HttpUtility.HtmlEncode(name), radio);
            //}
            //return MvcHtmlString.Create(sb.ToString());


            // Create the resource manager.
            //Assembly assembly = this.GetType().Assembly;
            //ResFile.Strings -> <Namespace>.<ResourceFileName i.e. Strings.resx> 
            //ResourceManager resman = new ResourceManager("StringResources.Strings", assembly);

            string culture;
            //culture = System.Globalization.RegionInfo.CurrentRegion.TwoLetterISORegionName;
            //culture = "SE";
            //culture = categories.CategoryName;
            //ResourceManager resman = null;
            //switch (culture)
            //{
            //    case "NO":
            //        resman = new ResourceManager(typeof(ACMEE.App_LocalResources.NO_Case));
            //        break;
            //    case "SE":
            //        resman = new ResourceManager(typeof(ACMEE.App_LocalResources.SE_Case));
            //        break;
            //    case "DK":
            //        resman = new ResourceManager(typeof(ACMEE.App_LocalResources.DK_Case));
            //        break;
            //    default:
            //        throw new Exception("Could not establish culture: " + culture);
            //        break;
            //}
            var sb = new StringBuilder();
            sb.AppendFormat("<select data-val=\"true+\" data-val-required=\"The Reason Code field is required.\" id=\"ReasonCode\" name=\"ReasonCode\">");
            var metaData = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);
            //var names = Enum.GetNames(metaData.ModelType);
            MultiSelectList names = selectList as SelectList;
            SelectListItem selectedValue = names.Where(x => x.Selected).FirstOrDefault();
            //foreach (var name in names)
            foreach (SelectListItem name in names)
            {
                //var id = string.Format("{0}_{1}_{2}", htmlHelper.ViewData.TemplateInfo.HtmlFieldPrefix, metaData.PropertyName, name);
                //var item1 = htmlHelper.DropDownListFor(expression, names, new { id = id }).ToHtmlString();
                //var item2 = htmlHelper.DropDownList("ReasonCode", names, new { id = id }).ToHtmlString();

                //var selectValue = name.Value;
                var selectValue = "name.CategoryID.ToString()";  //TODO
                selectValue = name.Value;
                //var selectDisplayValue = name.Text;
                var selectDisplayValue = "name.CategoryName";  //TODO
                selectDisplayValue = name.Text;
                var language = "EN-US";

                string item3;
                if (selectedValue.Value == selectValue)
                {
                    item3 = "<option value=\"" + selectValue + "\" culture=\"" + language + "\"" + "selected=\"selected" + "\">" + selectDisplayValue + "</option>";
                }
                else
                {
                    item3 = "<option value=\"" + selectValue + "\" culture=\"" + language + "\">" + selectDisplayValue + "</option>";
                }
                //sb.AppendFormat("<label for=\"{0}\">{1}</label> {2}", id, HttpUtility.HtmlEncode(name), radio);
                //if (language == "NO")
                {
                    sb.AppendFormat(item3);
                }
            }
            sb.AppendFormat("</select>");


            // Load the value of string value for Client
            var field = (expression.Parameters[0] as ParameterExpression);
            var generictype = field.GetType();

            string key = field.Name;
            //string strLabel = resman.GetString(key);

            //return MvcHtmlString.Create("<label for=\"DOMESTIC_" + key + "\">" + strLabel + "</label>");
            //return MvcHtmlString.Create("<option value=\"103\">Faktura kopi / Invoice copy</option>");
            return MvcHtmlString.Create(sb.ToString());
        }
        #endregion

        #region LabelForCulture
        public static MvcHtmlString LabelForCulture<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression)
        {
            //var metaData = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);
            //var names = Enum.GetNames(metaData.ModelType);
            //var sb = new StringBuilder();
            //foreach (var name in names)
            //{
            //    var id = string.Format("{0}_{1}_{2}", htmlHelper.ViewData.TemplateInfo.HtmlFieldPrefix, metaData.PropertyName, name);
            //    var radio = htmlHelper.RadioButtonFor(expression, name, new { id = id }).ToHtmlString();
            //    sb.AppendFormat("<label for=\"{0}\">{1}</label> {2}", id, HttpUtility.HtmlEncode(name), radio);
            //}
            //return MvcHtmlString.Create(sb.ToString());


            // Create the resource manager.
            //Assembly assembly = this.GetType().Assembly;
            //ResFile.Strings -> <Namespace>.<ResourceFileName i.e. Strings.resx> 
            //ResourceManager resman = new ResourceManager("StringResources.Strings", assembly);

            //string culture = System.Globalization.RegionInfo.CurrentRegion.TwoLetterISORegionName;
            string threadCulture = Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName;
            string regionCulture = System.Globalization.RegionInfo.CurrentRegion.TwoLetterISORegionName;
            //var culture2 = (from ci in CultureInfo.GetCultures(CultureTypes.AllCultures)
            //                where ci.IetfLanguageTag.EndsWith("-" + threadCulture)
            //                select ci).FirstOrDefault();

            //string LINQCulture = culture2.IetfLanguageTag;
            //string culture = culture2.IetfLanguageTag.Substring(culture2.IetfLanguageTag.LastIndexOf("-") + 1);
            //model.TwoLetterISORegionName = culture.ToUpper();
            string culture = Thread.CurrentThread.CurrentUICulture.IetfLanguageTag;
            culture = culture.Substring(culture.LastIndexOf("-") + 1);

            //throw new Exception(
            //    "Thread culture: " + threadCulture + "." +
            //    "Region culture: " + regionCulture + "." +
            //    //"LINQ culture: " + LINQCulture + "." +
            //    "Calculated culture: " + culture + "."
            //    );

            //if (culture2 != null)
            //{
            //    Thread.CurrentThread.CurrentUICulture = culture2; // probably should only set the UICulture and use that one imo
            //    //Thread.CurrentThread.CurrentCulture = culture; 
            //}




            ResourceManager resman = null;
            switch (culture.ToUpper())
            {
                case "NO":
                    resman = new ResourceManager(typeof(CloudCompare.Web.App_LocalResources.ENGLISH));
                    break;
                case "NB":
                    resman = new ResourceManager(typeof(CloudCompare.Web.App_LocalResources.ENGLISH));
                    break;
                case "SE":
                    resman = new ResourceManager(typeof(CloudCompare.Web.App_LocalResources.ENGLISH));
                    break;
                case "DK":
                    resman = new ResourceManager(typeof(CloudCompare.Web.App_LocalResources.ENGLISH));
                    break;
                case "US":
                    resman = new ResourceManager(typeof(CloudCompare.Web.App_LocalResources.ENGLISH));
                    break;
                default:
                    throw new Exception("Could not establish culture: " + culture);
                    break;
            }
            // Load the value of string value for Client
            var field = (expression.Body as MemberExpression).Member;
            string key = field.Name.Trim().ToUpperInvariant();
            string strLabel = resman.GetString(key);

            return MvcHtmlString.Create("<label for=\"DOMESTIC_" + key + "\">" + strLabel + "</label>");
        }
        #endregion
    }
}