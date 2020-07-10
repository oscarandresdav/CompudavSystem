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

namespace CompudavSystem
{
    public partial class Inicio : Form
    {
        private Login loginForm { get; set; } = new Login();
        public Inicio()
        {
            InitializeComponent();
            timer.Interval = 3000;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            loginForm.Show();
            Hide();
        }
    }
}
