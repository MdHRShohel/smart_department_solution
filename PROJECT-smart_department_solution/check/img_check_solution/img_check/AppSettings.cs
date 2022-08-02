using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace img_check
{
    public static class AppSettings
    {
        public static string ConnectionString()
        {
            string conString = "Server=localhost; database=test; Uid=root; Pwd=''; SslMode=none";
            return conString;
        }
    }
}
