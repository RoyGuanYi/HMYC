using System;
using System.Linq.Expressions;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace Charm.MvcExt.HtmlInput
{
    public static class OctDatePicker
    {
        public static MvcHtmlString DatePickerFor<TM, Tp>(this HtmlHelper<TM> helper, Expression<Func<TM, Tp>> expression
          )
        {
            return helper.TextBoxFor(expression, new { @class = "date-picker input-sm", data_date_format = "yyyy-mm-dd"});
        }

      /*  public static MvcHtmlString DateTimePickerFor<TM, Tp>(this HtmlHelper<TM> helper, Expression<Func<TM, Tp>> expression
         )
        {
            return helper.TextBoxFor(expression, new { @class = "date-picker input-sm", data_date_format = "yyyy-mm-dd HH:mm:ss" });
        }*/
    }
}
