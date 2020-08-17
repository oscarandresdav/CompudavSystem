using System;
using System.Windows.Forms;
using CompudavSystem.catalogo;
using CompudavSystem.configuracion;
using CompudavSystem.documento;
using CompudavSystem.historico;
using CompudavSystem.usuario;
using CompudavSystem.utilitario;

namespace CompudavSystem.login
{
    public partial class Main : Form
    {
        private Catalogo FormCatalogo { get; set; } = new Catalogo();
        private Contacto FormContacto { get; set; } = new Contacto();
        private Venta FormVenta { get; set; } = new Venta();
        private Compra FormCompra { get; set; } = new Compra();
        private Historial FormHistorial { get; set; } = new Historial();
        private PanelDashboard FormPanel { get; set; } = new PanelDashboard(); 
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
            FormCatalogo.Busqueda();
        }

        private void ButtonUsuarios_Click(object sender, EventArgs e)
        {
            FormularioPanel.MostrarFormulario(FormContacto, FormContacto.busquedaTextBox);
            FormContacto.Busqueda();
        }

        private void ButtonVentas_Click(object sender, EventArgs e)
        {
            FormularioPanel.MostrarFormulario(FormVenta, FormVenta.idNumberTextBox);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            FormularioPanel.PanelContenedor = panelContainer;
            FormularioPanel.MostrarFormulario(FormPanel);
        }

        private void ButtonConfiguracion_Click(object sender, EventArgs e)
        {
            FormularioPanel.MostrarFormulario(FormConfiguracion);
            FormConfiguracion.CargarDatos();
            FormConfiguracion.LoadPreset();
        }

        private void ButtonCompras_Click(object sender, EventArgs e)
        {
            FormularioPanel.MostrarFormulario(FormCompra, FormCompra.idNumberTextBox);
        }

        private void ButtonHistorial_Click(object sender, EventArgs e)
        {
            FormularioPanel.MostrarFormulario(FormHistorial, FormHistorial.busquedaTextBox);
            FormHistorial.Busqueda();
        }

        private void PanelButton_Click(object sender, EventArgs e)
        {
            FormularioPanel.MostrarFormulario(FormPanel);
            FormPanel.DatosIniciales();
        }
    }
}
