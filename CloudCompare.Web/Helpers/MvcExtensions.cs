using System;
using System.Linq.Expressions;
using System.Web.Mvc;
using CloudCompare.Domain.Models;
using System.Collections.Generic;

namespace CloudCompare.Web.Helpers
{
    public static class MvcExtensions
    {
        public static string GetControllerName(this Type controllerType)
        {
            return controllerType.Name.Replace("Controller", string.Empty);
        }

        public static string GetFullControllerName(this Type controllerType)
        {
            return controllerType.FullName;
        }

        public static string GetActionName(this LambdaExpression actionExpression)
        {
            return ((MethodCallExpression)actionExpression.Body).Method.Name;
        }

        public static MvcHtmlString DisplayForExtended<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression, string templateName)
        {
            var x = expression.CanReduce;
            return System.Web.Mvc.Html.DisplayExtensions.DisplayFor<TModel, TValue>(html, expression, templateName);
            return null;
        }

        public static IEnumerable<CoordinateValue<T>> AsEnumerable<T>(this T[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    yield return new CoordinateValue<T>() { Value = arr[i, j], X = i, Y = j };
                    //string x = "";
                }
                string y = "";
            }
        }
    //    public static IEnumerable<TSource> WhereExtended<TSource>(this IEnumerable<TSource> source, Func<TSource, int, bool> predicate, int rowNumber)
    //where TSource : SearchFeature
    //    {
    //        IEnumerable<SearchFeature> x = System.Linq.Enumerable.Where<TSource>(source, predicate);
    //        int i = 0;
    //        foreach (SearchFeature sf in x)
    //        {
    //            sf.SearchFeatureRowNumber = i;
    //            i++;
    //        }
    //        return (IEnumerable<TSource>)x;
    //    }

    }

    public class CoordinateValue<T>
    {
        public T Value { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
    }
}