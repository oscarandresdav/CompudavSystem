using CompudavSystem.bdd;
using CompudavSystem.utilitario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Xsl;

namespace CompudavSystem.documento
{
    public partial class Venta : Form
    {
        public DataGridView ContactoDataGridView { get; set; } = new DataGridView();
        private DataTable DataTableContacto { get; set; } = new DataTable();
        private string IdContact { get; set; }
        private string BusinessNameContact { get; set; }
        private string IdNumberContact { get; set; }
        private string AddressContact { get; set; }
        private string LandlineContact { get; set; }
        private bool ErrorStatus { get; set; }
        private ErrorProvider ErrorProvider { get; set; } = new ErrorProvider();
        public Venta()
        {
            InitializeComponent();
            //CargaContacto();
            ContactoDataGridView.KeyDown += new KeyEventHandler(ContactoDataGridView_KeyDown);
            ContactoDataGridView.KeyUp += new KeyEventHandler(ContactoDataGridView_KeyUp);
            ContactoDataGridView.CellContentDoubleClick += new DataGridViewCellEventHandler(ContactoDataGridView_CellContentDoubleClick);
        }

        private void CargaContacto(string campoCondicion, TextBox textBox)
        {
            string campoValor = textBox.Text.Replace("'", "\\'").Trim();
            DataTableContacto = ConsultasSql.Busqueda("contact", campoCondicion, campoValor, "id, id_number, business_name, address, landline");
            if (campoValor.Length > 0 && DataTableContacto.Rows.Count > 0)
            {
                ContactoDataGridView.DataSource = DataTableContacto;
                ContactoDataGridView.Size = new Size(350,120);
                ContactoDataGridView.Location = new Point(textBox.Location.X + 10, textBox.Location.Y + 26);
                ContactoDataGridView.ColumnHeadersVisible = false;
                ContactoDataGridView.RowHeadersVisible = false;
                ContactoDataGridView.AllowUserToAddRows = false;
                ContactoDataGridView.AllowUserToDeleteRows = false;
                ContactoDataGridView.BackgroundColor = Color.White;
                ContactoDataGridView.AllowUserToResizeColumns = false;
                ContactoDataGridView.AllowUserToResizeRows = false;
                ContactoDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                ContactoDataGridView.ReadOnly = true;

                Controls.Add(ContactoDataGridView);
                ContactoDataGridView.BringToFront();

                ContactoDataGridView.Columns["id_number"].Width = 90;
                ContactoDataGridView.Columns["business_name"].Width = 256;
                ContactoDataGridView.Columns["id"].Visible = false;
                ContactoDataGridView.Columns["address"].Visible = false;
                ContactoDataGridView.Columns["landline"].Visible = false;
                
                ContactoDataGridView.Visible = true;
            }
            else
            {
                ContactoDataGridView.Visible = false;
            }

        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            CargaContacto("business_name", nameTextBox);
        }

        private void NameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            EventoKeyDownContactoIdOrName(e, nameTextBox);
            if (e.KeyCode == Keys.F2) { ReadOnlyCamposContacto(false); }
            if (e.KeyCode == Keys.Enter) { addressTextBox.Focus(); }
        }

        private void EventoKeyDownContactoIdOrName(KeyEventArgs e, TextBox textBox)
        {
            if (e.KeyCode == Keys.Down)
            {
                if (ContactoDataGridView.Rows.Count > 0)
                {
                    ContactoDataGridView.Focus();
                }
            }
            if (e.KeyCode == Keys.Escape)
            {
                if (ContactoDataGridView.Rows.Count > 0)
                {
                    ContactoDataGridView.Visible = false;
                }
                textBox.Focus();
            }
        }

