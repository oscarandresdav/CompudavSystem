using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using CompudavSystem.bdd;
using CompudavSystem.Properties;
using CompudavSystem.utilitario;

namespace CompudavSystem.documento
{
    public partial class Venta : Form
    {
        #region PROPIEDADES
        private DataGridView ContactoDataGridView { get; set; } = new DataGridView();
        private Panel ProductoPanel { get; set; } = new Panel();
        private TextBox BusquedaProductoTextBox { get; set; } = new TextBox();
        private DataGridView ProductoDataGridView { get; set; } = new DataGridView();
        private DataTable DataTableContacto { get; set; } = new DataTable();
        private DataTable DataTableProducto { get; set; } = new DataTable();
        private ValidaCampo ValidaCampo { get; set; } = new ValidaCampo();
        private string IdContact { get; set; }
        private string BusinessNameContact { get; set; }
        private string IdNumberContact { get; set; }
        private string AddressContact { get; set; }
        private string LandlineContact { get; set; }
        private decimal Subtotal12Decimal { get; set; }
        private decimal Subtotal0Decimal { get; set; }
        private decimal SubtotalDescuentoDecimal { get; set; }
        private decimal DescuentoDecimal { get; set; }
        private string DescuentoSigno { get; set; }
        private decimal ValorDescuentoDecimal { get; set; }
        private decimal SubtotalDecimal { get; set; }
        private decimal IvaDecimal { get; set; }
        private decimal TotalDecimal { get; set; }

        #endregion

        public string PrinterName { get; set; } = Settings.Default.printerName;


        public Venta()
        {
            BusquedaProductoTextBox.KeyDown += new KeyEventHandler(BusquedaProductoTextBox_KeyDown);
            BusquedaProductoTextBox.TextChanged += new EventHandler(BusquedaProductoTextBox_TextChanged);
            ContactoDataGridView.CellContentDoubleClick += new DataGridViewCellEventHandler(ContactoDataGridView_CellContentDoubleClick);
            ContactoDataGridView.KeyDown += new KeyEventHandler(ContactoDataGridView_KeyDown);
            ProductoDataGridView.CellContentDoubleClick += new DataGridViewCellEventHandler(ProductoDataGridView_CellContentDoubleClick);
            ProductoDataGridView.KeyDown += new KeyEventHandler(ProductoDataGridView_KeyDown);
            
            InitializeComponent();
            ClearFields();
            InicializarValoresTotales();
        }

        #region DATOS

        #region METODOS

        private void CargaDeDatosCombobox(ComboBox comboBox, string table, string displayMember = "name", string valueMember = "id", string campoOrden = "sort")
        {
            comboBox.DataSource = ConsultasSql.ConsultaGeneral(table, campoOrden: campoOrden);
            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;
            comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }

        private void CargaContacto(string campoCondicion, TextBox textBox)
        {
            string campoValor = textBox.Text.Replace("'", "\\'").Trim();
            DataTableContacto = ConsultasSql.Busqueda(tabla: "contact", condicion: campoCondicion, valor: campoValor, campo: "id, id_number, business_name, address, landline", campoOrden: "business_name");
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
                ContactoDataGridView.Visible = true;

                ContactoDataGridView.Columns["id_number"].Width = 90;
                ContactoDataGridView.Columns["business_name"].Width = 256;
                ContactoDataGridView.Columns["id"].Visible = false;
                ContactoDataGridView.Columns["address"].Visible = false;
                ContactoDataGridView.Columns["landline"].Visible = false;
            }
            else
            {
                ContactoDataGridView.Visible = false;
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

        private void ClearFields()
        {
            CargaDeDatosCombobox(tipoPagoComboBox, "payment_method");
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
            additionalInformationTextBox.Clear();
            ValidaCampo.ErrorProvider.Clear();
            InicializarValoresTotales();
            ProductoPanel.Visible = false;
        }

        private void InicializarValoresTotales()
        {
            printerLabel.Text = PrinterName;
            FormatoDecimalF2(subtotal12TextBox, Subtotal12Decimal, true);
            FormatoDecimalF2(subtotal0TextBox, Subtotal0Decimal, true);
            FormatoDecimalF2(descuentoTextBox, DescuentoDecimal, true);
            FormatoDecimalF2(valorDescuentoTextBox, ValorDescuentoDecimal, true);
            FormatoDecimalF2(subtotalTextBox, SubtotalDecimal, true);
            FormatoDecimalF2(ivaTextBox, IvaDecimal, true);
            FormatoDecimalF2(totalTextBox, TotalDecimal, true);
            DescuentoSigno = "%";
            descuentoButton.Text = DescuentoSigno;
        }

        private void FormatoDecimalF2(TextBox text, decimal valor, bool valorCero)
        {
            if (valorCero) { valor = 0; }
            text.Text = string.Format("{0:F2}", valor);
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
                BusquedaProductoTextBox.SelectAll();
            }
            else
            {
                ProductoPanel.Visible = false;
            }
        }

