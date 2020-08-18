using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using CompudavSystem.bdd;

namespace CompudavSystem.historico
{
    public partial class Historial : Form
    {
        private string TableBdd { get; set; } = "document_history";
        public Historial()
        {
            InitializeComponent();
            DatosIniciales();
            rangoFechaComboBox.SelectedIndex = 4;
        }

        public void DatosIniciales()
        {
            listadoDataGridView.DataSource = ConsultasSql.ConsultaGeneral(TableBdd);
            
            listadoDataGridView.Columns["number"].HeaderText = "NÚMERO";
            listadoDataGridView.Columns["number"].Width = 110;
            listadoDataGridView.Columns["number"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            listadoDataGridView.Columns["name"].Width = 180;
            listadoDataGridView.Columns["name"].HeaderText = "CONTACTO";
            listadoDataGridView.Columns["date_of_issue"].HeaderText = "FECHA";
            listadoDataGridView.Columns["date_of_issue"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            listadoDataGridView.Columns["date_of_issue"].DefaultCellStyle.Format = "MMMM dd, yyyy";
            listadoDataGridView.Columns["product"].HeaderText = "PRODUCTO";
            listadoDataGridView.Columns["product"].Width = 120;
            listadoDataGridView.Columns["quantity"].HeaderText = "CANT.";
            listadoDataGridView.Columns["quantity"].Width = 50;
            listadoDataGridView.Columns["quantity"].DefaultCellStyle.Format = "N0";
            listadoDataGridView.Columns["quantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            listadoDataGridView.Columns["total_value"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            listadoDataGridView.Columns["type_document"].HeaderText = "TIPO";
            listadoDataGridView.Columns["type_document"].Width = 65;
            listadoDataGridView.Columns["type_document"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            listadoDataGridView.Columns["status_document"].HeaderText = "ESTADO";
            listadoDataGridView.Columns["status_document"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            listadoDataGridView.Columns["status_document"].Width = 70;

            listadoDataGridView.Columns["total_value"].Visible = false;
            listadoDataGridView.Columns["idDocument"].Visible = false;
            listadoDataGridView.Columns["invoice_detailment"].Visible = false;
            listadoDataGridView.Columns["payment_method"].Visible = false;
            listadoDataGridView.Columns["subtotal"].Visible = false;
        }

        public void Busqueda()
        {
            DateTime dateTimeStart = toDateTimePicker.Value;
            string fechaInicio = $"'{dateTimeStart: yyyy-MM-dd} 00:00:00'";
            DateTime dateTimeEnd = fromDateTimePicker.Value;
            string fechaFin = $"'{dateTimeEnd: yyyy-MM-dd} 23:59:59'";
            string busqueda = busquedaTextBox.Text.Replace("'", "\\'").Trim();
            listadoDataGridView.DataSource = ConsultasSql.Busqueda(tabla: TableBdd, condicion1: "name", condicion2: "number", condicion3: "product", valor: $"{ busqueda }",campoFecha: "date_of_issue", fechaInicio: $"{ fechaInicio }", fechaFin: $"{ fechaFin }", campo: "*", campoOrden: "date_of_issue", orden: "DESC");
        }

        private void CrearBotonAccionesDatagridview(string headerText, string name, Bitmap pathImage)
        {
            DataGridViewImageColumn img = new DataGridViewImageColumn();
            Image image = pathImage;
            img.Image = image;
            listadoDataGridView.Columns.Add(img);
            img.HeaderText = headerText;
            img.Name = name;
            img.Width = 60;
        }

        private void RangoFechaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            toDateTimePicker.Value = DateTime.Today;
            fromDateTimePicker.Value = DateTime.Today;

            switch (rangoFechaComboBox.SelectedIndex)
            {
                case 0: //Hoy
                    toDateTimePicker.Value = DateTime.Today;
                    fromDateTimePicker.Value = DateTime.Today;
                    toDateTimePicker.Enabled = false;
                    fromDateTimePicker.Enabled = false;
                    break;
                case 1: //Ayer
                    toDateTimePicker.Value = DateTime.Today.AddDays(-1);
                    fromDateTimePicker.Value = DateTime.Today.AddDays(-1);
                    toDateTimePicker.Enabled = false;
                    fromDateTimePicker.Enabled = false;
                    break;
                case 2: //Este mes
                    toDateTimePicker.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
                    fromDateTimePicker.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1).AddMonths(1).AddDays(-1);
                    toDateTimePicker.Enabled = false;
                    fromDateTimePicker.Enabled = false;
                    break;
                case 3: //Mes anterior
                    toDateTimePicker.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1).AddMonths(-1);
                    fromDateTimePicker.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1).AddDays(-1);
                    toDateTimePicker.Enabled = false;
                    fromDateTimePicker.Enabled = false;
                    break;
                case 4: //Últimos 30 días
                    toDateTimePicker.Value = DateTime.Today.AddMonths(-1);
                    fromDateTimePicker.Value = DateTime.Today;
                    toDateTimePicker.Enabled = false;
                    fromDateTimePicker.Enabled = false;
                    break;
                case 5: //Último trimestre
                    toDateTimePicker.Value = DateTime.Today.AddMonths(-3);
                    fromDateTimePicker.Value = DateTime.Today;
                    toDateTimePicker.Enabled = false;
                    fromDateTimePicker.Enabled = false;
                    break;
                case 6: //Último semestre
                    toDateTimePicker.Value = DateTime.Today.AddMonths(-6);
                    fromDateTimePicker.Value = DateTime.Today;
                    toDateTimePicker.Enabled = false;
                    fromDateTimePicker.Enabled = false;
                    break;
                case 7: //Este año
                    toDateTimePicker.Value = new DateTime(DateTime.Today.Year, 1, 1);
                    fromDateTimePicker.Value = new DateTime(DateTime.Today.Year, 12, 1).AddMonths(1).AddDays(-1);
                    toDateTimePicker.Enabled = false;
                    fromDateTimePicker.Enabled = false;
                    break;
                case 8: //Año anterior
                    toDateTimePicker.Value = new DateTime(DateTime.Today.Year, 1, 1).AddYears(-1);
                    fromDateTimePicker.Value = new DateTime(DateTime.Today.Year, 12, 1).AddYears(-1).AddMonths(1).AddDays(-1);
                    toDateTimePicker.Enabled = false;
                    fromDateTimePicker.Enabled = false;
                    break;
                case 9: //Seleccionar rango
                    toDateTimePicker.Enabled = true;
                    fromDateTimePicker.Enabled = true;
                    break;
                default:
                    break;
            }
        }

        private void BusquedaTextBox_TextChanged(object sender, EventArgs e)
        {
            Busqueda();
        }

        private void ToDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (toDateTimePicker.Value.Ticks > fromDateTimePicker.Value.Ticks)
            {
                toDateTimePicker.Value = fromDateTimePicker.Value;
            }
            if (toDateTimePicker.Value.Ticks <= fromDateTimePicker.Value.Ticks)
            {
                Busqueda();
            }
        }

