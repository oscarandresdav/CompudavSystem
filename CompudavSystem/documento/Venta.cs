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
        private DataGridView ContactoDataGridView { get; set; } = new DataGridView();
        private Panel ProductoPanel { get; set; } = new Panel();
        private TextBox BusquedaProductoTextBox { get; set; } = new TextBox();
        private DataGridView ProductoDataGridView { get; set; } = new DataGridView();
        private DataTable DataTableContacto { get; set; } = new DataTable();
        private DataTable DataTableProducto { get; set; } = new DataTable();
        private string IdContact { get; set; }
        private string BusinessNameContact { get; set; }
        private string IdNumberContact { get; set; }
        private string AddressContact { get; set; }
        private string LandlineContact { get; set; }
        private ValidaCampo ValidaCampo { get; set; } = new ValidaCampo();
        public Venta()
        {
            InitializeComponent();
            ContactoDataGridView.KeyDown += new KeyEventHandler(ContactoDataGridView_KeyDown);
            ContactoDataGridView.CellContentDoubleClick += new DataGridViewCellEventHandler(ContactoDataGridView_CellContentDoubleClick);
        }

        private void CargaContacto(string campoCondicion, TextBox textBox)
        {
            string campoValor = textBox.Text.Replace("'", "\\'").Trim();
            DataTableContacto = ConsultasSql.Busqueda("contact", campoCondicion, campoValor, "id, id_number, business_name, address, landline");
            if (campoValor.Length > 0 && DataTableContacto.Rows.Count > 0)
            {
                ContactoDataGridView.DataSource = DataTableContacto;
                ContactoDataGridView.Size = new Size(350, 120);
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
                ValidaCampo.Requerido(idNumberTextBox, "Por favor ingrese el numero de Identificación");
                ValidaCampo.Requerido(nameTextBox, "Por favor ingrese el Nombre");
                ValidaCampo.Requerido(addressTextBox, "Por favor ingrese la Dirección");
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
            dateIssueDateTimePicker.Value = DateTime.Today;
            ValidaCampo.ErrorProvider.Clear();
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
            ValidaCampo.Identificacion(idNumberTextBox);
        }

        

        private void LandlineTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Validaciones.Telefonos(e.KeyChar);
        }

        

        private void PrintButton_Click(object sender, EventArgs e)
        {
            ValidaCampo.Requerido(idNumberTextBox, "Por favor ingrese el numero de Identificación");
            ValidaCampo.Requerido(nameTextBox, "Por favor ingrese el Nombre");
            ValidaCampo.Requerido(addressTextBox, "Por favor ingrese la Dirección");
        }


        private void CargaProducto(DataGridView dataGridView, DataGridViewCellEventArgs e)
        {
            ProductoPanel.Size = new Size(400, 160);
            ProductoPanel.Location = new Point(
                dataGridView.GetCellDisplayRectangle(0, e.RowIndex, false).Location.X + 2,
                dataGridView.GetCellDisplayRectangle(0, e.RowIndex, false).Location.Y +
                dataGridView.GetCellDisplayRectangle(0, e.RowIndex, false).Size.Height + 2);
            ProductoPanel.BackColor = Color.WhiteSmoke;
            
            BusquedaProductoTextBox.Location = new Point(5, 5);
            BusquedaProductoTextBox.Width = 390;
            
            ProductoDataGridView.Size = new Size(390, 120);
            ProductoDataGridView.Location = new Point(5,30);
            ProductoDataGridView.ColumnHeadersVisible = false;
            ProductoDataGridView.RowHeadersVisible = false;
            ProductoDataGridView.AllowUserToAddRows = false;
            ProductoDataGridView.AllowUserToDeleteRows = false;
            ProductoDataGridView.BackgroundColor = Color.White;
            ProductoDataGridView.AllowUserToResizeColumns = false;
            ProductoDataGridView.AllowUserToResizeRows = false;
            ProductoDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProductoDataGridView.ReadOnly = true;

            mainPanel.Controls.Add(ProductoPanel);
            ProductoPanel.Controls.Add(BusquedaProductoTextBox);
            ProductoPanel.Controls.Add(ProductoDataGridView);
            ProductoPanel.BringToFront();

            if (dataGridView.CurrentRow.Cells[1].Selected || dataGridView.CurrentRow.Cells[0].Selected)
            {
                ProductoPanel.Visible = true;
                BusquedaProductoTextBox.Focus();
            }
            else
            {
                ProductoPanel.Visible = false;
            }

           

        }

        private void ListadoDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                var selectedCell = listadoDataGridView.SelectedCells[0];
                MessageBox.Show(selectedCell.ToString());
            }

            if (listadoDataGridView.CurrentCell.ColumnIndex == 0)
            {
                listadoDataGridView.CurrentRow.Cells[1].Value += "x";
            }
        }

        private void ListadoDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            CargaProducto(listadoDataGridView, e);
        }
    }
}