        private void FiltrarProducto()
        {
            string campoValor = BusquedaProductoTextBox.Text.Replace("'", "\\'").Trim();
            DataTableProducto = ConsultasSql.Busqueda(tabla: "product_iva_rate_view", condicion1: "name", condicion2: "main_code", valor: campoValor, campo: "id, main_code, name, stock, price, price2, price3, iva_rate_name");
            ProductoDataGridView.DataSource = DataTableProducto;

            ProductoDataGridView.Columns["main_code"].Width = 100;
            ProductoDataGridView.Columns["name"].Width = 275;
            ProductoDataGridView.Columns["id"].Visible = false;
            ProductoDataGridView.Columns["stock"].Visible = false;
            ProductoDataGridView.Columns["price"].Visible = false;
            ProductoDataGridView.Columns["price2"].Visible = false;
            ProductoDataGridView.Columns["price3"].Visible = false;
            ProductoDataGridView.Columns["iva_rate_name"].Visible = false;
        }

        private void AgregarItemAListadoDatagridView()
        {
            ProductoDataGridView.Focus();
            listadoDataGridView.CurrentRow.Cells["idColumn"].Value = ProductoDataGridView.CurrentRow.Cells["id"].Value.ToString();
            listadoDataGridView.CurrentRow.Cells["mainCodeColumn"].Value = ProductoDataGridView.CurrentRow.Cells["main_code"].Value.ToString();
            listadoDataGridView.CurrentRow.Cells["nameColumn"].Value = ProductoDataGridView.CurrentRow.Cells["name"].Value.ToString();
            listadoDataGridView.CurrentRow.Cells["stockColumn"].Value = ProductoDataGridView.CurrentRow.Cells["stock"].Value.ToString();
            listadoDataGridView.CurrentRow.Cells["ivaRateColumn"].Value = ProductoDataGridView.CurrentRow.Cells["iva_rate_name"].Value.ToString();

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
            listadoDataGridView.CurrentRow.Cells["cantidadColumn"].Value = "1";
            listadoDataGridView.CurrentCell = listadoDataGridView.CurrentRow.Cells["cantidadColumn"];
            listadoDataGridView.Focus();
        }

        private void CalculoSubtotalesTextBoxs()
        {
            Subtotal12Decimal = 0;
            Subtotal0Decimal = 0;
            SubtotalDescuentoDecimal = 0;

            for (int i = 0; i < listadoDataGridView.Rows.Count - 1; i++)
            {
                if (listadoDataGridView.Rows[i].Cells["ivaRateColumn"].Value != null)
                {
                    if (listadoDataGridView.Rows[i].Cells["ivaRateColumn"].Value.ToString().Trim() == "12%")
                    {
                        decimal _subtotalDecimal = Convert.ToDecimal(listadoDataGridView.Rows[i].Cells["subtotalColumn"].Value);
                        Subtotal12Decimal += _subtotalDecimal;
                    }
                    else
                    {
                        decimal _subtotalDecimal = Convert.ToDecimal(listadoDataGridView.Rows[i].Cells["subtotalColumn"].Value);
                        Subtotal0Decimal += _subtotalDecimal;
                    }
                }

                decimal _subtotalDescuentoDecimal = Math.Round(Convert.ToDecimal(listadoDataGridView.Rows[i].Cells["descuentoColumn"].Value), 4);
                SubtotalDescuentoDecimal += _subtotalDescuentoDecimal;

            }

            FormatoDecimalF2(subtotal12TextBox, Subtotal12Decimal, false);
            FormatoDecimalF2(subtotal0TextBox, Subtotal0Decimal, false);

            decimal.TryParse(valorDescuentoTextBox.Text, out decimal _valorDescuentoDecimal);
            ValorDescuentoDecimal = _valorDescuentoDecimal;

            if (ValorDescuentoDecimal > Subtotal12Decimal)
            {
                ValorDescuentoDecimal = 0;
                DescuentoDecimal = 0;
            }

            SubtotalDecimal = Subtotal0Decimal + Subtotal12Decimal - ValorDescuentoDecimal;
            IvaDecimal = Math.Round((Subtotal12Decimal - ValorDescuentoDecimal) * 0.12M, 2);
            TotalDecimal = SubtotalDecimal + IvaDecimal;
            
            FormatoDecimalF2(subtotalTextBox, SubtotalDecimal, false);
            FormatoDecimalF2(ivaTextBox, IvaDecimal, false);
            FormatoDecimalF2(totalTextBox, TotalDecimal, false);
        }

