using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmAeropuerto.Models
{
    public static class Connection
    {
        //ESTOS DATOS SON LOCALES. TIENEN QUE ADAPTARSE A LA CONFIGURACIÓN DE SU SERVIDOR POSTGRES
        private static string host = "localhost";
        private static string user = "postgres";
        private static string password = "#Cavesandcliffspart2";
        private static string dbName = "dboAirport";
        private static string port = "5432";

        private static string connection = $"Server={host};Username={user};Database={dbName};Port={port};Password={password};SSLMode=Prefer";

        //Comprobar la conexión a la base de datos.
        public static Npgsql.NpgsqlConnection connectDatabase()
        {
            try
            {
                var conn = new Npgsql.NpgsqlConnection(connection);
                conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

    }
}
