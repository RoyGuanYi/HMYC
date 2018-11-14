using System.Text;
using System.Web.Mvc;

namespace Charm.MvcExt.HtmlInput
{
    public static class OctAddressSelect
    {
        public static MvcHtmlString AddressSelect(this HtmlHelper helper, string proId = "proId", string cityId = "cityId", string areaId = "areaId", string pro = "", string city = "", string area="")
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<select name='" + proId + "' id='" + proId + "' class='input-sm'></select>");
            sb.Append("<select name='" + cityId + "' id='" + cityId + "' class='input-sm'></select>");
            sb.Append("<select name='" + areaId + "' id='" + areaId + "' class='input-sm'></select>");
            sb.Append("  <script type='text/javascript' src='/assets/charm/js/address.js'> </script> ");
            sb.Append("  <script type='text/javascript'>  ");
            sb.Append(" addressInit('" + proId + "', '" + cityId + "', '" + areaId + "');  ");
            sb.Append(" </script>  ");

            return MvcHtmlString.Create(sb.ToString());
        }
    }
}
