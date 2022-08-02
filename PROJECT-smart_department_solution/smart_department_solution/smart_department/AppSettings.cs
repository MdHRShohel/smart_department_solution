using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_department
{
    public static class AppSettings
    {
        public static string ConnectionString()
        {
            string conString = "Server=localhost; database=smart_department; Uid=root; Pwd=''; SslMode=none";
            return conString;
        }
    }
}
