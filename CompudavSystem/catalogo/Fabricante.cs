using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CompudavSystem.bdd;

namespace CompudavSystem.catalogo
{
    public partial class Fabricante : Form, IComunicacionCatalogo
    {
        private NuevoFabricante NuevoForm { get; set; } = new NuevoFabricante();

        public Fabricante()
        {
            InitializeComponent();
            DatosInicialesDatagrid();
        }
        public void DatosInicialesDatagrid()
        {
            listadoDataGridView.DataSource = ConsultasSql.ConsultaGeneral("manufacturer");
            listadoDataGridView.Sort(listadoDataGridView.Columns["name"], ListSortDirection.Ascending);
            
            listadoDataGridView.Columns["id"].Visible = false;
            listadoDataGridView.Columns["revision"].Visible = false;
            listadoDataGridView.Columns["status"].Visible = false;
            listadoDataGridView.Columns["created_at"].Visible = false;
            listadoDataGridView.Columns["modified_at"].Visible = false;

            listadoDataGridView.Columns["name"].HeaderText = "Descripción";
            listadoDataGridView.Columns["name"].Width = 230;

        }

        private void ButtonCerrar_Click(object sender, EventArgs e)
        {
            Hide();
            NuevoForm.Hide();
        }

        private void BusquedaTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { Hide(); NuevoForm.Hide(); }
        }

        private void Fabricante_Load(object sender, EventArgs e)
        {
            CrearBotonDatagridview("Editar", "editButton", Properties.Resources.edit_18px);
            CrearBotonDatagridview("Eliminar", "deleteButton", Properties.Resources.delete_bin_18px);
        }

        private void CrearBotonDatagridview(string headerText, string name, Bitmap pathImage)
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
            NuevoForm.comunicacionCatalogo = this;
            NuevoForm.Show();
            NuevoForm.BringToFront();
        }

    }
}
