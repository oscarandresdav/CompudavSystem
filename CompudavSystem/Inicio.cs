using CompudavSystem.bdd;
using CompudavSystem.login;
using System;
using System.Windows.Forms;

namespace CompudavSystem
{
    public partial class Inicio : Form
    {
        private Login LoginForm { get; set; } = new Login();
        public string Acceso { get; set; } = "False";
        public Inicio()
        {
            InitializeComponent();
            timer.Interval = 3000;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            Acceso = Conexion.InicializarInstanciaMySQL(Conexion.User, Conexion.Password, Conexion.Server);
            if (Acceso == "True") 
            {
                LoginForm.Show();
                Hide();
            }
            else if (Acceso == "False")
            {
                Application.Exit();
            }
        }

    }
}