        private void ContactoDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                if (ContactoDataGridView.CurrentCell.RowIndex == 0)
                {
                    nameTextBox.Focus();
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                AsignarCeldasDataGridViewAVariables();
                AsignarVariablesACamposDelFormulario();
                ReadOnlyCamposContacto(true);
                ContactoDataGridView.Visible = false;
                dateIssueDateTimePicker.Focus();
                ValidarCampoRequerido(idNumberTextBox, "Por favor ingrese el numero de Identificación");
                ValidarCampoRequerido(nameTextBox, "Por favor ingrese el Nombre");
                ValidarCampoRequerido(addressTextBox, "Por favor ingrese la Dirección");
            }
            if (e.KeyCode == Keys.Escape)
            {
                ContactoDataGridView.Visible = false;
                nameTextBox.Focus();
            }
        }

        private void ContactoDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AsignarCeldasDataGridViewAVariables();
            AsignarVariablesACamposDelFormulario();
            ReadOnlyCamposContacto(true);
            ContactoDataGridView.Visible = false;
            dateIssueDateTimePicker.Focus();
        }

        private void AsignarCeldasDataGridViewAVariables()
        {
            IdContact = ContactoDataGridView.CurrentRow.Cells["id"].Value.ToString();
            IdNumberContact = ContactoDataGridView.CurrentRow.Cells["id_number"].Value.ToString();
            BusinessNameContact = ContactoDataGridView.CurrentRow.Cells["business_name"].Value.ToString();
            AddressContact = ContactoDataGridView.CurrentRow.Cells["address"].Value.ToString();
            LandlineContact = ContactoDataGridView.CurrentRow.Cells["landline"].Value.ToString();
        }

        private void ReadOnlyCamposContacto(bool accion)
        {
            idNumberTextBox.ReadOnly = accion;
            nameTextBox.ReadOnly = accion;
            addressTextBox.ReadOnly = accion;
            landlineTextBox.ReadOnly = accion;
        }

        private void AsignarVariablesACamposDelFormulario()
        {
            idNumberTextBox.Text = IdNumberContact;
            nameTextBox.Text = BusinessNameContact;
            addressTextBox.Text = AddressContact;
            landlineTextBox.Text = LandlineContact;
        }

        private void ContactClearFields() 
        {
            IdContact = "";
            IdNumberContact = "";
            BusinessNameContact = "";
            AddressContact = "";
            LandlineContact = "";
            idNumberTextBox.Clear();
            nameTextBox.Clear();
            addressTextBox.Clear();
            landlineTextBox.Clear();
            idNumberTextBox.Focus();
            ErrorProvider.Clear();
        }

        private void ContactoDataGridView_KeyUp(object sender, KeyEventArgs e)
        {
            

        }

        private void ListadoDataGridView_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            ContactClearFields();
            ReadOnlyCamposContacto(false);
        }

        private void IdNumberTextBox_DoubleClick(object sender, EventArgs e)
        {
            ReadOnlyCamposContacto(false);
        }

        private void NameTextBox_DoubleClick(object sender, EventArgs e)
        {
            ReadOnlyCamposContacto(false);
        }

        private void AddressTextBox_DoubleClick(object sender, EventArgs e)
        {
            ReadOnlyCamposContacto(false);
        }

        private void LandlineTextBox_DoubleClick(object sender, EventArgs e)
        {
            ReadOnlyCamposContacto(false);
        }

        private void IdNumberTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            EventoKeyDownContactoIdOrName(e, nameTextBox);
            if (e.KeyCode == Keys.F2) { ReadOnlyCamposContacto(false); }
            if (e.KeyCode == Keys.Enter) { nameTextBox.Focus(); }
        }

        private void AddressTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2) { ReadOnlyCamposContacto(false); }
            if (e.KeyCode == Keys.Enter) { landlineTextBox.Focus(); }
        }

        private void LandlineTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2) { ReadOnlyCamposContacto(false); }
            if (e.KeyCode == Keys.Enter) { dateIssueDateTimePicker.Focus(); }
        }

        private void listadoDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void IdNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            CargaContacto("id_number", idNumberTextBox);
        }

        private void IdNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Validaciones.Numeros(e.KeyChar);
        }

        private void IdNumberTextBox_Validated(object sender, EventArgs e)
        {
            ValidaCampoIdentificacion(idNumberTextBox);
        }

        private bool ValidaCampoIdentificacion(TextBox textBox)
        {
            ErrorStatus = true;
            if (textBox.Text.Trim().Length > 0)
            {
                ErrorStatus = ValidaIDNumber.VerificaIdentificacion(textBox.Text);
            }
            if (ErrorStatus)
            {
                ErrorProvider.SetError(textBox, "");
            }
            else
            {
                ErrorProvider.SetError(textBox, "Verifica número de ID");
            }

            return ErrorStatus;
        }

        private void LandlineTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Validaciones.Telefonos(e.KeyChar);
        }

        private bool ValidarCampoRequerido(TextBox textBox, string mensaje)
        {
            ErrorStatus = true;
            if (textBox.Text == "")
            {
                ErrorProvider.SetError(textBox, mensaje);
                ErrorStatus = false;
            }
            else
                ErrorProvider.SetError(textBox, "");
            return ErrorStatus;
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            ValidarCampoRequerido(idNumberTextBox, "Por favor ingrese el numero de Identificación");
            ValidarCampoRequerido(nameTextBox, "Por favor ingrese el Nombre");
            ValidarCampoRequerido(addressTextBox, "Por favor ingrese la Dirección");
        }
    }
}
