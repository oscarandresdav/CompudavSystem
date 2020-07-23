using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using CompudavSystem.bdd;

namespace CompudavSystem.catalogo
{
    public partial class Catalogo : Form, ICatalogo
    {
        private Fabricante FabricanteForm { get; set; } = new Fabricante();
        private Categoria CategoriaForm { get; set; } = new Categoria();
        private NuevoProducto NuevoItemForm { get; set; } = new NuevoProducto();
        private string TableBdd { get; set; } = "product";
        
        public Catalogo()
        {
            InitializeComponent();
            DatosIniciales();
        }

        public void DatosIniciales() 
        {
            listadoDataGridView.DataSource = ConsultasSql.ConsultaGeneral(TableBdd);
            listadoDataGridView.Sort(listadoDataGridView.Columns["name"], ListSortDirection.Ascending);
            listadoDataGridView.Columns["name"].HeaderText = "Descripción";
            listadoDataGridView.Columns["name"].Width = 347;
            
            listadoDataGridView.Columns["cost"].HeaderText = "Costo";
            listadoDataGridView.Columns["price"].HeaderText = "P.V.P.";
            listadoDataGridView.Columns["stock"].HeaderText = "Existencias";
            listadoDataGridView.Columns["stock"].Width = 90;

            listadoDataGridView.Columns["id"].Visible = false;
            listadoDataGridView.Columns["main_code"].Visible = false;
            listadoDataGridView.Columns["aux_code"].Visible = false;
            listadoDataGridView.Columns["detail"].Visible = false;
            listadoDataGridView.Columns["minimum_stock_level"].Visible = false;
            listadoDataGridView.Columns["percentage_price"].Visible = false;
            listadoDataGridView.Columns["percentage_price2"].Visible = false;
            listadoDataGridView.Columns["price2"].Visible = false;
            listadoDataGridView.Columns["percentage_price3"].Visible = false;
            listadoDataGridView.Columns["price3"].Visible = false;
            listadoDataGridView.Columns["status"].Visible = false;
            listadoDataGridView.Columns["created_at"].Visible = false;
            listadoDataGridView.Columns["modified_at"].Visible = false;
            listadoDataGridView.Columns["revision"].Visible = false;
            listadoDataGridView.Columns["categoryId"].Visible = false;
            listadoDataGridView.Columns["manufacturerId"].Visible = false;
            listadoDataGridView.Columns["iceRateId"].Visible = false;
            listadoDataGridView.Columns["ivaRateId"].Visible = false;
            listadoDataGridView.Columns["typeProductId"].Visible = false;
            listadoDataGridView.Columns["unitMeasurementId"].Visible = false;
        }

        private void Catalogo_Load(object sender, EventArgs e)
        {
            FocoEnTextBoxDeBusqueda();
            CrearBotonAccionesDatagridview("Editar", "editButton", Properties.Resources.edit_18px);
            CrearBotonAccionesDatagridview("Eliminar", "deleteButton", Properties.Resources.delete_bin_18px);
        }

        public void FocoEnTextBoxDeBusqueda()
        {
            busquedaTextBox.Focus();
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

        private void FabricanteButton_Click(object sender, EventArgs e)
        {
            FabricanteForm.Show();
            FabricanteForm.BringToFront();
            FabricanteForm.busquedaTextBox.Focus();
            FabricanteForm.DatosIniciales();
        }

        private void CategoriaButton_Click(object sender, EventArgs e)
        {
            CategoriaForm.Show();
            CategoriaForm.BringToFront();
            CategoriaForm.busquedaTextBox.Focus();
            CategoriaForm.DatosIniciales();
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            
            DatosGuardarActualizar
                (
                    "",
                    "Guardar",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    ""
                );
            
        }

        private void ListadoDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && listadoDataGridView.CurrentCell.OwningColumn.Name == "editButton")
            {
                DatosGuardarActualizar
                    (
                        listadoDataGridView.Rows[e.RowIndex].Cells["id"].Value.ToString(),
                        "Actualizar",
                        listadoDataGridView.Rows[e.RowIndex].Cells["main_code"].Value.ToString(),
                        listadoDataGridView.Rows[e.RowIndex].Cells["aux_code"].Value.ToString(),
                        listadoDataGridView.Rows[e.RowIndex].Cells["name"].Value.ToString(),
                        listadoDataGridView.Rows[e.RowIndex].Cells["detail"].Value.ToString(),
                        listadoDataGridView.Rows[e.RowIndex].Cells["stock"].Value.ToString(),
                        listadoDataGridView.Rows[e.RowIndex].Cells["minimum_stock_level"].Value.ToString(),
                        listadoDataGridView.Rows[e.RowIndex].Cells["cost"].Value.ToString(),
                        listadoDataGridView.Rows[e.RowIndex].Cells["percentage_price"].Value.ToString(),
                        listadoDataGridView.Rows[e.RowIndex].Cells["price"].Value.ToString(),
                        listadoDataGridView.Rows[e.RowIndex].Cells["percentage_price2"].Value.ToString(),
                        listadoDataGridView.Rows[e.RowIndex].Cells["price2"].Value.ToString(),
                        listadoDataGridView.Rows[e.RowIndex].Cells["percentage_price3"].Value.ToString(),
                        listadoDataGridView.Rows[e.RowIndex].Cells["price3"].Value.ToString(),
                        listadoDataGridView.Rows[e.RowIndex].Cells["categoryId"].Value.ToString(),
                        listadoDataGridView.Rows[e.RowIndex].Cells["manufacturerId"].Value.ToString(),
                        listadoDataGridView.Rows[e.RowIndex].Cells["iceRateId"].Value.ToString(),
                        listadoDataGridView.Rows[e.RowIndex].Cells["ivaRateId"].Value.ToString(),
                        listadoDataGridView.Rows[e.RowIndex].Cells["typeProductId"].Value.ToString(),
                        listadoDataGridView.Rows[e.RowIndex].Cells["unitMeasurementId"].Value.ToString()
                    );
            }

