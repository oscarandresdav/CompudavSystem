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
        public Main Main { get; set; } = new Main();
        public Login()
        {
            InitializeComponent();
        }

        private void ButtonIniciar_Click(object sender, EventArgs e)
        {
            Main.Show();
            Hide();
        }
    }
}
