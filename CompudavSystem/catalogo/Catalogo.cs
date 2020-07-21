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
            DatosInicialesDatagrid();
        }

        public void DatosInicialesDatagrid() 
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
            FabricanteForm.DatosInicialesDatagrid();
        }

        private void CategoriaButton_Click(object sender, EventArgs e)
        {
            CategoriaForm.Show();
            CategoriaForm.BringToFront();
            CategoriaForm.busquedaTextBox.Focus();
            CategoriaForm.DatosInicialesDatagrid();
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            NuevoItemForm.DatosInicialesComboBoxs();
            DatosGuardarActualizar
                (
                    "",
                    "Guardar",
                    ""
                );
        }

        private void ListadoDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (listadoDataGridView.CurrentCell.OwningColumn.Name == "editButton")
            {
                DatosGuardarActualizar
                    (
                        listadoDataGridView.Rows[e.RowIndex].Cells["id"].Value.ToString(),
                        "Actualizar",
                        listadoDataGridView.Rows[e.RowIndex].Cells["name"].Value.ToString()
                    );
            }

            if (listadoDataGridView.CurrentCell.OwningColumn.Name == "deleteButton")
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar este item?", "Eliminar item", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (ConsultasSql.Eliminar(TableBdd, "id", $"'{listadoDataGridView.Rows[e.RowIndex].Cells["id"].Value}'"))
                    {
                        DatosInicialesDatagrid();
                    }
                }

            }
        }

        private void DatosGuardarActualizar(string id, string accionBoton, string nameCampo)
        {
            NuevoItemForm.Icatalogo = this;
            NuevoItemForm.Show();
            NuevoItemForm.BringToFront();
            NuevoItemForm.IdField = id;
            NuevoItemForm.TableBdd = TableBdd;
            NuevoItemForm.aceptarButton.Text = accionBoton;
            NuevoItemForm.nameTextBox.Text = nameCampo;
            NuevoItemForm.nameTextBox.Focus();
            NuevoItemForm.nameTextBox.SelectAll();
        }

        private void BusquedaTextBox_TextChanged(object sender, EventArgs e)
        {
            Busqueda();
        }

        public void Busqueda()
        {
            listadoDataGridView.DataSource = ConsultasSql.Busqueda(TableBdd, "name", $"{ busquedaTextBox.Text }");
            listadoDataGridView.Sort(listadoDataGridView.Columns["name"], ListSortDirection.Ascending);
        }
    }
}
