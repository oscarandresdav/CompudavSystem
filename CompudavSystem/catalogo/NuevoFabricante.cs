using CompudavSystem.bdd;
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
    public partial class NuevoFabricante : Form
    {
        public IComunicacionCatalogo comunicacionCatalogo { get; set; } 
        private string TableBdd { get; set; } = "manufacturer";
        public NuevoFabricante()
        {
            InitializeComponent();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void DescripcionTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { Hide(); }
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            string name = descripcionTextBox.Text.Trim();
            if (name.Length > 0)
            {
                if (ConsultasSql.Insertar(TableBdd, "name", $"'{ name }'"))
                {
                    Hide();
                    comunicacionCatalogo.DatosInicialesDatagrid();
                }
            }
            else
            {
                MessageBox.Show("Campo descripcion en blanco");
            }
        }
    }
}
