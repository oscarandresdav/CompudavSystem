using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompudavSystem.login
{
    public partial class Login : Form
    {
        private Main MainForm { get; set; } = new Main();
        public Login()
        {
            InitializeComponent();
        }

        private void ButtonIniciar_Click(object sender, EventArgs e)
        {
            MainForm.Show();
            Hide();
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
    }
}
