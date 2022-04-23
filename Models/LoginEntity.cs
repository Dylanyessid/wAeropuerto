using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using frmAeropuerto.Models;
using Npgsql;

namespace frmAeropuerto.Models
{
    internal class LoginEntity
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public LoginEntity(string email, string password)
        {
            Email = email;
            Password = password;
        }
        public LoginEntity()
        {

        }
        /*Método que autentifica las credenciales ingresadas*/
        public bool login()
        {
            try
            {
                var cmd = new NpgsqlCommand($"Select * from logins where email=@email", Connection.connectDatabase());
                cmd.Parameters.AddWithValue("@email", Email);
                NpgsqlDataReader dr =  cmd.ExecuteReader();

                while (dr.Read())
                {
                    if (dr.GetString(1) == Password)
                    {
                        return true;
                    }
                    else
                    {
                       
                        break;
                    }
                    
                }
                return false;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
