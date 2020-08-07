using System.Windows.Forms;

namespace CompudavSystem.utilitario
{
    public class FormularioPanel
    {
        public static Panel PanelContenedor { get; set; }

        public static void MostrarFormulario(Form formulario)
        {
            int posicionX = ((PanelContenedor.Width - formulario.Width) / 2);
            int posicionY = ((PanelContenedor.Height - formulario.Height) / 2);
            formulario.TopLevel = false;
            PanelContenedor.Controls.Add(formulario);
            PanelContenedor.Tag = formulario;
            formulario.Left = posicionX;
            formulario.Top = posicionY;
            formulario.Show();
            formulario.BringToFront();
            formulario.StartPosition = FormStartPosition.CenterScreen;
        }
        public static void MostrarFormulario(Form formulario, TextBox textBoxFocus)
        {
            int posicionX = ((PanelContenedor.Width - formulario.Width) / 2);
            int posicionY = ((PanelContenedor.Height - formulario.Height) / 2);
            formulario.TopLevel = false;
            PanelContenedor.Controls.Add(formulario);
            PanelContenedor.Tag = formulario;
            formulario.Left = posicionX;
            formulario.Top = posicionY;
            formulario.Show();
            formulario.BringToFront();
            formulario.StartPosition = FormStartPosition.CenterScreen;
            textBoxFocus.Focus();

        }
    }
}
