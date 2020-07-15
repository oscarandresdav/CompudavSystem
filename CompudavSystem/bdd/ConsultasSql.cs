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
    public static class ConsultasSql
    {
        private static readonly MySqlConnection Connection = new MySqlConnection( Conexion.CadenaConexion( Conexion.User, Conexion.Password, Properties.Settings.Default.servidor, Conexion.Database ) );
        private static string SqlStament { get; set; } = "";

        public static bool Insertar( string tabla, string campos, string valores ) 
        {
            DataSet dataSet = new DataSet();
            SqlStament = $"INSERT INTO { tabla } (id, { campos }) VALUES ('{Guid.NewGuid()}', { valores })";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter( SqlStament, Connection );
            try
            {
                dataAdapter.Fill( dataSet );
                return true;
            }
            catch ( MySqlException err )
            {
                switch ( err.Number )
                {
                    case 1062:
                        MessageBox.Show( "Registro duplicado, operacion cancelada.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
                        break;
                    case 1054:
                        MessageBox.Show("Columna o campo desconocido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    case 1364:
                        MessageBox.Show("No se registro por falta de campos obligatorios.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;

                }
                return false;
                //throw;
            }
        }


        public static DataTable ConsultaGeneral(string tabla, string campo = "*")
        {
            DataSet dataSet = new DataSet();
            SqlStament = $"SELECT { campo } FROM { tabla }";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(SqlStament, Connection);
            dataAdapter.Fill(dataSet, tabla);
            return dataSet.Tables[tabla];
        }
        public static DataTable ConsultaIndividual( string tabla, string campo, string condicion, string expresion,string valor )
        {
            DataSet dataSet = new DataSet();
            SqlStament = $"SELECT { campo } FROM { tabla } WHERE { condicion } { expresion } '{ valor }'";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(SqlStament, Connection);
            dataAdapter.Fill(dataSet, tabla);
            return dataSet.Tables[tabla];
        }

        public static DataTable ConsultaIndividual(string tabla, string campo, string condicion, string expresion, string valor, string condicion2, string expresion2, string valor2)
        {
            DataSet dataSet = new DataSet();
            SqlStament = $"SELECT { campo } FROM { tabla } WHERE { condicion } { expresion } '{ valor }' AND { condicion2 } { expresion2 } '{ valor2 }'";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(SqlStament, Connection);
            dataAdapter.Fill(dataSet, tabla);
            return dataSet.Tables[tabla];
        }


    }
}
