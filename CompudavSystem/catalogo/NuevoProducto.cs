using CompudavSystem.bdd;
using System;
using System.Windows.Forms;

namespace CompudavSystem.catalogo
{
    public partial class NuevoProducto : Form
    {
        public ICatalogo Icatalogo { get; set; } 
        public string TableBdd { get; set; }
        public string IdField { get; set; }

        public NuevoProducto()
        {
            InitializeComponent();
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void Guardar()
        {
            string name = descripcionTextBox.Text.Replace("'", "\\'").Trim();
            if (name.Length > 0)
            {
                if (aceptarButton.Text == "Actualizar")
                {
                    if (ConsultasSql.Actualizar(TableBdd, $"name = '{name}'","id", $"'{IdField}'"))
                    {
                        CerrarYRefrescarFormulario();
                    }
                }

                if (aceptarButton.Text == "Guardar")
                {
                    if (ConsultasSql.Insertar(TableBdd, "name", $"'{ name }'"))
                    {
                        CerrarYRefrescarFormulario();
                    }
                }
            }
            else
            {
                MessageBox.Show("Campo descripcion en blanco");
            }
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            CerrarYRefrescarFormulario();
        }

        private void DescripcionTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { CerrarYRefrescarFormulario(); }
            if (e.KeyCode == Keys.Enter) { Guardar(); }
        }

        private void CerrarYRefrescarFormulario()
        {
            Hide();
            Icatalogo.FocoEnTextBoxDeBusqueda();
            Icatalogo.Busqueda();
        }
    }
}
