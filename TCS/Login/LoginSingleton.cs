using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCS.Login
{
    class LoginSingleton
    {
        private static LoginSingleton log;
        private LoginSingleton()
        {

        }

        public static LoginSingleton getInstance()
        {
            if (log == null)
            {
                log = new LoginSingleton();
            }
            return log;
        }
    }
}
