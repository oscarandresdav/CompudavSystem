using System;
using System.Windows.Forms;
using CompudavSystem.catalogo;
using CompudavSystem.configuracion;
using CompudavSystem.documento;
using CompudavSystem.usuario;
using CompudavSystem.utilitario;

namespace CompudavSystem.login
{
    public partial class Main : Form
    {
        private Catalogo FormCatalogo { get; set; } = new Catalogo();
        private Contacto FormContacto { get; set; } = new Contacto();
        private Venta FormVenta { get; set; } = new Venta();
        private Configuracion FormConfiguracion { get; set; } = new Configuracion();

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
            FormularioPanel.MostrarFormulario(FormCatalogo, FormCatalogo.busquedaTextBox);
        }

        private void ButtonUsuarios_Click(object sender, EventArgs e)
        {
            FormularioPanel.MostrarFormulario(FormContacto, FormContacto.busquedaTextBox);
        }

        private void ButtonVentas_Click(object sender, EventArgs e)
        {
            FormularioPanel.MostrarFormulario(FormVenta, FormVenta.idNumberTextBox);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            FormularioPanel.PanelContenedor = panelContainer;
        }

        private void buttonConfiguracion_Click(object sender, EventArgs e)
        {
            FormularioPanel.MostrarFormulario(FormConfiguracion);
        }
    }
}
