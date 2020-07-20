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
            DatosInicialesComboBoxs();
        }

        public void DatosInicialesComboBoxs()
        {
            CargaDeDatosCombobox(categoryComboBox, "category");
            CargaDeDatosCombobox(manufacturerComboBox, "manufacturer");
            CargaDeDatosCombobox(typeProductComboBox, "type_product");
            CargaDeDatosCombobox(unitMeasurementComboBox, "unit_measurement");

            
        }

        private void CargaDeDatosCombobox(ComboBox comboBox, string table, string displayMember = "name", string valueMember = "id")
        {
            comboBox.DataSource = ConsultasSql.ConsultaGeneral(table);
            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;
            comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void Guardar()
        {
            string name = nameTextBox.Text.Replace("'", "\\'").Trim();
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