            if (e.RowIndex >= 0 && listadoDataGridView.CurrentCell.OwningColumn.Name == "deleteButton")
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar este item?", "Eliminar item", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (ConsultasSql.Eliminar(TableBdd, "id", $"'{listadoDataGridView.Rows[e.RowIndex].Cells["id"].Value}'"))
                    {
                        DatosIniciales();
                    }
                }
            }
        }

        private void DatosGuardarActualizar(string id, string accionBoton, string mainCodeCampo, string auxCodeCampo,
            string nameCampo, string detailCampo, string stockCampo, string minimumStockLevelCampo, string costCampo,
            string percentagePrice1Campo, string price1Campo, string percentagePrice2Campo, string price2Campo,
            string percentagePrice3Campo, string price3Campo, string categoryIdCampo, string manufacturerIdCampo,
            string iceRateIdCampo, string ivaRateIdCampo, string typeProductIdCampo, string unitMeasurementIdCampo)
        {
            NuevoItemForm.Icatalogo = this;
            NuevoItemForm.Show();
            NuevoItemForm.BringToFront();
            NuevoItemForm.IdField = id;
            NuevoItemForm.TableBdd = TableBdd;
            NuevoItemForm.ErrorProvider.Clear();
            NuevoItemForm.DatosIniciales();
            NuevoItemForm.aceptarButton.Text = accionBoton;

            NuevoItemForm.nameTextBox.Text = nameCampo;
            NuevoItemForm.nameTextBox.Focus();
            NuevoItemForm.nameTextBox.SelectAll();
            NuevoItemForm.mainCodeTextBox.Text = mainCodeCampo;
            NuevoItemForm.auxCodeTextBox.Text = auxCodeCampo;
            NuevoItemForm.descripcionTextBox.Text = detailCampo;
            NuevoItemForm.stockTextBox.Text = stockCampo;
            NuevoItemForm.minimumStockLevelTextBox.Text = minimumStockLevelCampo;
            NuevoItemForm.costTextBox.Text = costCampo;
            NuevoItemForm.percentagePrice1TextBox.Text = percentagePrice1Campo;
            NuevoItemForm.price1TextBox.Text = price1Campo;
            NuevoItemForm.percentagePrice2TextBox.Text = percentagePrice2Campo;
            NuevoItemForm.price2TextBox.Text = price2Campo;
            NuevoItemForm.percentagePrice3TextBox.Text = percentagePrice3Campo;
            NuevoItemForm.price3TextBox.Text = price3Campo;
            NuevoItemForm.categoryComboBox.SelectedValue = (categoryIdCampo == "") ? "nulo" : categoryIdCampo;
            NuevoItemForm.manufacturerComboBox.SelectedValue = (manufacturerIdCampo == "") ? "nulo" : manufacturerIdCampo;
            NuevoItemForm.iceRateComboBox.SelectedValue = (iceRateIdCampo == "") ? "nulo" : iceRateIdCampo;
            NuevoItemForm.unitMeasurementComboBox.SelectedValue = (unitMeasurementIdCampo == "") ? "nulo" : unitMeasurementIdCampo;
            
            if (accionBoton == "Actualizar")
            {
                NuevoItemForm.typeProductComboBox.SelectedValue = typeProductIdCampo;
                NuevoItemForm.ivaRateComboBox.SelectedValue = ivaRateIdCampo;
                NuevoItemForm.stockTextBox.ReadOnly = true;
            }
            else if (accionBoton == "Guardar")
            {
                NuevoItemForm.typeProductComboBox.SelectedIndex = 0;
                NuevoItemForm.ivaRateComboBox.SelectedIndex = 0;
                NuevoItemForm.stockTextBox.ReadOnly = false;
            }
        }

        private void BusquedaTextBox_TextChanged(object sender, EventArgs e)
        {
            Busqueda();
        }

        public void Busqueda()
        {
            string busqueda = busquedaTextBox.Text.Replace("'", "\\'").Trim();
            listadoDataGridView.DataSource = ConsultasSql.Busqueda(TableBdd, "name", $"{ busqueda }");
            listadoDataGridView.Sort(listadoDataGridView.Columns["name"], ListSortDirection.Ascending);
        }
    }
}
