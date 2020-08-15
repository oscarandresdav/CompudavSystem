using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using CompudavSystem.login;

namespace CompudavSystem
{
    public partial class Inicio : Form
    {
        private Login LoginForm { get; set; } = new Login();
        public string Acceso { get; set; } = "False";
        public Inicio()
        {
            InitializeComponent();
            DecimalesSettings();
            timer.Interval = 3000;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            LoginForm.Show();
            Hide();
        }

        private void DecimalesSettings()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("es-EC");
            Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = ".";
            Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = ",";
            Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = ".";
            Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = ",";
        }
    }
}
