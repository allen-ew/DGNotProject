using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgNotification.Shared.Helpers
{
    public class clsStringFormatter
    {
        public static string ToTitleCase(string prmString)
        {
            if (string.IsNullOrWhiteSpace(prmString))
            {
                return prmString;
            }
            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(prmString.ToLower());
        }
    }
}