        private void CalculoSubtotalesCeldasDataGridView()
        {
            if (listadoDataGridView.CurrentRow.Cells["cantidadColumn"].Value != null && listadoDataGridView.CurrentRow.Cells["stockColumn"].Value != null)
            {
                if (int.TryParse(listadoDataGridView.CurrentRow.Cells["cantidadColumn"].Value.ToString().Trim(), out int cantidad) && int.TryParse(listadoDataGridView.CurrentRow.Cells["stockColumn"].Value.ToString(), out int stock))
                {
                    if (cantidad == 0)
                    {
                        listadoDataGridView.Rows.RemoveAt(listadoDataGridView.CurrentRow.Index);
                    }

                    if (cantidad > stock)
                    {
                        MessageBox.Show($"Cantidad elegida supera el valor total disponible. \n\n\t**Disponible:  {listadoDataGridView.CurrentRow.Cells["stockColumn"].Value}");
                        listadoDataGridView.CurrentRow.Cells["cantidadColumn"].Value = listadoDataGridView.CurrentRow.Cells["stockColumn"].Value;
                    }

                    decimal cantidadDecimal = Convert.ToDecimal(listadoDataGridView.CurrentRow.Cells["cantidadColumn"].Value);
                    decimal precioDecimal = Convert.ToDecimal(listadoDataGridView.CurrentRow.Cells["precioColumn"].Value);
                    decimal descuentoDecimal = Math.Round(Convert.ToDecimal(listadoDataGridView.CurrentRow.Cells["descuentoColumn"].Value), 4);
                    decimal subtotalDecimal = Math.Round(cantidadDecimal * (precioDecimal - descuentoDecimal), 2);

                    listadoDataGridView.CurrentRow.Cells["descuentoColumn"].Value = descuentoDecimal;
                    listadoDataGridView.CurrentRow.Cells["subtotalColumn"].Value = subtotalDecimal;
                }
            }
        }
        private void CalculoDescuentoAdicional()
        {
            decimal.TryParse(descuentoTextBox.Text, out decimal _descuentoDecimal);
            DescuentoDecimal = Math.Round(_descuentoDecimal, 2);
            if (DescuentoSigno == "%")
            {
                valorDescuentoTextBox.Text = string.Format("{0:F2}", (Subtotal12Decimal * DescuentoDecimal) / 100);
            }
            if (DescuentoSigno == "$")
            {
                valorDescuentoTextBox.Text = string.Format("{0:F2}", DescuentoDecimal);
            }
        }

        #endregion

        #region COMPONENTES Y EVENTOS

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (nameTextBox.Text.Trim() != "CONSUMIDOR FINAL")
            {
                CargaContacto("business_name", nameTextBox);
            }
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

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            ClearFields();
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
            if (idNumberTextBox.Text.Trim() != "9999999999999")
            {
                CargaContacto("id_number", idNumberTextBox);
            }
        }

