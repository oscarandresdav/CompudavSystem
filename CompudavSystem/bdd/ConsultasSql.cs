using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CompudavSystem.bdd
{
    public static class ConsultasSql
    {
        private static readonly MySqlConnection Connection = new MySqlConnection(Conexion.CadenaConexion(Conexion.User, Conexion.Password, Properties.Settings.Default.servidor, Conexion.Database));
        private static string SqlStament { get; set; } = "";

        public static bool Insertar(string tabla, string campos, string valores)
        {
            DataSet dataSet = new DataSet();
            SqlStament = $"INSERT INTO { tabla } (id, revision, { campos }) VALUES ('{Guid.NewGuid()}', '1', { valores })";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(SqlStament, Connection);
            try
            {
                dataAdapter.Fill(dataSet);
                return true;
            }
            catch (MySqlException err)
            {
                switch (err.Number)
                {
                    case 1062:
                        MessageBox.Show("Registro duplicado, operacion cancelada.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    case 1054:
                        MessageBox.Show("Columna o campo desconocido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    case 1292:
                        MessageBox.Show("Formato de fecha incorrecto.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    case 1364:
                        MessageBox.Show("No se registro por falta de campos obligatorios.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    default:
                        break;
                }
                return false;
            }
        }

        public static bool Actualizar(string tabla, string campos, string campoId, string valorId)
        {
            DataSet dataSet = new DataSet();
            SqlStament = $"UPDATE { tabla } SET { campos }, modified_at = '{DateTime.Now:yyyy-MM-dd HH:mm:ss.ffffff}', revision = (revision + 1) WHERE { campoId } = {valorId}";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(SqlStament, Connection);
            try
            {
                dataAdapter.Fill(dataSet);
                return true;
            }
            catch (MySqlException err)
            {
                switch (err.Number)
                {
                    case 1062:
                        MessageBox.Show("Registro duplicado, operacion cancelada.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    case 1054:
                        MessageBox.Show("Columna o campo desconocido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    case 1146:
                        MessageBox.Show($"Tabla {tabla} no existe", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    case 1292:
                        MessageBox.Show("Formato de fecha incorrecto.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    case 1364:
                        MessageBox.Show("No se registro por falta de campos obligatorios.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    default:
                        break;
                }
                return false;
            }
        }

        public static bool Eliminar(string tabla, string campoId, string valorId)
        {
            DataSet dataSet = new DataSet();
            SqlStament = $"DELETE FROM { tabla } WHERE { campoId } = {valorId}";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(SqlStament, Connection);
            try
            {
                dataAdapter.Fill(dataSet);
                return true;
            }
            catch (MySqlException err)
            {
                switch (err.Number)
                {
                    case 1062:
                        MessageBox.Show("Registro duplicado, operacion cancelada.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    case 1054:
                        MessageBox.Show("Columna o campo desconocido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    case 1292:
                        MessageBox.Show("Formato de fecha incorrecto.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    case 1364:
                        MessageBox.Show("No se registro por falta de campos obligatorios.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    case 1451:
                        MessageBox.Show("No se puede eliminar item relacionado.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    default:
                        break;
                }
                return false;
            }
        }

        public static DataTable ConsultaGeneral(string tabla, string campo = "*", string campoOrden = "name", string orden = "ASC")
        {
            DataSet dataSet = new DataSet();
            SqlStament = $"SELECT { campo } FROM { tabla } ORDER BY {campoOrden} {orden}";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(SqlStament, Connection);
            dataAdapter.Fill(dataSet, tabla);
            return dataSet.Tables[tabla];
        }

        public static DataTable ConsultaIndividual(string tabla, string campo, string condicion, string expresion, string valor)
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

        public static bool VerificarItemExistente(string tabla, string campo, string condicion, string expresion, string valor)
        {
            Connection.Close();
            SqlStament = $"SELECT { campo } FROM { tabla } WHERE { condicion } { expresion } '{ valor }'";
            Connection.Open();
            MySqlCommand command = new MySqlCommand(SqlStament, Connection);
            if (string.IsNullOrEmpty((string)command.ExecuteScalar()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static DataTable Busqueda(string tabla, string condicion, string valor, string campo = "*", string campoOrden = "name", string orden = "ASC")
        {
            DataSet dataSet = new DataSet();
            SqlStament = $"SELECT { campo } FROM { tabla } WHERE { condicion } LIKE '%{ valor }%' ORDER BY {campoOrden} {orden}";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(SqlStament, Connection);
            dataAdapter.Fill(dataSet, tabla);
            return dataSet.Tables[tabla];
        }

        public static DataTable Busqueda(string tabla, string condicion1, string condicion2, string valor, string campo = "*", string campoOrden = "name", string orden = "ASC")
        {
            DataSet dataSet = new DataSet();
            SqlStament = $"SELECT { campo } FROM { tabla } WHERE { condicion1 } LIKE '%{ valor }%' OR { condicion2 } LIKE '%{ valor }%' ORDER BY {campoOrden} {orden}";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(SqlStament, Connection);
            dataAdapter.Fill(dataSet, tabla);
            return dataSet.Tables[tabla];
        }

        public static DataTable Busqueda(string tabla, string condicion1, string condicion2, string condicion3, string valor, string campoFecha, string fechaInicio, string fechaFin, string campo = "*", string campoOrden = "name", string orden = "ASC")
        {
            DataSet dataSet = new DataSet();
            SqlStament = $"SELECT { campo } FROM { tabla } WHERE ({ condicion1 } LIKE '%{ valor }%' OR { condicion2 } LIKE '%{ valor }%' OR { condicion3 } LIKE '%{ valor }%') AND { campoFecha } BETWEEN { fechaInicio } AND { fechaFin } ORDER BY {campoOrden} {orden}";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(SqlStament, Connection);
            dataAdapter.Fill(dataSet, tabla);
            return dataSet.Tables[tabla];
        }

        public static DataTable TopItems(string tabla, string campoNombre, string campoCantidad, string campoTotal, string campoTipo, string valorTipo, string campoEstado, string valorEstado, string campoFecha, string fechaInicio, string fechaFin, string limite)
        {
            DataSet dataSet = new DataSet();
            SqlStament = $"SELECT {campoNombre}, SUM({campoCantidad}) AS {campoCantidad}, SUM({campoTotal}) AS {campoTotal}, {campoFecha} FROM { tabla } WHERE {campoTipo} = '{valorTipo}' AND {campoEstado} = '{valorEstado}' AND { campoFecha } BETWEEN { fechaInicio } AND { fechaFin } GROUP BY {campoNombre} ORDER BY {campoTotal} DESC LIMIT {limite}";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(SqlStament, Connection);
            dataAdapter.Fill(dataSet, tabla);
            return dataSet.Tables[tabla];
        }
        public static DataTable SumaTotalItem(string tabla, string campo, string campoTipo, string valorTipo, string campoEstado, string valorEstado, string campoFecha, string fechaInicio, string fechaFin)
        {
            DataSet dataSet = new DataSet();
            SqlStament = $"SELECT SUM({campo}) AS {campo} FROM { tabla } WHERE {campoTipo} = '{valorTipo}' AND {campoEstado} = '{valorEstado}' AND { campoFecha } BETWEEN { fechaInicio } AND { fechaFin }";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(SqlStament, Connection);
            dataAdapter.Fill(dataSet, tabla);
            return dataSet.Tables[tabla];
        }

        public static DataTable ConteoTotalItem(string tabla, string campoTipo, string valorTipo, string campoEstado, string valorEstado, string campoFecha, string fechaInicio, string fechaFin)
        {
            DataSet dataSet = new DataSet();
            SqlStament = $"SELECT COUNT(*) FROM { tabla } WHERE {campoTipo} = '{valorTipo}' AND {campoEstado} = '{valorEstado}' AND { campoFecha } BETWEEN { fechaInicio } AND { fechaFin }";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(SqlStament, Connection);
            dataAdapter.Fill(dataSet, tabla);
            return dataSet.Tables[tabla];
        }
    }
}
