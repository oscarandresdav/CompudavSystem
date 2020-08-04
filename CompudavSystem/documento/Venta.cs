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
            ProductoDataGridView.CellContentDoubleClick += new DataGridViewCellEventHandler(ProductoDataGridView_CellContentDoubleClick);
            BusquedaProductoTextBox.TextChanged += new EventHandler(BusquedaProductoTextBox_TextChanged);
            BusquedaProductoTextBox.KeyDown += new KeyEventHandler(BusquedaProductoTextBox_KeyDown);

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
            if (e.KeyCode == Keys.Enter) 
            {
                if (DataTableContacto.Rows.Count > 0)
                {
                    AsignarCeldasDataGridViewAVariables();
                    AsignarVariablesACamposDelFormulario();
                    ReadOnlyCamposContacto(true);
                    ContactoDataGridView.Visible = false;
                    listadoDataGridView.Focus();
                }
                else
                {
                    addressTextBox.Focus();
                }
            }
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
                listadoDataGridView.Focus();
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
            listadoDataGridView.Focus();
        }

        private void AsignarCeldasDataGridViewAVariables()
        {
            ContactoDataGridView.Focus();
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
            listadoDataGridView.Rows.Clear();
            
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
            if (e.KeyCode == Keys.Enter) 
            {
                if (DataTableContacto.Rows.Count > 0)
                {
                    AsignarCeldasDataGridViewAVariables();
                    AsignarVariablesACamposDelFormulario();
                    ReadOnlyCamposContacto(true);
                    ContactoDataGridView.Visible = false;
                    listadoDataGridView.Focus();
                }
                else
                {
                    nameTextBox.Focus();
                }
            }
        }

        private void AddressTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2) { ReadOnlyCamposContacto(false); }
            if (e.KeyCode == Keys.Enter) { landlineTextBox.Focus(); }
        }

        private void LandlineTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2) { ReadOnlyCamposContacto(false); }
            if (e.KeyCode == Keys.Enter) { listadoDataGridView.Focus(); }
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


        private void CargaProducto(DataGridView dataGridView)
        {
            ProductoPanel.Size = new Size(400, 160);
            ProductoPanel.Location = new Point(
                dataGridView.GetCellDisplayRectangle(0, dataGridView.CurrentRow.Index, false).Location.X + 2,
                dataGridView.GetCellDisplayRectangle(0, dataGridView.CurrentRow.Index, false).Location.Y +
                dataGridView.GetCellDisplayRectangle(0, dataGridView.CurrentRow.Index, false).Size.Height + 2);
            ProductoPanel.BackColor = Color.WhiteSmoke;

            BusquedaProductoTextBox.Location = new Point(5, 5);
            BusquedaProductoTextBox.Width = 390;
            BusquedaProductoTextBox.CharacterCasing = CharacterCasing.Upper;

            ProductoDataGridView.Size = new Size(390, 120);
            ProductoDataGridView.Location = new Point(5, 30);
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
            FiltrarProducto();

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

        private void FiltrarProducto()
        {
            string campoValor = BusquedaProductoTextBox.Text.Replace("'", "\\'").Trim();
            DataTableProducto = ConsultasSql.Busqueda("product", "name", "main_code", campoValor, "id, main_code, name, stock, price, price2, price3");
            ProductoDataGridView.DataSource = DataTableProducto;

            ProductoDataGridView.Columns["main_code"].Width = 100;
            ProductoDataGridView.Columns["name"].Width = 275;
            ProductoDataGridView.Columns["id"].Visible = false;
            ProductoDataGridView.Columns["stock"].Visible = false;
            ProductoDataGridView.Columns["price"].Visible = false;
            ProductoDataGridView.Columns["price2"].Visible = false;
            ProductoDataGridView.Columns["price3"].Visible = false;
        }

        private void BusquedaProductoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { listadoDataGridView.Focus(); ProductoPanel.Visible = false; }
            if (e.KeyCode == Keys.Enter)
            {
                if (DataTableProducto.Rows.Count > 0)
                {
                    AgregarItemAListadoDatagridView();
                }
            }
        }

        private void BusquedaProductoTextBox_TextChanged(object sender, EventArgs e)
        {
            FiltrarProducto();
        }

        private void ListadoDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CargaProducto(listadoDataGridView);
        }

        private void ListadoDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Add && listadoDataGridView.CurrentRow.Cells[1].Selected)
            {
                CargaProducto(listadoDataGridView);
            }
        }


        private void ProductoDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AgregarItemAListadoDatagridView();
        }

        private void AgregarItemAListadoDatagridView()
        {
            ProductoDataGridView.Focus();
            listadoDataGridView.CurrentRow.Cells["idColumn"].Value = ProductoDataGridView.CurrentRow.Cells["id"].Value.ToString();
            listadoDataGridView.CurrentRow.Cells["mainCodeColumn"].Value = ProductoDataGridView.CurrentRow.Cells["main_code"].Value.ToString();
            listadoDataGridView.CurrentRow.Cells["nameColumn"].Value = ProductoDataGridView.CurrentRow.Cells["name"].Value.ToString();
            listadoDataGridView.CurrentRow.Cells["stockColumn"].Value = ProductoDataGridView.CurrentRow.Cells["stock"].Value.ToString();

            DataGridViewComboBoxCell comboCell = (DataGridViewComboBoxCell)listadoDataGridView[3, listadoDataGridView.CurrentRow.Index];
            comboCell.Items.Clear();
            comboCell.Items.Add(ProductoDataGridView.CurrentRow.Cells["price"].Value.ToString());
            comboCell.Value = ProductoDataGridView.CurrentRow.Cells["price"].Value.ToString();
            if (ProductoDataGridView.CurrentRow.Cells["price2"].Value.ToString() != "")
            {
                comboCell.Items.Add(ProductoDataGridView.CurrentRow.Cells["price2"].Value.ToString());
            }
            if (ProductoDataGridView.CurrentRow.Cells["price3"].Value.ToString() != "")
            {
                comboCell.Items.Add(ProductoDataGridView.CurrentRow.Cells["price3"].Value.ToString());
            }

            ProductoPanel.Visible = false;
            listadoDataGridView.CurrentCell = listadoDataGridView.CurrentRow.Cells["cantidadColumn"];
            listadoDataGridView.Focus();
        }

        private void ListadoDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (listadoDataGridView.CurrentRow.Cells["cantidadColumn"].Value != null && listadoDataGridView.CurrentRow.Cells["stockColumn"].Value != null)
            {
                if (int.TryParse(listadoDataGridView.CurrentRow.Cells["cantidadColumn"].Value.ToString().Trim(), out int cantidad) && int.TryParse(listadoDataGridView.CurrentRow.Cells["stockColumn"].Value.ToString(), out int stock))
                {
                    if (cantidad > stock)
                    {
                        MessageBox.Show($"Cantidad elegida supera el valor total disponible. \n\n\t**Disponible:  {listadoDataGridView.CurrentRow.Cells["stockColumn"].Value}");
                        listadoDataGridView.CurrentRow.Cells["cantidadColumn"].Value = listadoDataGridView.CurrentRow.Cells["stockColumn"].Value;

                    }
                    decimal cantidadDecimal = Convert.ToDecimal(listadoDataGridView.CurrentRow.Cells["cantidadColumn"].Value);
                    decimal precioDecimal = Convert.ToDecimal(listadoDataGridView.CurrentRow.Cells["precioColumn"].Value);
                    MessageBox.Show((cantidadDecimal * precioDecimal).ToString());
                    listadoDataGridView.CurrentRow.Cells["subtotalColumn"].Value = cantidadDecimal * precioDecimal;
                }

            }
        }
    }
}
