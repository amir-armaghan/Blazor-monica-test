using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Share
{
    public static class StrignHelper
    {
        public static string RemoveQuotation(this string str)
        {
            return str.Replace("\"", "");
        }
    }
}
