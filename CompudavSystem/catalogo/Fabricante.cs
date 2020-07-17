using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using CompudavSystem.bdd;

namespace CompudavSystem.catalogo
{
    public partial class Fabricante : Form, ICatalogo
    {
        private NuevoFabricante NuevoForm { get; set; } = new NuevoFabricante();
        private string TableBdd { get; set; } = "manufacturer";

        public Fabricante()
        {
            InitializeComponent();
            DatosInicialesDatagrid();
        }
        public void DatosInicialesDatagrid()
        {
            listadoDataGridView.DataSource = ConsultasSql.ConsultaGeneral(TableBdd);
            listadoDataGridView.Sort(listadoDataGridView.Columns["name"], ListSortDirection.Ascending);
            listadoDataGridView.Columns["name"].HeaderText = "Descripción";
            listadoDataGridView.Columns["name"].Width = 242;
            
            listadoDataGridView.Columns["id"].Visible = false;
            listadoDataGridView.Columns["revision"].Visible = false;
            listadoDataGridView.Columns["status"].Visible = false;
            listadoDataGridView.Columns["created_at"].Visible = false;
            listadoDataGridView.Columns["modified_at"].Visible = false;
        }

        public void FocoEnTextBoxDeBusqueda()
        {
            busquedaTextBox.Focus();
        }

        private void ButtonCerrar_Click(object sender, EventArgs e)
        {
            CerrarFormularios();
        }
        private void BusquedaTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { CerrarFormularios(); }
        }

        private void ListadoDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { CerrarFormularios(); }
        }

        private void CerrarFormularios()
        {
            Hide();
            NuevoForm.Hide();
        }

        private void Fabricante_Load(object sender, EventArgs e)
        {
            CrearBotonAccionesDatagridview("Editar", "editButton", Properties.Resources.edit_18px);
            CrearBotonAccionesDatagridview("Eliminar", "deleteButton", Properties.Resources.delete_bin_18px);
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
        
        private void AgregarButton_Click(object sender, EventArgs e)
        {
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

        private void DatosGuardarActualizar(string id, string accionBoton, string descripcionCampo)
        {
            NuevoForm.comunicacionCatalogo = this;
            NuevoForm.Show();
            NuevoForm.BringToFront();
            NuevoForm.IdField = id;
            NuevoForm.aceptarButton.Text = accionBoton;
            NuevoForm.descripcionTextBox.Text = descripcionCampo;
            NuevoForm.descripcionTextBox.Focus();
            NuevoForm.descripcionTextBox.SelectAll();
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
