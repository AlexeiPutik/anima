using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ANIMA.Services
{
    public class Config
    {
        public static string ConnectionString { get; set; }

        public static string ServiceName { get; set; }
        
        public static string CompanyName { get; set; }

        public static string CompanyPhone { get; set; }

        public static string CompanyEmail { get; set; }

        public static string NoReplyEmail { get; set; }

        public static string SupportEmail { get; set; }
    }
}
