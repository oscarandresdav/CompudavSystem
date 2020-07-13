using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CompudavSystem.bdd
{
    public class ConsultasSql
    {
        readonly MySqlConnection Connection = new MySqlConnection(Conexion.CadenaConexion(Conexion.User, Conexion.Password, Conexion.Server));
        private string SqlStament { get; set; } = "";

        public void Insertar(string tabla, string campos, string valores) 
        {
            DataSet dataSet = new DataSet();
            SqlStament = $"INSERT INTO {tabla} ({campos}) VALUES ({valores})";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(SqlStament, Connection);
            try
            {
                dataAdapter.Fill(dataSet);
            }
            catch (MySqlException err)
            {
                switch (err.Number)
                {
                    case 1062:
                        MessageBox.Show("Registro duplicado, operacion cancelada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    case 1054:
                        MessageBox.Show("Columna o campo desconocido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                }
                //throw;
            }
        }
    }
}
