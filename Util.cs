using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace BlazorServerArcane
{
    public class Util
    {
        public string ConvertToLocalTime(DateTime? dateTime)
        {
            return TimeZoneInfo.ConvertTimeFromUtc((DateTime)dateTime, TimeZoneInfo.Local).ToString("MM/dd/yyyy hh:mm tt");
        }
    }
}
