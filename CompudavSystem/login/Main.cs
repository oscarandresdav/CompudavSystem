using System;
using System.Windows.Forms;
using CompudavSystem.catalogo;
using CompudavSystem.documento;
using CompudavSystem.usuario;

namespace CompudavSystem.login
{
    public partial class Main : Form
    {
        private Catalogo FormCatalogo { get; set; } = new Catalogo();
        private Contacto FormContacto { get; set; } = new Contacto();
        private Venta FormVenta { get; set; } = new Venta();

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
            else
            {
                Application.ExitThread();
            }

        }

        private void ButtonCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonCatalogo_Click(object sender, EventArgs e)
        {
            MostrarFormulario(FormCatalogo, FormCatalogo.busquedaTextBox);
        }

        private void MostrarFormulario(Form formulario, TextBox textBoxFocus)
        {
            if (panelContainer.Controls.Count > 0)
            {
                panelContainer.Controls.RemoveAt(0);
            }
            formulario.TopLevel = false;
            panelContainer.Controls.Add(formulario);
            panelContainer.Tag = formulario;
            formulario.Show();
            textBoxFocus.Focus();
            
        }

        private void ButtonUsuarios_Click(object sender, EventArgs e)
        {
            MostrarFormulario(FormContacto, FormContacto.busquedaTextBox);
        }

        private void ButtonVentas_Click(object sender, EventArgs e)
        {
            MostrarFormulario(FormVenta, FormVenta.idNumberTextBox);
        }
    }
}
