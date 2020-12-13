using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Homework.Domain
{
    public static class ConvertToDateString
    {
        public static string ToUsDateString (this DateTime thisDateTime,string format)
        {
            return thisDateTime.ToString(format, CultureInfo.CreateSpecificCulture("en-US"));
        }
    }
}
