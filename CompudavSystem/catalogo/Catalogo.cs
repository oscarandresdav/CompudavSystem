using CompudavSystem.bdd;
using CompudavSystem.login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompudavSystem.catalogo
{
    public partial class Catalogo : Form
    {
        private Fabricante FabricanteForm { get; set; } = new Fabricante();
        public Catalogo()
        {
            InitializeComponent();
            DatosInicialesDatagrid();
        }

        private void DatosInicialesDatagrid() 
        {
            listadoDataGridView.DataSource = ConsultasSql.ConsultaGeneral("user");
        }

        private void Catalogo_Load(object sender, EventArgs e)
        {
            busquedaTextBox.Focus();
        }

        private void FabricanteButton_Click(object sender, EventArgs e)
        {
            FabricanteForm.Show();
            FabricanteForm.BringToFront();
            FabricanteForm.busquedaTextBox.Focus();
            FabricanteForm.DatosInicialesDatagrid();
        }

    }
}
