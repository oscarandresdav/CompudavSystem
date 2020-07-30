using CompudavSystem.bdd;
using CompudavSystem.Properties;
using System;
using System.Data;
using System.Windows.Forms;

namespace CompudavSystem.login
{
    public partial class Login : Form
    {
        public string Acceso { get; set; } = "False";
        private Main MainForm { get; set; } = new Main();
        private bool ToggleConfiguracion { get; set; } = false;
        public DataTable DataTableUser { get; set; } = new DataTable();
        private int Intentos { get; set; } = 0;
        public Login()
        {
            InitializeComponent();
            textBoxUsuario.Text = Settings.Default.username;
            textBoxServidor.Text = Settings.Default.servidor;
        }
        private void ToggleButtonConfiguracion()
        {
            ToggleConfiguracion = !ToggleConfiguracion;
            textBoxServidor.Visible = ToggleConfiguracion;
            if (ToggleConfiguracion) { textBoxServidor.Focus(); }
        }

        private void ButtonIniciar_Click(object sender, EventArgs e)
        {
            InicioSesion();
        }

        private void InicioSesion()
        {
            Acceso = Conexion.InicializarInstanciaMySQL(Conexion.User, Conexion.Password, Settings.Default.servidor, Conexion.Database);
            if (Acceso == "True")
            {
                DataTableUser = ConsultasSql.ConsultaIndividual("user", "*", "username", "=", $"{ textBoxUsuario.Text }", "password", "=", $"{ textBoxClave.Text }");
                if (DataTableUser.Rows.Count >= 1)
                {
                    Settings.Default.username = textBoxUsuario.Text;
                    Settings.Default.Save();
                    Settings.Default.Reload();
                    MainForm.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña erroneos", "CompudavSystem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Intentos += 1;

                    if (Intentos >= 3)
                    {
                        textBoxClave.Text = "";
                        textBoxUsuario.Text = "";
                        textBoxUsuario.Focus();
                    }
                    else
                    {
                        textBoxClave.Text = "";
                        textBoxClave.Focus();
                    }
                }
            }
        }

        private void ButtonCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
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

        private void ButtonConfiguracion_Click(object sender, EventArgs e)
        {
            ToggleButtonConfiguracion();
        }

        private void TxtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F8) { ToggleButtonConfiguracion(); }
            if (e.KeyCode == Keys.Enter) { InicioSesion(); }
        }

        private void TextBoxServidor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.F8) { ToggleButtonConfiguracion(); }
            if (e.KeyCode == Keys.Enter)
            {
                Settings.Default.servidor = textBoxServidor.Text;
                Settings.Default.Save();
                Settings.Default.Reload();
                ToggleButtonConfiguracion();
            }
        }

        private void TxtClave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F8) { ToggleButtonConfiguracion(); }
            if (e.KeyCode == Keys.Enter) { InicioSesion(); }
        }

        private void Login_Shown(object sender, EventArgs e)
        {
            if (textBoxUsuario.TextLength >= 1) { textBoxClave.Focus(); }
        }
    }
}
