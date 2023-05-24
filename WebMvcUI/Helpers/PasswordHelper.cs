using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMvcUI.Helpers
{
    public static class PasswordHelper
    {
        public static string CreateTempPassword()
        {
            return Guid.NewGuid().ToString().Replace("-", "").Substring(0, 6);
        }
    }
}
