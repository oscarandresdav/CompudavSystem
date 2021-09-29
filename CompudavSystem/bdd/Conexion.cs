using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CompudavSystem.bdd
{
    public static class Conexion
    {
        public static string User { get; set; } = "andres";
        public static string Password { get; set; } = "123456";
        public static string Server { get; set; } = Properties.Settings.Default.servidor;
        public static string Database { get; set; } = "compudav";


        public static string CadenaConexion(string usuario, string clave, string servidor, string database)
        {
            MySqlConnectionStringBuilder stringBuilder = new MySqlConnectionStringBuilder
            {
                UserID = usuario,
                Password = clave,
                Server = servidor,
                Database = database,
            };
            return stringBuilder.ConnectionString;
        }

        public static string InicializarInstanciaMySQL(string usuario, string clave, string servidor, string database)
        {
            MySqlConnection connection = new MySqlConnection(CadenaConexion(usuario, clave, servidor, database));
            try
            {
                connection.Open();
                return true.ToString();
            }
            catch (MySqlException err)
            {
                switch (err.Number)
                {
                    case 0:
                        MessageBox.Show("Usuario o clave del host MySQL erroneo", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    case 1042:
                        MessageBox.Show("No se puede conectar a ninguno de los hosts MySQL especificados", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    case 1049:
                        MessageBox.Show("Base de datos desconocida", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                }
                return false.ToString();
            }
            finally
            {
                connection.Close();
            }
        }

    }
}
