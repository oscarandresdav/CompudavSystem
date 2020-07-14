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
    public partial class Fabricante : Form
    {
        public Fabricante()
        {
            InitializeComponent();
            DatosInicialesDatagrid();
        }
        public void DatosInicialesDatagrid()
        {
            listadoDataGridView.DataSource = ConsultasSql.ConsultaGeneral("manufacturer");
            listadoDataGridView.Sort(this.listadoDataGridView.Columns["name"], ListSortDirection.Ascending);
            
            listadoDataGridView.Columns["id"].Visible = false;
            listadoDataGridView.Columns["revision"].Visible = false;
            listadoDataGridView.Columns["status"].Visible = false;

            listadoDataGridView.Columns["name"].HeaderText = "MARCA";
            listadoDataGridView.Columns["name"].Width = 200;

            listadoDataGridView.Columns["created_at"].HeaderText = "FECHA DE CREACION";
            listadoDataGridView.Columns["created_at"].Width = 150;
            listadoDataGridView.Columns["modified_at"].HeaderText = "FECHA DE MODIFICACION";
            listadoDataGridView.Columns["modified_at"].Width = 165;




        }

        private void ButtonCerrar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void BusquedaTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { Hide(); }
        }
    }
}