        private void IdNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Validaciones.Numeros(e.KeyChar);
        }

        private void IdNumberTextBox_Validating(object sender, CancelEventArgs e)
        {
            ValidaCampo.Identificacion(idNumberTextBox);
        }

        private void LandlineTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Validaciones.Telefonos(e.KeyChar);
        }

        private void BusquedaProductoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) 
            { 
                listadoDataGridView.Focus(); 
                ProductoPanel.Visible = false; 
            }
            if (e.KeyCode == Keys.Enter)
            {
                if (DataTableProducto.Rows.Count > 0) { AgregarItemAListadoDatagridView(); }
            }
            if (e.KeyCode == Keys.Down)
            {
                if (DataTableProducto.Rows.Count > 0) { ProductoDataGridView.Focus(); }
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
            if (e.KeyCode == Keys.Add) { CargaProducto(listadoDataGridView); }
        }

        private void ProductoDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AgregarItemAListadoDatagridView();
        }

        private void ProductoDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                if (ProductoDataGridView.CurrentCell.RowIndex == 0) { BusquedaProductoTextBox.Focus(); }
            }
            if (e.KeyCode == Keys.Enter)
            {
                if (DataTableProducto.Rows.Count > 0) { AgregarItemAListadoDatagridView(); }
            }
            if (e.KeyCode == Keys.Escape) 
            { 
                listadoDataGridView.Focus(); 
                ProductoPanel.Visible = false; 
            }
        }

        private void ListadoDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            CalculoSubtotalesCeldasDataGridView();
            CalculoDescuentoAdicional();
            CalculoSubtotalesTextBoxs();
        }

        private void DecimalesDataGridViewColumnKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void NumerosDataGridViewColumnKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ListadoDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(DecimalesDataGridViewColumnKeyPress);
            e.Control.KeyPress -= new KeyPressEventHandler(NumerosDataGridViewColumnKeyPress);
            if (listadoDataGridView.CurrentCell.ColumnIndex == 4)
            {
                if (e.Control is TextBox tb)
                {
                    tb.KeyPress += new KeyPressEventHandler(DecimalesDataGridViewColumnKeyPress);
                }
            }
            if (listadoDataGridView.CurrentCell.ColumnIndex == 2)
            {
                if (e.Control is TextBox tb)
                {
                    tb.KeyPress += new KeyPressEventHandler(NumerosDataGridViewColumnKeyPress);
                }
            }
        }

        private void DescuentoButton_Click(object sender, EventArgs e)
        {
            DescuentoSigno = DescuentoSigno == "%" ? "$" : "%";
            descuentoButton.Text = DescuentoSigno;
            CalculoDescuentoAdicional();
            CalculoSubtotalesTextBoxs();
        }

        private void DescuentoTextBox_TextChanged(object sender, EventArgs e)
        {
            CalculoDescuentoAdicional();
            CalculoSubtotalesTextBoxs();
        }

        private void DescuentoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Validaciones.DecimalesPunto(e.KeyChar);
            e.Handled = Validaciones.UnSoloPunto(sender, e);
        }

        private void DescuentoTextBox_Validating(object sender, CancelEventArgs e)
        {
            descuentoTextBox.Text = string.Format("{0:F2}", DescuentoDecimal);
        }

        private void DescuentoTextBox_Click(object sender, EventArgs e)
        {
            descuentoTextBox.SelectAll();
        }

        private void DescuentoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CalculoDescuentoAdicional();
                CalculoSubtotalesTextBoxs();
                additionalInformationTextBox.Focus();
            }

        }
        private void NameTextBox_Enter(object sender, EventArgs e)
        {
            if (idNumberTextBox.Text.Trim() == "9999999999999" && nameTextBox.Text.Trim() == "CONSUMIDOR FINAL")
            {
                nameTextBox.Text = "";
                nameTextBox.ForeColor = Color.Black;
                idNumberTextBox.Text = "";
                idNumberTextBox.ForeColor = Color.Black;
            }
        }
        private void NameTextBox_Leave(object sender, EventArgs e)
        {
            if (idNumberTextBox.Text.Trim() == "" && nameTextBox.Text.Trim() == "")
            {
                nameTextBox.Text = "CONSUMIDOR FINAL";
                nameTextBox.ForeColor = Color.DimGray;
                idNumberTextBox.Text = "9999999999999";
                idNumberTextBox.ForeColor = Color.DimGray;
            }
        }

        private void IdNumberTextBox_Enter(object sender, EventArgs e)
        {
            if (idNumberTextBox.Text.Trim() == "9999999999999" && nameTextBox.Text.Trim() == "CONSUMIDOR FINAL")
            {
                nameTextBox.Text = "";
                nameTextBox.ForeColor = Color.Black;
                idNumberTextBox.Text = "";
                idNumberTextBox.ForeColor = Color.Black;
            }
        }

        private void IdNumberTextBox_Leave(object sender, EventArgs e)
        {
            if (idNumberTextBox.Text.Trim() == "" && nameTextBox.Text.Trim() == "")
            {
                nameTextBox.Text = "CONSUMIDOR FINAL";
                nameTextBox.ForeColor = Color.DimGray;
                idNumberTextBox.Text = "9999999999999";
                idNumberTextBox.ForeColor = Color.DimGray;
            }
        }

        #endregion

        #endregion

        private void PrintButton_Click(object sender, EventArgs e)
        {
            PrinterName = Settings.Default.printerName;
            printerLabel.Text = PrinterName;

            if (nameTextBox.Text.Trim() != "CONSUMIDOR FINAL")
            {
                ValidaCampo.Requerido(idNumberTextBox, "Por favor ingrese el numero de Identificación");
                ValidaCampo.Requerido(nameTextBox, "Por favor ingrese el Nombre");
                ValidaCampo.Requerido(addressTextBox, "Por favor ingrese la Dirección");
            }
            ValidaCampo.Requerido(listadoDataGridView, mainPanel, "Por favor selecciona al menos un item");
            if (ValidaCampo.ErrorStatus)
            {


                printDocument.PrinterSettings.PrinterName = PrinterName;
                printDocument.PrinterSettings.DefaultPageSettings.PaperSize = new PaperSize("Nombre a poner a esta configuración", width, height);

                printDocument.Print();

            }
            
            
        }

        private void PrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
        }
    }
}
