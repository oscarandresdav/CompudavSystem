using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using CompudavSystem.bdd;
using CompudavSystem.utilitario;

namespace CompudavSystem.catalogo
{
    public partial class Fabricante : Form, ICatalogo
    {
        private NuevoItem NuevoItemForm { get; set; } = new NuevoItem();
        private string TableBdd { get; set; } = "manufacturer";

        public Fabricante()
        {
            InitializeComponent();
            DatosIniciales();
        }
        public void DatosIniciales()
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
            NuevoItemForm.Hide();
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
            if (e.RowIndex >= 0 && listadoDataGridView.CurrentCell.OwningColumn.Name == "editButton")
            {
                DatosGuardarActualizar
                    (
                        listadoDataGridView.Rows[e.RowIndex].Cells["id"].Value.ToString(),
                        "Actualizar",
                        listadoDataGridView.Rows[e.RowIndex].Cells["name"].Value.ToString()
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

        private void DatosGuardarActualizar(string id, string accionBoton, string descripcionCampo)
        {
            NuevoItemForm.Icatalogo = this;
            FormularioPanel.MostrarFormulario(NuevoItemForm, NuevoItemForm.descripcionTextBox);
            NuevoItemForm.IdField = id;
            NuevoItemForm.TableBdd = TableBdd;
            NuevoItemForm.aceptarButton.Text = accionBoton;
            NuevoItemForm.descripcionTextBox.Text = descripcionCampo;
            NuevoItemForm.descripcionTextBox.SelectAll();
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
