using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using frmAeropuerto.Models;
namespace frmAeropuerto.Controllers
{
    internal class LoginController
    {
        private LoginEntity loginEntity;
        public LoginController(string email, string password)
        {
            loginEntity = new LoginEntity(email, password);
        }

        //Ejecuta el método de logueo
        public bool executeLogin()
        {

            if (loginEntity.login())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