        private void FromDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (fromDateTimePicker.Value.Ticks < toDateTimePicker.Value.Ticks)
            {
                fromDateTimePicker.Value = toDateTimePicker.Value;
            }
            if (fromDateTimePicker.Value.Ticks >= toDateTimePicker.Value.Ticks)
            {
                Busqueda();
            }
        }

        private void Historial_Load(object sender, EventArgs e)
        {
            CrearBotonAccionesDatagridview("Anular", "anularButton", Properties.Resources.rollback_18px);
            listadoDataGridView.Columns["anularButton"].DefaultCellStyle.Padding = new Padding(0, 0, 15, 0);
        }

        private void ListadoDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && listadoDataGridView.CurrentCell.OwningColumn.Name == "anularButton")
            {
                if ($"{listadoDataGridView.Rows[e.RowIndex].Cells["status_document"].Value}" == "Anulado")
                {
                    MessageBox.Show("Factura anulada","Información",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    if (MessageBox.Show($"¿Estas seguro que deseas anular la factura \n#{listadoDataGridView.Rows[e.RowIndex].Cells["number"].Value} del contacto \n{listadoDataGridView.Rows[e.RowIndex].Cells["name"].Value}?", "Anular factura", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        DataTable dataStatus = ConsultasSql.ConsultaIndividual("status_document", "id", "name", "=", "Anulado");
                        string statusDocumentId = dataStatus.Rows[0][0].ToString();
                        if (ConsultasSql.Actualizar("document", $"statusDocumentId = '{statusDocumentId}'", "id", $"'{listadoDataGridView.Rows[e.RowIndex].Cells["idDocument"].Value}'"))
                        {
                            DataTable dataInvoiceDetailment = ConsultasSql.ConsultaIndividual("invoice_detailment", "quantity, productId", "documentId", "=", $"{listadoDataGridView.Rows[e.RowIndex].Cells["idDocument"].Value}");
                            for (int i = 0; i < dataInvoiceDetailment.Rows.Count; i++)
                            {
                                DataTable dataMinimumStock = ConsultasSql.ConsultaIndividual("product", "stock, minimum_stock_level", "id", "=", $"{dataInvoiceDetailment.Rows[i]["productId"]}");
                                int minimumStockInt = int.Parse(dataMinimumStock.Rows[0][1].ToString());
                                int stockInt = int.Parse(dataMinimumStock.Rows[0][0].ToString());
                                decimal quantityDecimal = decimal.Parse(dataInvoiceDetailment.Rows[i][0].ToString());
                                int quantityInt = Convert.ToInt32(quantityDecimal);
                                if ($"{listadoDataGridView.Rows[e.RowIndex].Cells["type_document"].Value}" == "COMPRA")
                                {
                                    stockInt -= quantityInt;
                                    ConsultasSql.Actualizar("product", $"stock = {stockInt}, stock_indicator = { stockInt - minimumStockInt}", "id", $"'{dataInvoiceDetailment.Rows[i]["productId"]}'");
                                }
                                if ($"{listadoDataGridView.Rows[e.RowIndex].Cells["type_document"].Value}" == "VENTA")
                                {
                                    stockInt += quantityInt;
                                    ConsultasSql.Actualizar("product", $"stock = {stockInt}, stock_indicator = { stockInt + minimumStockInt}", "id", $"'{dataInvoiceDetailment.Rows[i]["productId"]}'");
                                }
                            }
                            DatosIniciales();
                        }
                    }
                }
            }
        }
    }
}
