using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CompudavSystem.catalogo;

namespace CompudavSystem.login
{
    public partial class Main : Form
    {
        private Catalogo FormCatalogo { get; set; } = new Catalogo();

        public Main()
        {
            InitializeComponent();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir del sistema?", "CompudavSystem", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
            else {
                Application.ExitThread();
            }

        }

        private void ButtonCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonCatalogo_Click(object sender, EventArgs e)
        {
            MostrarFormulario(FormCatalogo);
        }

        private void MostrarFormulario(Form formulario)
        {
            formulario.TopLevel = false;
            formulario.Parent = panelContainer;
            formulario.Show();
            formulario.BringToFront();
        }
    }
}
